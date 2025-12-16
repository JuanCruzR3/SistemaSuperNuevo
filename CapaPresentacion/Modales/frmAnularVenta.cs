using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class frmAnularVenta : Form
    {
        public frmAnularVenta()
        {
            InitializeComponent();
        }

        private void frmAnularVenta_Load(object sender, EventArgs e)
        {
            ConfigurarBuscador();
            CargarVentas();
        }

        private void ConfigurarBuscador()
        {
            cbobuscarpor.Items.Clear();

            // Tomamos columnas del dgv (solo visibles y con Name válido)
            foreach (DataGridViewColumn col in dgvdata.Columns)
            {
                if (col.Visible && !string.IsNullOrWhiteSpace(col.Name))
                {
                    cbobuscarpor.Items.Add(new OpcionCombo()
                    {
                        Valor = col.Name,
                        Texto = col.HeaderText
                    });
                }
            }

            cbobuscarpor.DisplayMember = "Texto";
            cbobuscarpor.ValueMember = "Valor";

            if (cbobuscarpor.Items.Count > 0)
                cbobuscarpor.SelectedIndex = 0;
        }

        private void CargarVentas()
        {
            dgvdata.Rows.Clear();

            List<Venta> lista = new CN_Venta().ListarParaAnular();

            foreach (Venta v in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    v.IdVenta,
                    v.FechaRegistro,
                    v.TipoDocumento,
                    v.NumeroDocumento,
                    v.DocumentoCliente,
                    v.NombreCliente,
                    v.MontoTotal,
                    v.Estado
                });
            }

            // Por si venís con filtros aplicados
            foreach (DataGridViewRow row in dgvdata.Rows)
                row.Visible = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbobuscarpor.SelectedItem == null) return;

            string columnafiltro = ((OpcionCombo)cbobuscarpor.SelectedItem).Valor.ToString();
            string texto = (txtbusqueda.Text ?? "").Trim().ToUpper();

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.IsNewRow) continue;

                string valor = row.Cells[columnafiltro].Value == null
                    ? ""
                    : row.Cells[columnafiltro].Value.ToString().Trim().ToUpper();

                row.Visible = valor.Contains(texto);
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (!row.IsNewRow)
                    row.Visible = true;
            }
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            if (dgvdata.CurrentRow == null || dgvdata.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione una venta.",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            int idVenta = Convert.ToInt32(dgvdata.CurrentRow.Cells["IdVenta"].Value);

            string estado = dgvdata.CurrentRow.Cells["Estado"].Value != null
                ? dgvdata.CurrentRow.Cells["Estado"].Value.ToString().Trim().ToUpper()
                : "";

            if (estado == "ANULADA")
            {
                MessageBox.Show(
                    "La venta ya se encuentra anulada.",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (MessageBox.Show(
                "¿Desea anular esta venta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
            {
                return;
            }

            bool ok = new CN_Venta().Anular(idVenta);

            if (ok)
            {
                MessageBox.Show(
                    "Venta anulada correctamente.",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                CargarVentas(); // refresca la grilla
            }
            else
            {
                MessageBox.Show(
                    "No se pudo anular la venta.",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
