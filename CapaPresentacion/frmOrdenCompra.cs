using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmOrdenCompra : Form
    {
        private Usuario usuarioActual;
        private DataTable dtDetalleOC = new DataTable();
        private Proveedor proveedorSeleccionado = null;

        // ====== NUEVO: MODO EDICIÓN ======
        private bool modoEdicion = false;
        private int idOrdenCompraEditar = 0;
        private bool permitirEditarProveedor = false;

        // ====== CONSTRUCTOR NORMAL ======
        public frmOrdenCompra(Usuario objUsuario)
        {
            InicializarDataTableDetalle();
            InitializeComponent();
            usuarioActual = objUsuario;
        }

        // ====== NUEVO: CONSTRUCTOR EDICIÓN ======
        public frmOrdenCompra(Usuario objUsuario, int idOrdenCompra, bool permitirEditarProveedor)
        {
            InicializarDataTableDetalle();
            InitializeComponent();

            // enganchar eventos de selección/click (sin duplicar)
            dgvDetalleOC.SelectionChanged -= dgvDetalleOC_SelectionChanged;
            dgvDetalleOC.SelectionChanged += dgvDetalleOC_SelectionChanged;

            dgvDetalleOC.CellClick -= dgvDetalleOC_CellClick;
            dgvDetalleOC.CellClick += dgvDetalleOC_CellClick;

            usuarioActual = objUsuario;
            modoEdicion = true;
            idOrdenCompraEditar = idOrdenCompra;
            this.permitirEditarProveedor = permitirEditarProveedor;
        }

        private void dgvDetalleOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            CargarProductoDesdeGrilla(e.RowIndex);
        }

        private void dgvDetalleOC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetalleOC.CurrentRow == null) return;
            CargarProductoDesdeGrilla(dgvDetalleOC.CurrentRow.Index);
        }

        private void CargarProductoDesdeGrilla(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvDetalleOC.Rows.Count) return;

            var row = dgvDetalleOC.Rows[rowIndex];
            if (row.IsNewRow) return;

            // ✅ Cargar a textbox
            txtidproducto.Text = row.Cells["IdProducto"].Value?.ToString() ?? "0";
            txtcodproducto.Text = row.Cells["Codigo"].Value?.ToString() ?? "";
            txtproducto.Text = row.Cells["NombreProducto"].Value?.ToString() ?? "";

            txtPrecioEstimado.Text = row.Cells["PrecioEstimado"].Value?.ToString() ?? "";
            txtCantidadOrdenada.Text = row.Cells["CantidadOrdenada"].Value?.ToString() ?? "1";

            txtPrecioEstimado.Focus();
        }

        private void InicializarDataTableDetalle()
        {
            if (dtDetalleOC.Columns.Count > 0) return;

            dtDetalleOC.Columns.Add("IdProducto", typeof(int));
            dtDetalleOC.Columns.Add("Codigo", typeof(string));
            dtDetalleOC.Columns.Add("NombreProducto", typeof(string));
            dtDetalleOC.Columns.Add("PrecioEstimado", typeof(decimal));
            dtDetalleOC.Columns.Add("CantidadOrdenada", typeof(int));
            dtDetalleOC.Columns.Add("MontoTotalEstimado", typeof(decimal));
        }

        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            if (txtTotalEstimado != null) txtTotalEstimado.Text = "0.00";
            if (txtidproveedor != null) txtidproveedor.Text = "0";
            if (txtidproducto != null) txtidproducto.Text = "0";

            if (dgvDetalleOC != null)
            {
                dgvDetalleOC.DataSource = dtDetalleOC;

                dgvDetalleOC.AllowUserToAddRows = false;
                dgvDetalleOC.MultiSelect = false;
                dgvDetalleOC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // ✅ Agregar botón eliminar
                AgregarColumnaEliminar();

                // ✅ Configurar edición correcta (SOLO precio/cantidad)
                ConfigurarGrillaEdicion();

                // ✅ Enganchar eventos (sin duplicar)
                dgvDetalleOC.CellContentClick -= dgvDetalleOC_CellContentClick;
                dgvDetalleOC.CellContentClick += dgvDetalleOC_CellContentClick;

                dgvDetalleOC.CellEndEdit -= dgvDetalleOC_CellEndEdit;
                dgvDetalleOC.CellEndEdit += dgvDetalleOC_CellEndEdit;

                dgvDetalleOC.DataError -= dgvDetalleOC_DataError;
                dgvDetalleOC.DataError += dgvDetalleOC_DataError;
            }

            if (!modoEdicion)
            {
                txtNumeroDocumento.Text = new CN_OrdenCompra().ObtenerCorrelativo().ToString("00000");
                txtNumeroDocumento.ReadOnly = true;
                btnRegistrarOrden.Text = "Registrar Orden";
            }
            else
            {
                // ====== CARGAR OC PARA EDICIÓN ======
                CargarOrdenParaEdicion(idOrdenCompraEditar);

                btnbuscarproveedor.Enabled = permitirEditarProveedor;

                txtdocproveedor.ReadOnly = true;
                txtnombreproveedor.ReadOnly = true;

                btnRegistrarOrden.Text = "Guardar Cambios";
            }

            if (modoEdicion)
            {
                btnVerPendientes.Enabled = false;
            }
        }

        // ====== CONFIGURAR EDICIÓN EN GRILLA ======
        private void ConfigurarGrillaEdicion()
        {
            dgvDetalleOC.ReadOnly = false;
            dgvDetalleOC.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvDetalleOC.RowHeadersVisible = false;
            dgvDetalleOC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Bloquear columnas NO editables
            if (dgvDetalleOC.Columns.Contains("IdProducto")) dgvDetalleOC.Columns["IdProducto"].ReadOnly = true;
            if (dgvDetalleOC.Columns.Contains("Codigo")) dgvDetalleOC.Columns["Codigo"].ReadOnly = true;
            if (dgvDetalleOC.Columns.Contains("NombreProducto")) dgvDetalleOC.Columns["NombreProducto"].ReadOnly = true;
            if (dgvDetalleOC.Columns.Contains("MontoTotalEstimado")) dgvDetalleOC.Columns["MontoTotalEstimado"].ReadOnly = true;

            // Permitir editar SOLO estas:
            if (dgvDetalleOC.Columns.Contains("PrecioEstimado")) dgvDetalleOC.Columns["PrecioEstimado"].ReadOnly = false;
            if (dgvDetalleOC.Columns.Contains("CantidadOrdenada")) dgvDetalleOC.Columns["CantidadOrdenada"].ReadOnly = false;

            // Formatos (opcional)
            if (dgvDetalleOC.Columns.Contains("PrecioEstimado"))
                dgvDetalleOC.Columns["PrecioEstimado"].DefaultCellStyle.Format = "0.00";

            if (dgvDetalleOC.Columns.Contains("MontoTotalEstimado"))
                dgvDetalleOC.Columns["MontoTotalEstimado"].DefaultCellStyle.Format = "0.00";
        }

        // ====== RECALCULAR AL EDITAR ======
        private void dgvDetalleOC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvDetalleOC.Columns[e.ColumnIndex].Name;
            if (colName != "PrecioEstimado" && colName != "CantidadOrdenada")
                return;

            var row = dgvDetalleOC.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            decimal precio = 0;
            int cantidad = 0;

            decimal.TryParse(row.Cells["PrecioEstimado"].Value?.ToString(),
                NumberStyles.Any, CultureInfo.CurrentCulture, out precio);

            int.TryParse(row.Cells["CantidadOrdenada"].Value?.ToString(), out cantidad);

            if (precio < 0) precio = 0;
            if (cantidad < 0) cantidad = 0;

            row.Cells["PrecioEstimado"].Value = precio;
            row.Cells["CantidadOrdenada"].Value = cantidad;
            row.Cells["MontoTotalEstimado"].Value = precio * cantidad;

            calcularTotalEstimado();
        }

        private void dgvDetalleOC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Valor inválido. Revisá Precio/Cantidad.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ====== CARGAR OC PARA EDICIÓN ======
        private void CargarOrdenParaEdicion(int idOrdenCompra)
        {
            var oc = new CN_OrdenCompra().ObtenerOrdenParaEdicion(idOrdenCompra);

            if (oc == null || oc.IdOrdenCompra <= 0)
            {
                MessageBox.Show("No se pudo cargar la orden para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtNumeroDocumento.Text = oc.NumeroDocumento;
            txtNumeroDocumento.ReadOnly = true;

            proveedorSeleccionado = oc.oProveedor;
            txtidproveedor.Text = oc.oProveedor.IdProveedor.ToString();
            txtdocproveedor.Text = oc.oProveedor.Documento;
            txtnombreproveedor.Text = oc.oProveedor.RazonSocial;

            dtDetalleOC.Clear();

            if (oc.oDetalleOrdenCompra != null)
            {
                foreach (var d in oc.oDetalleOrdenCompra)
                {
                    decimal monto = d.PrecioEstimado * d.CantidadOrdenada;

                    dtDetalleOC.Rows.Add(
                        d.oProducto.IdProducto,
                        d.oProducto.Codigo,
                        d.oProducto.Nombre,
                        d.PrecioEstimado,
                        d.CantidadOrdenada,
                        monto
                    );
                }
            }

            calcularTotalEstimado();
        }

        // ====== BUSCAR PROVEEDOR ======
        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            if (modoEdicion && !permitirEditarProveedor)
                return;

            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    proveedorSeleccionado = modal._Proveedor;
                    txtidproveedor.Text = proveedorSeleccionado.IdProveedor.ToString();
                    txtdocproveedor.Text = proveedorSeleccionado.Documento;
                    txtnombreproveedor.Text = proveedorSeleccionado.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
                }
            }
        }

        // ====== BUSCAR PRODUCTO ======
        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;

                    txtPrecioEstimado.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        // ====== AGREGAR PRODUCTO ======
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0 || proveedorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor para la orden.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Seleccione un producto para ordenar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecioEstimado.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal precioEstimado) || precioEstimado <= 0)
            {
                MessageBox.Show("Precio Estimado inválido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioEstimado.Select();
                return;
            }

            if (!int.TryParse(txtCantidadOrdenada.Text, out int cantidadOrdenada) || cantidadOrdenada <= 0)
            {
                MessageBox.Show("Cantidad a ordenar debe ser un número positivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidadOrdenada.Select();
                return;
            }

            bool existe = dgvDetalleOC.Rows
                .Cast<DataGridViewRow>()
                .Any(r => !r.IsNewRow &&
                          r.Cells["IdProducto"].Value != null &&
                          r.Cells["IdProducto"].Value.ToString() == txtidproducto.Text);

            if (existe)
            {
                MessageBox.Show("El producto ya fue agregado a la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal montoTotalEstimado = precioEstimado * cantidadOrdenada;

            var fila = dtDetalleOC.NewRow();
            fila["IdProducto"] = Convert.ToInt32(txtidproducto.Text);
            fila["Codigo"] = txtcodproducto.Text;
            fila["NombreProducto"] = txtproducto.Text;
            fila["PrecioEstimado"] = precioEstimado;
            fila["CantidadOrdenada"] = cantidadOrdenada;
            fila["MontoTotalEstimado"] = montoTotalEstimado;

            dtDetalleOC.Rows.Add(fila);

            calcularTotalEstimado();
            limpiarProducto();
            txtcodproducto.Select();
        }

        // ====== BOTÓN PRINCIPAL ======
        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            if (dtDetalleOC.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto en la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (proveedorSeleccionado == null || Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtDetalleSQL = new DataTable();
            dtDetalleSQL.Columns.Add("IdProducto", typeof(int));
            dtDetalleSQL.Columns.Add("PrecioEstimado", typeof(decimal));
            dtDetalleSQL.Columns.Add("CantidadOrdenada", typeof(int));
            dtDetalleSQL.Columns.Add("MontoTotalEstimado", typeof(decimal));

            foreach (DataRow row in dtDetalleOC.Rows)
            {
                dtDetalleSQL.Rows.Add(
                    Convert.ToInt32(row["IdProducto"]),
                    Convert.ToDecimal(row["PrecioEstimado"]),
                    Convert.ToInt32(row["CantidadOrdenada"]),
                    Convert.ToDecimal(row["MontoTotalEstimado"])
                );
            }

            string mensaje = string.Empty;

            if (!modoEdicion)
            {
                Orden_Compra oOrden = new Orden_Compra()
                {
                    oUsuario = usuarioActual,
                    oProveedor = proveedorSeleccionado,
                    TipoDocumento = "ORDEN COMPRA",
                    NumeroDocumento = txtNumeroDocumento.Text,
                    MontoTotalEstimado = Convert.ToDecimal(txtTotalEstimado.Text, CultureInfo.CurrentCulture)
                };

                int idOrdenGenerada = new CN_OrdenCompra().Registrar(oOrden, dtDetalleSQL, out mensaje);

                if (idOrdenGenerada > 0)
                {
                    MessageBox.Show("Orden de Compra registrada con éxito. ID: " + idOrdenGenerada, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarOrden();
                }
                else
                {
                    MessageBox.Show("Error al registrar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!new CN_OrdenCompra().PuedeEditar(idOrdenCompraEditar, out string msg))
                {
                    MessageBox.Show(msg, "No se puede editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ok = new CN_OrdenCompra().ActualizarOrdenCompra(
                    idOrdenCompraEditar,
                    proveedorSeleccionado.IdProveedor,
                    Convert.ToDecimal(txtTotalEstimado.Text, CultureInfo.CurrentCulture),
                    dtDetalleSQL,
                    usuarioActual.IdUsuario,
                    out mensaje
                );

                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (ok)
                {
                    this.Close();
                }
            }
        }

        // ====== TOTAL ======
        private void calcularTotalEstimado()
        {
            decimal total = 0;
            foreach (DataRow row in dtDetalleOC.Rows)
            {
                if (row["MontoTotalEstimado"] != DBNull.Value)
                    total += Convert.ToDecimal(row["MontoTotalEstimado"]);
            }
            txtTotalEstimado.Text = total.ToString("0.00");
        }

        // ====== LIMPIEZAS ======
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtPrecioEstimado.Text = "";
            txtCantidadOrdenada.Text = "1";
        }

        private void limpiarOrden()
        {
            proveedorSeleccionado = null;
            txtidproveedor.Text = "0";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            txtNumeroDocumento.Text = new CN_OrdenCompra().ObtenerCorrelativo().ToString("00000");
            dtDetalleOC.Clear();
            calcularTotalEstimado();
            limpiarProducto();
        }

        // ====== Eventos duplicados del diseñador ======
        private void btnbuscarproducto_Click_1(object sender, EventArgs e) => btnbuscarproducto_Click(sender, e);
        private void btnAgregarProducto_Click_1(object sender, EventArgs e) => btnAgregarProducto_Click(sender, e);
        private void frmOrdenCompra_Load_1(object sender, EventArgs e) => frmOrdenCompra_Load(sender, e);

        private void btnVerPendientes_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                MessageBox.Show("En modo edición no se puede abrir Pendientes.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var modal = new mdOrdenCompraPendiente(usuarioActual))
            {
                modal.ShowDialog();
            }
        }

        // ====== ELIMINAR POR COLUMNA BOTÓN ======
        private void AgregarColumnaEliminar()
        {
            if (dgvDetalleOC.Columns.Contains("btnEliminar"))
                return;

            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "btnEliminar";
            colEliminar.HeaderText = "";
            colEliminar.Text = "🗑";
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Width = 40;
            colEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvDetalleOC.Columns.Add(colEliminar);
        }

        private void dgvDetalleOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvDetalleOC.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirmar = MessageBox.Show(
                    "¿Eliminar este producto de la orden?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes)
                    return;

                dgvDetalleOC.Rows.RemoveAt(e.RowIndex);

                calcularTotalEstimado();
                limpiarProducto();
            }
        }
    }
}
