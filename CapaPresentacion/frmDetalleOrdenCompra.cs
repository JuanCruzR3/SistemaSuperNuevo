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
    public partial class frmDetalleOrdenCompra : Form
    {
        public frmDetalleOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmDetalleOrdenCompra_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView
            dgvdata.AllowUserToAddRows = false;
            dgvdata.ReadOnly = true;
            dgvdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdata.MultiSelect = false;
            dgvdata.ClearSelection();

            // Textbox de cabecera solo lectura
            txtnumerodocumento.ReadOnly = true;
            txtfecha.ReadOnly = true;
            txttipodocumento.ReadOnly = true;
            txtusuario.ReadOnly = true;
            txtdocproveedor.ReadOnly = true;
            txtnombreproveedor.ReadOnly = true;
            txtmontototal.ReadOnly = true;
            txtestado.ReadOnly = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string numero = txtbusqueda.Text.Trim();

            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Ingrese el Nro Documento de la Orden de Compra.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Orden_Compra oc = new CN_OrdenCompra().ObtenerOrdenCompraPorNumero(numero);

            if (oc == null || oc.IdOrdenCompra <= 0)
            {
                MessageBox.Show("No se encontró una Orden de Compra con ese número.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Cabecera
            txtnumerodocumento.Text = oc.NumeroDocumento;
            txtfecha.Text = oc.FechaRegistro;
            txttipodocumento.Text = oc.TipoDocumento;
            txtusuario.Text = oc.oUsuario != null ? oc.oUsuario.NombreCompleto : "";

            txtdocproveedor.Text = oc.oProveedor != null ? oc.oProveedor.Documento : "";
            txtnombreproveedor.Text = oc.oProveedor != null ? oc.oProveedor.RazonSocial : "";

            // ✅ Estado (si viene null, no rompe)
            txtestado.Text = oc.Estado ?? "";

            // Detalle
            dgvdata.Rows.Clear();

            if (oc.oDetalleOrdenCompra != null)
            {
                foreach (Detalle_Orden_Compra d in oc.oDetalleOrdenCompra)
                {
                    int ordenada = d.CantidadOrdenada;
                    int recibida = d.CantidadRecibida;
                    int pendiente = ordenada - recibida;

                    dgvdata.Rows.Add(new object[]
                    {
                        d.oProducto != null ? d.oProducto.Nombre : "",
                        d.PrecioEstimado.ToString("0.00"),
                        ordenada,
                        d.MontoTotalEstimado.ToString("0.00"),
                        recibida,
                        pendiente
                    });
                }
            }

            txtmontototal.Text = oc.MontoTotalEstimado.ToString("0.00");
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            txtnumerodocumento.Text = "";
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            txtestado.Text = "";
            txtmontototal.Text = "0.00";
            dgvdata.Rows.Clear();
        }

        private void textBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // =================================================================================
        // ✅ EXPORTAR PDF
        // =================================================================================
        private void btnexportarpdf_Click(object sender, EventArgs e)
        {
            // Si no hay nada cargado, no exportar
            if (string.IsNullOrWhiteSpace(txttipodocumento.Text) || string.IsNullOrWhiteSpace(txtnumerodocumento.Text))
            {
                MessageBox.Show("Primero buscá una Orden de Compra para poder exportar.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Plantilla desde Resources.resx
            string Texto_Html = Properties.Resources.PlantillaOrdenCompra.ToString();

            Negocio odatos = new CN_Negocio().ObtenerDatos();

            // Datos negocio
            Texto_Html = Texto_Html.Replace("@nombrenegocio", (odatos.Nombre ?? "").ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC ?? "");
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion ?? "");

            // Cabecera OC
            Texto_Html = Texto_Html.Replace("@tipodocumento", (txttipodocumento.Text ?? "").ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text ?? "");
            Texto_Html = Texto_Html.Replace("@estado", txtestado.Text ?? "");

            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocproveedor.Text ?? "");
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text ?? "");
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text ?? "");
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text ?? "");

            // Filas detalle (IMPORTANTE: nombres de columnas del Designer)
            // Deben existir: Producto, PrecioEstimado, CantidadOrdenada, Subtotal, CantidadRecibida, Pendiente
            string filas = string.Empty;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + (row.Cells["Producto"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["PrecioEstimado"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["CantidadOrdenada"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["Subtotal"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["CantidadRecibida"].Value?.ToString() ?? "") + "</td>";
                filas += "<td>" + (row.Cells["Pendiente"].Value?.ToString() ?? "") + "</td>";
                filas += "</tr>";
            }

            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text ?? "0.00");

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("OrdenCompra_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();

                        // Logo negocio
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
                    }

                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message, "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
