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
            // Aquí irían las validaciones de negocio antes de llamar a la capa de datos
            Mensaje = string.Empty;

            // Ejemplo de validación básica
            if (obj.oProveedor.IdProveedor == 0)
            {
                Mensaje = "Debe seleccionar un proveedor para la orden de compra.";
                return 0;
            }

            // ... (otras validaciones)

            return objcd_ordenCompra.Registrar(obj, DetalleOrdenCompra, out Mensaje);
        }

        public List<Orden_Compra> ListarOrdenesPendientes()
        {
            return objcd_ordenCompra.ListarOrdenesPendientes();
        }

        public List<Detalle_Orden_Compra> ObtenerDetalleOrdenCompra(int idOrdenCompra)
        {
            // Simplemente llama al método de la Capa de Datos
            return objcd_ordenCompra.ObtenerDetalleOrdenCompra(idOrdenCompra);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_ordenCompra.ObtenerCorrelativo();
        }
    }
}