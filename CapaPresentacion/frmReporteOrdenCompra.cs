using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaPresentacion.Modales; 

namespace CapaPresentacion
{
    public partial class frmReporteOrdenCompra : Form
    {
        public frmReporteOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmReporteOrdenCompra_Load(object sender, EventArgs e)
        {
            // Proveedores
            List<Proveedor> lista = new CN_Proveedor().Listar();

            cboproveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
            foreach (Proveedor item in lista)
                cboproveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });

            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;

            // Buscar por columnas
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobuscarpor.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbobuscarpor.DisplayMember = "Texto";
            cbobuscarpor.ValueMember = "Valor";
            cbobuscarpor.SelectedIndex = 0;
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            int idproveedor = Convert.ToInt32(((OpcionCombo)cboproveedor.SelectedItem).Valor.ToString());

            List<ReporteOrdenCompra> lista = new CN_Reporte().OrdenCompra(
                txtfechainicio.Value.ToString("yyyy-MM-dd"),
                txtfechafin.Value.ToString("yyyy-MM-dd"),
                idproveedor
            );

            dgvdata.Rows.Clear();

            foreach (ReporteOrdenCompra r in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    r.FechaRegistro,
                    r.NumeroDocumento,
                    r.Estado,
                    r.MontoTotalEstimado,
                    r.UsuarioRegistro,
                    r.DocumentoProveedor,
                    r.RazonSocial,
                    r.CodigoProducto,
                    r.NombreProducto,
                    r.Categoria,
                    r.PrecioEstimado,
                    r.CantidadOrdenada,
                    r.SubTotal
                });
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                dt.Columns.Add(columna.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible)
                {
                    dt.Rows.Add(new object[]
                    {
                        row.Cells["FechaRegistro"].Value?.ToString(),
                        row.Cells["NumeroDocumento"].Value?.ToString(),
                        row.Cells["Estado"].Value?.ToString(),
                        row.Cells["MontoTotalEstimado"].Value?.ToString(),
                        row.Cells["UsuarioRegistro"].Value?.ToString(),
                        row.Cells["DocumentoProveedor"].Value?.ToString(),
                        row.Cells["RazonSocial"].Value?.ToString(),
                        row.Cells["CodigoProducto"].Value?.ToString(),
                        row.Cells["NombreProducto"].Value?.ToString(),
                        row.Cells["Categoria"].Value?.ToString(),
                        row.Cells["PrecioEstimado"].Value?.ToString(),
                        row.Cells["CantidadOrdenada"].Value?.ToString(),
                        row.Cells["SubTotal"].Value?.ToString()
                    });
                }
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("ReporteOrdenCompra_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            savefile.Filter = "Excel files |*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook wb = new XLWorkbook();
                    var hoja = wb.Worksheets.Add(dt, "Informe");
                    hoja.ColumnsUsed().AdjustToContents();
                    wb.SaveAs(savefile.FileName);
                    MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error al generar el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnbuscarpor_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbobuscarpor.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    string valor = row.Cells[columnafiltro].Value?.ToString() ?? "";
                    row.Visible = valor.Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper());
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
                row.Visible = true;
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            using (var frm = new frmGraficoOrdenesCompraEstado())
            {
                frm.ShowDialog();
            }
        }

    }
}
