using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_OrdenCompra
    {
        private CD_OrdenCompra objcd_ordenCompra = new CD_OrdenCompra();

        public int Registrar(Orden_Compra obj, DataTable DetalleOrdenCompra, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.oProveedor == null || obj.oProveedor.IdProveedor == 0)
            {
                Mensaje = "Debe seleccionar un proveedor para la orden de compra.";
                return 0;
            }

            return objcd_ordenCompra.Registrar(obj, DetalleOrdenCompra, out Mensaje);
        }

        public List<Orden_Compra> ListarOrdenesPendientes()
        {
            return objcd_ordenCompra.ListarOrdenesPendientes();
        }

        public List<Detalle_Orden_Compra> ObtenerDetalleOrdenCompra(int idOrdenCompra)
        {
            return objcd_ordenCompra.ObtenerDetalleOrdenCompra(idOrdenCompra);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_ordenCompra.ObtenerCorrelativo();
        }

        public bool Anular(int idOrdenCompra, int idUsuario, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (idOrdenCompra <= 0)
            {
                Mensaje = "IdOrdenCompra inválido.";
                return false;
            }

            return objcd_ordenCompra.Anular(idOrdenCompra, idUsuario, out Mensaje);
        }

        public bool PuedeEditar(int idOrdenCompra, out string mensaje)
        {
            return objcd_ordenCompra.PuedeEditar(idOrdenCompra, out mensaje);
        }

        // ====== NUEVO: TRAER OC COMPLETA PARA EDITAR ======
        public Orden_Compra ObtenerOrdenParaEdicion(int idOrdenCompra)
        {
            return objcd_ordenCompra.ObtenerOrdenParaEdicion(idOrdenCompra);
        }

        // ====== NUEVO: ACTUALIZAR OC (proveedor + detalle) ======
        public bool ActualizarOrdenCompra(int idOrdenCompra, int idProveedor, decimal montoTotalEstimado, DataTable detalleOrdenCompra, int idUsuario, out string mensaje)
        {
            mensaje = string.Empty;

            if (idOrdenCompra <= 0)
            {
                mensaje = "IdOrdenCompra inválido.";
                return false;
            }

            if (idProveedor <= 0)
            {
                mensaje = "Proveedor inválido.";
                return false;
            }

            if (detalleOrdenCompra == null || detalleOrdenCompra.Rows.Count == 0)
            {
                mensaje = "Debe ingresar al menos un producto en la orden.";
                return false;
            }

            // Seguridad: no editar si ya recibió algo o si hay compras
            if (!PuedeEditar(idOrdenCompra, out string msg))
            {
                mensaje = msg;
                return false;
            }

            return objcd_ordenCompra.ActualizarOrdenCompra(idOrdenCompra, idProveedor, montoTotalEstimado, detalleOrdenCompra, idUsuario, out mensaje);
        }
    }

}
