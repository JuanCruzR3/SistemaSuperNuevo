using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();

            // ✅ NUEVO: Estado visible, pero NO editable
            // (asegurate de tener txtestado creado en el Designer)
            txtestado.ReadOnly = true;
            txtestado.TabStop = false; // opcional: que no lo enfoque con TAB
        }

        private void textBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta != null && oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario != null ? oVenta.oUsuario.NombreCompleto : "";

                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                // ✅ NUEVO: cargar estado (si viene null, no rompe)
                txtestado.Text = oVenta.Estado ?? "";

                dgvdata.Rows.Clear();

                if (oVenta.oDetalle_Venta != null)
                {
                    foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                    {
                        dgvdata.Rows.Add(new object[]
                        {
                            dv.oProducto != null ? dv.oProducto.Nombre : "",
                            dv.PrecioVenta,
                            dv.Cantidad,
                            dv.SubTotal
                        });
                    }
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = "";
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            // ✅ NUEVO: limpiar estado
            txtestado.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";

            txtbusqueda.Text = "";
            txtbusqueda.Select();
        }

        private void btnexpotar_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", (odatos.Nombre ?? "").ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC ?? "");
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion ?? "");

            Texto_Html = Texto_Html.Replace("@tipodocumento", (txttipodocumento.Text ?? "").ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text ?? "");

            Texto_Html = Texto_Html.Replace("@doccliente", txtdoccliente.Text ?? "");
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text ?? "");
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text ?? "");
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text ?? "");

            // (Opcional) Si querés agregarlo a la plantilla HTML más adelante:
            // Texto_Html = Texto_Html.Replace("@estado", txtestado.Text ?? "");

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + (row.Cells["Producto"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["Precio"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["Cantidad"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["SubTotal"].Value?.ToString() ?? "") + "</td>";
                filas += "</tr>";
            }

            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text ?? "0.00");
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text ?? "0.00");

            // ⚠️ acá tenías un bug: estabas poniendo montototal en cambio
            Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text ?? "0.00");

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido && byteimage != null && byteimage.Length > 0)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Documento Generado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
