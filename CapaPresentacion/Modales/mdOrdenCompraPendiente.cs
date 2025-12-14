using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdOrdenCompraPendiente : Form
    {
        public Orden_Compra _OrdenCompraSeleccionada { get; set; }

        // ✅ Usuario actual dentro del modal
        private Usuario usuarioActual;

        public mdOrdenCompraPendiente(Usuario usuario = null)
        {
            InitializeComponent();

            usuarioActual = usuario;

            // ✅ Evitar dobles eventos si el diseñador ya los engancha
            this.Load -= mdOrdenCompraPendiente_Load;
            this.Load += mdOrdenCompraPendiente_Load;

            dgvdata.SelectionChanged -= dgvdata_SelectionChanged;
            dgvdata.SelectionChanged += dgvdata_SelectionChanged;

            dgvdata.CellClick -= dgvdata_CellClick;
            dgvdata.CellClick += dgvdata_CellClick;

            dgvdata.CellDoubleClick -= dgvdata_CellDoubleClick;
            dgvdata.CellDoubleClick += dgvdata_CellDoubleClick;

            // ✅ Botones (si ya están en el diseñador, igual no se duplican)
            btnEditarOC.Click -= btnEditarOC_Click;
            btnEditarOC.Click += btnEditarOC_Click;

            btnAnularOC.Click -= btnAnularOC_Click;
            btnAnularOC.Click += btnAnularOC_Click;

            dgvdetalles.ReadOnly = true;
            dgvdetalles.AllowUserToAddRows = false;
            dgvdetalles.AllowUserToDeleteRows = false;
            dgvdetalles.MultiSelect = false;
            dgvdetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdata.MultiSelect = false;
        }

        private void mdOrdenCompraPendiente_Load(object sender, EventArgs e)
        {
            try
            {
                List<Orden_Compra> listaOC = new CN_OrdenCompra().ListarOrdenesPendientes();

                dgvdata.Rows.Clear();
                dgvdata.AllowUserToAddRows = false;

                foreach (Orden_Compra oc in listaOC)
                {
                    dgvdata.Rows.Add(
                        oc.NumeroDocumento,
                        oc.FechaRegistro,
                        oc.oProveedor.RazonSocial,
                        oc.MontoTotalEstimado.ToString("0.00"),
                        oc.IdOrdenCompra,
                        oc.oProveedor.IdProveedor,
                        oc.oProveedor.Documento
                    );
                }

                if (dgvdata.Columns.Contains("IdOrdenCompra"))
                    dgvdata.Columns["IdOrdenCompra"].Visible = false;
                if (dgvdata.Columns.Contains("IdProveedor"))
                    dgvdata.Columns["IdProveedor"].Visible = false;
                if (dgvdata.Columns.Contains("DocumentoProveedor"))
                    dgvdata.Columns["DocumentoProveedor"].Visible = false;

                if (dgvdata.Rows.Count > 0)
                {
                    dgvdata.ClearSelection();
                    dgvdata.Rows[0].Selected = true;

                    // ✅ asegurar CurrentCell para que SelectedRows/CurrentRow sea consistente
                    dgvdata.CurrentCell = dgvdata.Rows[0].Cells[0];

                    CargarDetalleOrdenDesdeFila(dgvdata.Rows[0]);
                }
                else
                {
                    LimpiarDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando órdenes: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dgvdata_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvdata.SelectedRows.Count == 0)
                {
                    LimpiarDetalle();
                    return;
                }

                CargarDetalleOrdenDesdeFila(dgvdata.SelectedRows[0]);
            }
            catch { }
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvdata.Rows[e.RowIndex];
                row.Selected = true;
                CargarDetalleOrdenDesdeFila(row);
            }
            catch { }
        }

        private void CargarDetalleOrdenDesdeFila(DataGridViewRow filaOC)
        {
            if (filaOC == null) { LimpiarDetalle(); return; }

            int idOC = 0;
            if (!int.TryParse(filaOC.Cells[4].Value?.ToString(), out idOC) || idOC <= 0)
            {
                LimpiarDetalle();
                return;
            }

            List<Detalle_Orden_Compra> detalles = new CN_OrdenCompra().ObtenerDetalleOrdenCompra(idOC);

            dgvdetalles.Rows.Clear();
            dgvdetalles.AllowUserToAddRows = false;

            foreach (var d in detalles)
            {
                int cantOrdenada = d.CantidadOrdenada;
                int cantRecibida = d.CantidadRecibida;
                int pendiente = cantOrdenada - cantRecibida;

                if (TieneColumnasDetallePorNombre())
                {
                    int idx = dgvdetalles.Rows.Add();
                    var row = dgvdetalles.Rows[idx];

                    row.Cells["CodigoProducto"].Value = d.oProducto.Codigo;
                    row.Cells["Producto"].Value = d.oProducto.Nombre;
                    row.Cells["CantidadOrdenada"].Value = cantOrdenada;
                    row.Cells["CantidadRecibida"].Value = cantRecibida;
                    row.Cells["CantidadPendiente"].Value = pendiente;
                    row.Cells["PrecioEstimado"].Value = d.PrecioEstimado.ToString("0.00");
                    row.Cells["SubtotalEstimado"].Value = d.MontoTotalEstimado.ToString("0.00");

                    row.Cells["IdDetalleOrdenCompra"].Value = d.IdDetalleOrdenCompra;
                    row.Cells["IdProducto"].Value = d.oProducto.IdProducto;
                }
                else
                {
                    dgvdetalles.Rows.Add(
                        d.oProducto.Codigo,
                        d.oProducto.Nombre,
                        cantOrdenada,
                        cantRecibida,
                        pendiente,
                        d.PrecioEstimado.ToString("0.00"),
                        d.MontoTotalEstimado.ToString("0.00"),
                        d.IdDetalleOrdenCompra,
                        d.oProducto.IdProducto
                    );
                }
            }

            OcultarColumnasDetalle();
        }

        private bool TieneColumnasDetallePorNombre()
        {
            return dgvdetalles.Columns.Contains("CodigoProducto")
                && dgvdetalles.Columns.Contains("Producto")
                && dgvdetalles.Columns.Contains("CantidadOrdenada")
                && dgvdetalles.Columns.Contains("CantidadRecibida")
                && dgvdetalles.Columns.Contains("CantidadPendiente")
                && dgvdetalles.Columns.Contains("PrecioEstimado")
                && dgvdetalles.Columns.Contains("SubtotalEstimado")
                && dgvdetalles.Columns.Contains("IdDetalleOrdenCompra")
                && dgvdetalles.Columns.Contains("IdProducto");
        }

        private void OcultarColumnasDetalle()
        {
            if (dgvdetalles.Columns.Contains("IdDetalleOrdenCompra"))
                dgvdetalles.Columns["IdDetalleOrdenCompra"].Visible = false;

            if (dgvdetalles.Columns.Contains("IdProducto"))
                dgvdetalles.Columns["IdProducto"].Visible = false;
        }

        private void LimpiarDetalle()
        {
            dgvdetalles.Rows.Clear();
            dgvdetalles.AllowUserToAddRows = false;
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvdata.Rows[e.RowIndex];

            string numDoc = row.Cells[0].Value?.ToString() ?? "";
            string razonSocialProv = row.Cells[2].Value?.ToString() ?? "";

            int idOC = 0;
            int idProveedor = 0;
            string docProv = "";

            int.TryParse(row.Cells[4].Value?.ToString(), out idOC);
            int.TryParse(row.Cells[5].Value?.ToString(), out idProveedor);
            docProv = row.Cells[6].Value?.ToString() ?? "";

            _OrdenCompraSeleccionada = new Orden_Compra()
            {
                IdOrdenCompra = idOC,
                NumeroDocumento = numDoc,
                oProveedor = new Proveedor()
                {
                    IdProveedor = idProveedor,
                    Documento = docProv,
                    RazonSocial = razonSocialProv
                }
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnularOC_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una orden.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var row = dgvdata.SelectedRows[0];

            int idOC = 0;
            int.TryParse(row.Cells[4].Value?.ToString(), out idOC);

            if (idOC <= 0)
            {
                MessageBox.Show("IdOrdenCompra inválido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                "¿Seguro que querés ANULAR esta Orden de Compra?\n\nEsto NO se puede deshacer.",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            int idUsuario = (usuarioActual != null) ? usuarioActual.IdUsuario : 0;

            string mensaje;
            bool ok = new CN_OrdenCompra().Anular(idOC, idUsuario, out mensaje);

            MessageBox.Show(mensaje, "Mensaje",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                mdOrdenCompraPendiente_Load(this, EventArgs.Empty);
            }
        }

        private void btnEditarOC_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná una orden.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var fila = dgvdata.SelectedRows[0];
            int idOC = 0;
            int.TryParse(fila.Cells[4].Value?.ToString(), out idOC);

            if (idOC <= 0)
            {
                MessageBox.Show("IdOrdenCompra inválido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string msg = "";
            bool editable = new CN_OrdenCompra().PuedeEditar(idOC, out msg);
            if (!editable)
            {
                MessageBox.Show(msg, "No se puede editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ YA NO SE USA Tag. Se usa el usuario del constructor.
            if (usuarioActual == null)
            {
                MessageBox.Show("No se encontró el usuario actual (constructor).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            using (var frm = new frmOrdenCompra(usuarioActual, idOC, permitirEditarProveedor: true))
            {
                frm.ShowDialog();
            }
            this.Show();

            mdOrdenCompraPendiente_Load(this, EventArgs.Empty);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
