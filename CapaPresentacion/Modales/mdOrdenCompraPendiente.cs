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

        public mdOrdenCompraPendiente()
        {
            InitializeComponent();

            // Forzamos eventos para evitar problemas de diseñador
            this.Load += mdOrdenCompraPendiente_Load;
            dgvdata.SelectionChanged += dgvdata_SelectionChanged;
            dgvdata.CellClick += dgvdata_CellClick;
            dgvdata.CellDoubleClick += dgvdata_CellDoubleClick;

            // Config básica del detalle (por si no está en diseñador)
            dgvdetalles.ReadOnly = true;
            dgvdetalles.AllowUserToAddRows = false;
            dgvdetalles.AllowUserToDeleteRows = false;
            dgvdetalles.MultiSelect = false;
            dgvdetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // -----------------------------
        // LOAD: Carga cabecera de OC
        // -----------------------------
        private void mdOrdenCompraPendiente_Load(object sender, EventArgs e)
        {
            try
            {
                List<Orden_Compra> listaOC = new CN_OrdenCompra().ListarOrdenesPendientes();

                // 1) Cargar grilla de órdenes
                dgvdata.Rows.Clear();
                dgvdata.AllowUserToAddRows = false;

                foreach (Orden_Compra oc in listaOC)
                {
                    dgvdata.Rows.Add(
                        oc.NumeroDocumento,                      // 0 Nro. Orden
                        oc.FechaRegistro,                        // 1 Fecha
                        oc.oProveedor.RazonSocial,               // 2 Proveedor
                        oc.MontoTotalEstimado.ToString("0.00"),  // 3 Total Estimado
                        oc.IdOrdenCompra,                        // 4 IdOrdenCompra (oculta)
                        oc.oProveedor.IdProveedor,               // 5 IdProveedor (oculta)
                        oc.oProveedor.Documento                  // 6 DocumentoProveedor (oculta)
                    );
                }

                // 2) Ocultar columnas internas por nombre (si existen)
                if (dgvdata.Columns.Contains("IdOrdenCompra"))
                    dgvdata.Columns["IdOrdenCompra"].Visible = false;
                if (dgvdata.Columns.Contains("IdProveedor"))
                    dgvdata.Columns["IdProveedor"].Visible = false;
                if (dgvdata.Columns.Contains("DocumentoProveedor"))
                    dgvdata.Columns["DocumentoProveedor"].Visible = false;

                // 3) Seleccionar primera fila y cargar detalle automáticamente
                if (dgvdata.Rows.Count > 0)
                {
                    dgvdata.ClearSelection();
                    dgvdata.Rows[0].Selected = true;
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

        // -----------------------------------------
        // Al cambiar selección: cargar detalle
        // -----------------------------------------
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
            catch
            {
                // Evitar que el evento moleste en ciertos redraws
            }
        }

        // CellClick también ayuda cuando seleccionás con mouse
        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvdata.Rows[e.RowIndex];
                CargarDetalleOrdenDesdeFila(row);
            }
            catch
            {
                // silencio para no romper UX
            }
        }

        // -------------------------------------------------------
        // Cargar detalle de la OC seleccionada (productos)
        // -------------------------------------------------------
        private void CargarDetalleOrdenDesdeFila(DataGridViewRow filaOC)
        {
            if (filaOC == null) { LimpiarDetalle(); return; }

            // Tu IdOrdenCompra está en el índice 4 (columna oculta)
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

                // Si querés mostrar TODO, dejalo así.
                // Si querés SOLO pendientes, descomentá:
                // if (pendiente <= 0) continue;

                // Intentamos cargar por NOMBRE de columna (recomendado).
                // Si por alguna razón no existen esos nombres, cargamos por índice como fallback.
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

                    // Ocultas útiles
                    row.Cells["IdDetalleOrdenCompra"].Value = d.IdDetalleOrdenCompra;
                    row.Cells["IdProducto"].Value = d.oProducto.IdProducto;
                }
                else
                {
                    // Fallback por índice (si no pusiste los Names como acordamos)
                    dgvdetalles.Rows.Add(
                        d.oProducto.Codigo,                  // 0
                        d.oProducto.Nombre,                  // 1
                        cantOrdenada,                        // 2
                        cantRecibida,                        // 3
                        pendiente,                           // 4
                        d.PrecioEstimado.ToString("0.00"),   // 5
                        d.MontoTotalEstimado.ToString("0.00"), // 6
                        d.IdDetalleOrdenCompra,              // 7 (oculta)
                        d.oProducto.IdProducto               // 8 (oculta)
                    );
                }
            }

            // Asegurar ocultas
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

        // -------------------------------------------------------
        // Doble click: devolver OC seleccionada al formulario padre
        // -------------------------------------------------------
        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvdata.Rows[e.RowIndex];

            // Celdas visibles
            string numDoc = row.Cells[0].Value?.ToString() ?? "";
            string razonSocialProv = row.Cells[2].Value?.ToString() ?? "";

            // Celdas ocultas (Índices 4, 5 y 6)
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
    }
}
