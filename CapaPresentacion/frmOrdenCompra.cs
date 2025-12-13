using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmOrdenCompra : Form
    {
        private Usuario usuarioActual;
        // La declaración del DataTable se mantiene a nivel de clase
        private DataTable dtDetalleOC = new DataTable();

        private Proveedor proveedorSeleccionado = null;

        public frmOrdenCompra(Usuario objUsuario)
        {
            // --- 🚨 INICIALIZACIÓN CRÍTICA EN EL CONSTRUCTOR 🚨 ---
            // Esto garantiza que el DataTable tenga sus columnas definidas antes de que cualquier botón 
            // intente acceder a ellas (lo que causa el error).

            // Si las columnas ya existen, esto podría fallar, pero como el error indica que no existen, 
            // asumimos que es el punto correcto para definirlas.
            dtDetalleOC.Columns.Add("IdProducto", typeof(int));
            dtDetalleOC.Columns.Add("Codigo", typeof(string));
            dtDetalleOC.Columns.Add("NombreProducto", typeof(string));
            dtDetalleOC.Columns.Add("PrecioEstimado", typeof(decimal));
            dtDetalleOC.Columns.Add("CantidadOrdenada", typeof(int));
            dtDetalleOC.Columns.Add("MontoTotalEstimado", typeof(decimal));
            // --------------------------------------------------------

            InitializeComponent();
            usuarioActual = objUsuario;
        }

        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            // --- 1. CONFIGURACIÓN INICIAL DE CONTROLES ---

            // Inicializar campos numéricos/decimales
            if (txtTotalEstimado != null) txtTotalEstimado.Text = "0.00";
            if (txtidproveedor != null) txtidproveedor.Text = "0";
            if (txtidproducto != null) txtidproducto.Text = "0";

            // Asignar el número de documento correlativo (CRÍTICO)
            // Se asume que el método ObtenerCorrelativo() está implementado en CN_OrdenCompra.
            txtNumeroDocumento.Text = new CN_OrdenCompra().ObtenerCorrelativo().ToString("00000");
            txtNumeroDocumento.ReadOnly = true;

            // Se ELIMINA la definición de columnas redundantes (dtDetalleOC.Columns.Add) de aquí.

            // Asignar al DataGridView
            if (dgvDetalleOC != null) { dgvDetalleOC.DataSource = dtDetalleOC; }
        }

        // --- LÓGICA DE BÚSQUEDA DE PROVEEDOR ---
        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
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

        // --- LÓGICA DE BÚSQUEDA DE PRODUCTO ---
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

        // --- LÓGICA DE AGREGAR PRODUCTO A LA ORDEN (FUNCIONA CON LA CORRECCIÓN DEL CONSTRUCTOR) ---
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal precioEstimado = 0;
            int cantidadOrdenada = 0;
            bool producto_existe = false;

            DataRow fila = null;

            // 1. VALIDACIONES CRÍTICAS
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

            // Validación de Precio Estimado
            if (!decimal.TryParse(txtPrecioEstimado.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out precioEstimado))
            {
                MessageBox.Show("Precio Estimado - Formato moneda incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioEstimado.Select();
                return;
            }

            // Validación de Cantidad Ordenada
            if (!int.TryParse(txtCantidadOrdenada.Text, out cantidadOrdenada) || cantidadOrdenada <= 0)
            {
                MessageBox.Show("Cantidad a ordenar debe ser un número positivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidadOrdenada.Select();
                return;
            }

            // 2. VERIFICAR SI EL PRODUCTO YA ESTÁ EN LA ORDEN
            foreach (DataGridViewRow dgvFila in dgvDetalleOC.Rows)
            {
                // Esta línea ahora funciona porque la columna IdProducto existe gracias al constructor.
                if (dgvFila.Cells["IdProducto"].Value != null && dgvFila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            // 3. AGREGAR PRODUCTO AL DATATABLE
            if (!producto_existe)
            {
                fila = dtDetalleOC.NewRow();

                decimal montoTotalEstimado = precioEstimado * cantidadOrdenada;

                // Mapeo de datos
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
            else
            {
                MessageBox.Show("El producto ya fue agregado a la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- LÓGICA DE REGISTRO DE LA ORDEN ---
        // --- CÓDIGO CORREGIDO EN frmOrdenCompra.cs ---

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            if (dtDetalleOC.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto en la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor para registrar la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- PASO CLAVE: CREAR EL DATATABLE CON SÓLO LAS 4 COLUMNAS QUE SQL ESPERA ---
            DataTable dtDetalleSQL = new DataTable();

            // Nombres exactos del Tipo de Tabla (UDTT: EDetalle_OrdenCompra) en SQL
            dtDetalleSQL.Columns.Add("IdProducto", typeof(int));
            dtDetalleSQL.Columns.Add("PrecioEstimado", typeof(decimal));
            dtDetalleSQL.Columns.Add("CantidadOrdenada", typeof(int));
            dtDetalleSQL.Columns.Add("MontoTotalEstimado", typeof(decimal));

            // Copiar datos del DataTable de 6 columnas al DataTable de 4 columnas
            foreach (DataRow row in dtDetalleOC.Rows)
            {
                dtDetalleSQL.Rows.Add(
                    Convert.ToInt32(row["IdProducto"]),
                    Convert.ToDecimal(row["PrecioEstimado"]),
                    Convert.ToInt32(row["CantidadOrdenada"]),
                    Convert.ToDecimal(row["MontoTotalEstimado"])
                );
            }

            // 1. Crear Cabecera de Orden de Compra
            Orden_Compra oOrden = new Orden_Compra()
            {
                oUsuario = usuarioActual,
                oProveedor = proveedorSeleccionado,
                TipoDocumento = "ORDEN COMPRA",
                NumeroDocumento = txtNumeroDocumento.Text,
                MontoTotalEstimado = Convert.ToDecimal(txtTotalEstimado.Text)
            };

            // 2. Enviar a Negocio (Ahora enviamos el DataTable 'dtDetalleSQL' de 4 columnas)
            string mensaje = string.Empty;
            // OJO: Se envía dtDetalleSQL, NO dtDetalleOC
            int idOrdenGenerada = new CN_OrdenCompra().Registrar(oOrden, dtDetalleSQL, out mensaje);

            if (idOrdenGenerada > 0)
            {
                MessageBox.Show("Orden de Compra registrada con éxito. ID: " + idOrdenGenerada, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarOrden();
            }
            else
            {
                // El error ahora debería ser un error de SQL, no un error de estructura.
                MessageBox.Show("Error al registrar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MÉTODOS AUXILIARES ---

        private void calcularTotalEstimado()
        {
            decimal total = 0;
            string columnName = "MontoTotalEstimado";

            if (dtDetalleOC.Rows.Count > 0)
            {
                foreach (DataRow row in dtDetalleOC.Rows)
                {
                    if (row[columnName] != DBNull.Value)
                    {
                        total += Convert.ToDecimal(row[columnName]);
                    }
                }
                txtTotalEstimado.Text = total.ToString("0.00");
            }
            else
            {
                txtTotalEstimado.Text = "0.00";
            }
        }

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
            txtNumeroDocumento.Text = new CN_OrdenCompra().ObtenerCorrelativo().ToString("00000"); // Actualizar Correlativo
            dtDetalleOC.Clear();
            calcularTotalEstimado();
            limpiarProducto();
        }

        // --- MÉTODOS DE EVENTO VINCULADOS ---

        private void btnbuscarproducto_Click_1(object sender, EventArgs e)
        {
            btnbuscarproducto_Click(sender, e);
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            btnAgregarProducto_Click(sender, e);
        }

        private void frmOrdenCompra_Load_1(object sender, EventArgs e)
        {
            frmOrdenCompra_Load(sender, e);
        }
    }
}