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
            return objcd_ordenCompra.Anular(idOrdenCompra, idUsuario, out Mensaje);
        }

        public bool PuedeEditar(int idOrdenCompra, out string mensaje)
        {
            return objcd_ordenCompra.PuedeEditar(idOrdenCompra, out mensaje);
        }

        public Orden_Compra ObtenerOrdenParaEdicion(int idOrdenCompra)
        {
            return objcd_ordenCompra.ObtenerOrdenParaEdicion(idOrdenCompra);
        }

        public bool ActualizarOrdenCompra(int idOrdenCompra, int idProveedor, decimal montoTotalEstimado,
            DataTable detalleOrdenCompra, int idUsuario, out string mensaje)
        {
            return objcd_ordenCompra.ActualizarOrdenCompra(
                idOrdenCompra, idProveedor, montoTotalEstimado,
                detalleOrdenCompra, idUsuario, out mensaje);
        }

        public Orden_Compra ObtenerOrdenCompraPorNumero(string numeroDocumento)
        {
            return objcd_ordenCompra.ObtenerOrdenCompraPorNumero(numeroDocumento);
        }
    }
}
