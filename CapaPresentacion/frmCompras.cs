using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;

        // --- ESTADO PARA RECEPCIÓN DESDE OC ---
        private Orden_Compra _OrdenCompra = null;

        // (Compatibilidad, no se usa en UI)
        private TextBox txtidordencompra;

        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();

            AplicarEstiloGrilla(dgvpendientesOC);
            dgvpendientesOC.ReadOnly = true;

            AplicarEstiloGrilla(dgvdata);
            dgvdata.ReadOnly = false; // porque ahí sí editás
            dgvdata.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2; 

            dgvdata.Refresh();
            dgvdata.Invalidate();

            txtidordencompra = new TextBox() { Text = "0" };
        }

        private void AplicarEstiloGrilla(DataGridView dgv)
        {
            dgv.SuspendLayout();

            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;

            // ✅ selección tipo “bloque”
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true; // para dgvpendientesOC (en dgvdata NO lo pongas si editás)
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            // ✅ highlight bien marcado
            dgv.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // (Opcional) más “clean”
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Gainsboro;

            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ResumeLayout();
        }



        private void frmCompras_Load(object sender, EventArgs e)
        {
            // Tipo Documento
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Recibo", Texto = "Recibo" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";

            dgvdata.AllowUserToAddRows = false;
            dgvpendientesOC.AllowUserToAddRows = false;

            // Enganchar eventos (evitar duplicarlos si el Load se ejecuta más de una vez)
            dgvdata.CellEndEdit -= dgvdata_CellEndEdit;
            dgvdata.CellEndEdit += dgvdata_CellEndEdit;

            dgvpendientesOC.SelectionChanged -= dgvpendientesOC_SelectionChanged;
            dgvpendientesOC.SelectionChanged += dgvpendientesOC_SelectionChanged;

            _OrdenCompra = null;

            dgvpendientesOC.Rows.Clear();
            limpiarProducto();

            // (Opcional) mejorar visual “invisible hasta tocar”
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdata.Refresh();
        }

        // =========================================================
        // 1) Seleccionar OC: cargar cabecera + cargar pendientes en dgvpendientesOC
        // =========================================================
        private void btnSeleccionarOC_Click(object sender, EventArgs e)
        {
            using (var modal = new mdOrdenCompraPendiente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _OrdenCompra = modal._OrdenCompraSeleccionada;

                    // Cabecera proveedor desde OC
                    txtidproveedor.Text = _OrdenCompra.oProveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = _OrdenCompra.NumeroDocumento; // Nro OC
                    txtnombreproveedor.Text = _OrdenCompra.oProveedor.RazonSocial;

                    // Cargar pendientes en el dgv nuevo
                    CargarPendientesOC(_OrdenCompra.IdOrdenCompra);

                    // No tocar dgvdata: solo se llena con "Agregar"
                    limpiarProducto();
                }
            }
        }

        // =========================================================
        // 1.1) Cargar pendientes de la OC en dgvpendientesOC
        // =========================================================
        private void CargarPendientesOC(int idOrdenCompra)
        {
            dgvpendientesOC.Rows.Clear();

            List<Detalle_Orden_Compra> lista = new CN_OrdenCompra().ObtenerDetalleOrdenCompra(idOrdenCompra);

            foreach (Detalle_Orden_Compra d in lista)
            {
                int pendiente = d.CantidadOrdenada - d.CantidadRecibida;
                if (pendiente <= 0) continue;

                dgvpendientesOC.Rows.Add(
                    d.IdDetalleOrdenCompra,                 // IdDetalleOrdenCompraOC (oculto)
                    d.oProducto.IdProducto,                 // IdProductoOC (oculto)
                    d.oProducto.Nombre,                     // ProductoOC
                    d.PrecioEstimado.ToString("0.00"),      // PrecioEstimadoOC
                    d.CantidadOrdenada,                     // CantidadOrdenadaOC
                    d.CantidadRecibida,                     // CantidadRecibidaOC
                    pendiente                               // CantidadPendienteOC
                );
            }

            // Ocultar columnas si hace falta
            if (dgvpendientesOC.Columns.Contains("IdDetalleOrdenCompraOC"))
                dgvpendientesOC.Columns["IdDetalleOrdenCompraOC"].Visible = false;
            if (dgvpendientesOC.Columns.Contains("IdProductoOC"))
                dgvpendientesOC.Columns["IdProductoOC"].Visible = false;

            dgvpendientesOC.Refresh();
        }

        // =========================================================
        // 1.2) Al seleccionar una fila pendiente -> llenar textbox
        // =========================================================
        private void dgvpendientesOC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvpendientesOC.CurrentRow == null) return;
            if (_OrdenCompra == null) return;

            DataGridViewRow row = dgvpendientesOC.CurrentRow;

            txtidDetalleOrdenCompra.Text = row.Cells["IdDetalleOrdenCompraOC"].Value?.ToString() ?? "0";
            txtidproducto.Text = row.Cells["IdProductoOC"].Value?.ToString() ?? "0";

            txtproducto.Text = row.Cells["ProductoOC"].Value?.ToString() ?? "";

            // Precio estimado como sugerencia (el usuario lo cambia a precio compra real)
            txtpreciocompra.Text = row.Cells["PrecioEstimadoOC"].Value?.ToString() ?? "";

            txtcantidadpendientemax.Text = row.Cells["CantidadPendienteOC"].Value?.ToString() ?? "0";

            int pendiente = 1;
            int.TryParse(txtcantidadpendientemax.Text, out pendiente);
            if (pendiente <= 0) pendiente = 1;
            txtcantidad.Value = pendiente;

            SetearTextoSeguro("txtIndiceFila", "-1");

            txtprecioventa.Focus();
        }

        // =========================================================
        // 2) Agregar producto al dgvdata SOLO al presionar "Agregar"
        // =========================================================
        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor u Orden de Compra.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // -----------------------------
            // 1) TOMAR PRODUCTO DESDE OC (si hay)
            // -----------------------------
            int idDetalleOC = 0;
            int idProducto = 0;
            string nombreProducto = "";
            int maxPendiente = 0;

            if (_OrdenCompra != null)
            {
                if (dgvpendientesOC.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un producto pendiente en la grilla de Pendientes OC.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var r = dgvpendientesOC.CurrentRow;

                idDetalleOC = Convert.ToInt32(r.Cells["IdDetalleOrdenCompraOC"].Value);
                idProducto = Convert.ToInt32(r.Cells["IdProductoOC"].Value);
                nombreProducto = r.Cells["ProductoOC"].Value?.ToString() ?? "";
                maxPendiente = Convert.ToInt32(r.Cells["CantidadPendienteOC"].Value);

                // reflejar en textbox
                txtidDetalleOrdenCompra.Text = idDetalleOC.ToString();
                txtidproducto.Text = idProducto.ToString();
                txtproducto.Text = nombreProducto;
                txtcantidadpendientemax.Text = maxPendiente.ToString();
            }
            else
            {
                // Compra directa
                if (Convert.ToInt32(txtidproducto.Text) == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                idProducto = Convert.ToInt32(txtidproducto.Text);
                nombreProducto = txtproducto.Text;

                idDetalleOC = 0;
                maxPendiente = 0;
            }

            // -----------------------------
            // 2) VALIDAR PRECIOS
            // -----------------------------
            if (!decimal.TryParse(txtpreciocompra.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal precioCompra))
            {
                MessageBox.Show("Precio Compra inválido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Focus();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal precioVenta))
            {
                MessageBox.Show("Precio Venta inválido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Focus();
                return;
            }

            // -----------------------------
            // 3) VALIDAR CANTIDAD
            // -----------------------------
            int cantidad = Convert.ToInt32(txtcantidad.Value);
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (_OrdenCompra != null && cantidad > maxPendiente)
            {
                MessageBox.Show($"No podés recibir más de lo pendiente ({maxPendiente}).",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -----------------------------
            // 4) SI YA EXISTE ESE ITEM (misma OC item) -> ACUMULAR
            // -----------------------------
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.IsNewRow) continue;

                int rowIdDetalle = 0;
                int.TryParse(row.Cells["IdDetalleOrdenCompra"].Value?.ToString(), out rowIdDetalle);

                if (_OrdenCompra != null && rowIdDetalle == idDetalleOC)
                {
                    int oldCant = 0;
                    int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out oldCant);

                    int maxFila = 0;
                    int.TryParse(row.Cells["CantidadPendienteMax"].Value?.ToString(), out maxFila);

                    int nuevaCant = oldCant + cantidad;

                    if (maxFila > 0 && nuevaCant > maxFila)
                    {
                        MessageBox.Show($"Esa línea no puede superar lo pendiente ({maxFila}).",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["PrecioCompra"].Value = precioCompra.ToString("0.00");
                    row.Cells["PrecioVenta"].Value = precioVenta.ToString("0.00");
                    row.Cells["Cantidad"].Value = nuevaCant;
                    row.Cells["Subtotal"].Value = (nuevaCant * precioCompra).ToString("0.00");

                    dgvdata.Refresh();
                    calcularTotal();
                    limpiarProducto();
                    return;
                }
            }

            // -----------------------------
            // 5) AGREGAR FILA NUEVA (asignando por Name)
            // -----------------------------
            int idx = dgvdata.Rows.Add();
            var newRow = dgvdata.Rows[idx];

            newRow.Cells["IdDetalleOrdenCompra"].Value = idDetalleOC;
            newRow.Cells["IdProducto"].Value = idProducto;
            newRow.Cells["Producto"].Value = nombreProducto;
            newRow.Cells["PrecioCompra"].Value = precioCompra.ToString("0.00");
            newRow.Cells["PrecioVenta"].Value = precioVenta.ToString("0.00");
            newRow.Cells["Cantidad"].Value = cantidad;
            newRow.Cells["Subtotal"].Value = (cantidad * precioCompra).ToString("0.00");
            newRow.Cells["CantidadPendienteMax"].Value = maxPendiente;

            dgvdata.Refresh();
            calcularTotal();
            limpiarProducto();
        }

        // =========================================================
        // 3) Registrar compra
        // =========================================================
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor o una Orden de Compra.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));
            detalle_compra.Columns.Add("IdDetalleOrdenCompra", typeof(int));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.IsNewRow) continue;

                int cantidad = 0;
                int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);
                if (cantidad <= 0) continue;

                int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);

                decimal precioCompra = 0;
                decimal.TryParse(row.Cells["PrecioCompra"].Value?.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out precioCompra);

                decimal precioVenta = 0;
                decimal.TryParse(row.Cells["PrecioVenta"].Value?.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out precioVenta);

                decimal subtotal = precioCompra * cantidad;

                int idDetalleOC = 0;
                int.TryParse(row.Cells["IdDetalleOrdenCompra"].Value?.ToString(), out idDetalleOC);

                detalle_compra.Rows.Add(idProducto, precioCompra, precioVenta, cantidad, subtotal, idDetalleOC);
            }

            if (detalle_compra.Rows.Count < 1)
            {
                MessageBox.Show("No hay productos con cantidad mayor a cero para registrar.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txttotalapagar.Text, CultureInfo.CurrentCulture),
                IdOrdenCompra = (_OrdenCompra != null) ? _OrdenCompra.IdOrdenCompra : 0
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Numero de compra generada:\n" + numerodocumento,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // refrescar pendientes si venía de OC (cuando SQL ya actualice recibidos)
                if (_OrdenCompra != null)
                {
                    CargarPendientesOC(_OrdenCompra.IdOrdenCompra);
                }

                btnlimpiarbuscador_Click(sender, e);
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // Recalcular subtotal al editar cantidad/precio en la grilla
        // =========================================================
        private void dgvdata_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dgvdata.Columns[e.ColumnIndex].Name;
            if (colName != "Cantidad" && colName != "PrecioCompra") return;

            var row = dgvdata.Rows[e.RowIndex];

            int cantidad = 0;
            int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);

            int maxPendiente = 0;
            int.TryParse(row.Cells["CantidadPendienteMax"].Value?.ToString(), out maxPendiente);

            if (maxPendiente > 0 && cantidad > maxPendiente)
            {
                MessageBox.Show($"No podés recibir más de lo pendiente ({maxPendiente}).",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.Cells["Cantidad"].Value = maxPendiente;
                cantidad = maxPendiente;
            }

            if (cantidad < 0)
            {
                row.Cells["Cantidad"].Value = 0;
                cantidad = 0;
            }

            decimal precioCompra = 0;
            decimal.TryParse(row.Cells["PrecioCompra"].Value?.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out precioCompra);

            row.Cells["Subtotal"].Value = (precioCompra * cantidad).ToString("0.00");

            dgvdata.Refresh();
            calcularTotal();
        }

        // =========================================================
        // Limpieza y total
        // =========================================================
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;

            SetearTextoSeguro("txtidDetalleOrdenCompra", "0");
            SetearTextoSeguro("txtcantidadpendientemax", "0");
            SetearTextoSeguro("txtIndiceFila", "-1");
        }

        private void calcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.IsNewRow) continue;

                decimal subtotal;
                if (decimal.TryParse(row.Cells["Subtotal"].Value?.ToString(),
                    NumberStyles.Any, CultureInfo.CurrentCulture, out subtotal))
                {
                    total += subtotal;
                }
            }

            txttotalapagar.Text = total.ToString("0.00");
        }

        // =========================================================
        // Botones / limpieza general
        // =========================================================
        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            btnSeleccionarOC_Click(sender, e);
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e) { }
        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e) { }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbotipodocumento.SelectedIndex = 0;

            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            txtidproveedor.Text = "0";

            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtidproducto.Text = "0";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;

            txttotalapagar.Text = "0.00";

            dgvdata.Rows.Clear();
            dgvpendientesOC.Rows.Clear();

            btnSeleccionarOC.Enabled = true;
            txtdocproveedor.ReadOnly = false;
            _OrdenCompra = null;

            btnagregarproducto.Enabled = true;
            txtcodproducto.ReadOnly = false;

            limpiarProducto();
        }

        // =========================================================
        // Botón eliminar: pintura y click
        // =========================================================
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Si no tenés el recurso, comentá estas líneas:
                var w = Properties.Resources.Delete25.Width;
                var h = Properties.Resources.Delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Delete25, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                dgvdata.Rows.RemoveAt(e.RowIndex);
                calcularTotal();
            }
        }

        // =========================================================
        // Doble click: modo edición (carga a textbox)
        // =========================================================
        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            if (iRow < 0) return;

            SetearTextoSeguro("txtIndiceFila", iRow.ToString());

            DataGridViewRow row = dgvdata.Rows[iRow];

            txtidproducto.Text = row.Cells["IdProducto"].Value?.ToString() ?? "0";
            txtidDetalleOrdenCompra.Text = row.Cells["IdDetalleOrdenCompra"].Value?.ToString() ?? "0";

            txtproducto.Text = row.Cells["Producto"].Value?.ToString() ?? "";
            txtpreciocompra.Text = row.Cells["PrecioCompra"].Value?.ToString() ?? "";
            txtprecioventa.Text = row.Cells["PrecioVenta"].Value?.ToString() ?? "";

            int cantidad = 1;
            int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);
            if (cantidad <= 0) cantidad = 1;
            txtcantidad.Value = cantidad;

            SetearTextoSeguro("txtcantidadpendientemax", row.Cells["CantidadPendienteMax"].Value?.ToString() ?? "0");

            txtcantidad.Select();
        }

        // =========================================================
        // Helpers: setear textbox sin romper si no existe
        // =========================================================
        private void SetearTextoSeguro(string nombreControl, string valor)
        {
            var controles = this.Controls.Find(nombreControl, true);
            if (controles != null && controles.Length > 0 && controles[0] is TextBox tb)
                tb.Text = valor;
        }

        // =========================================================
        // KeyPress helpers (compatibilidad designer)
        // =========================================================
        private void textBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            char sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if (e.KeyChar == sep && !((TextBox)sender).Text.Contains(sep)) return;

            e.Handled = true;
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            char sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if (e.KeyChar == sep && !((TextBox)sender).Text.Contains(sep)) return;

            e.Handled = true;
        }
    }
}
