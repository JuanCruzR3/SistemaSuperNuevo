using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_Reporte = new CD_Reporte();

        // Compras
        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_Reporte.Compra(fechainicio, fechafin, idproveedor);
        }

        // Ventas
        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            return objcd_Reporte.Venta(fechainicio, fechafin);
        }

        // Historial Órdenes de Compra
        public List<ReporteOrdenCompra> OrdenCompra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_Reporte.OrdenCompra(fechainicio, fechafin, idproveedor);
        }

        // ÓRDENES DE COMPRA POR ESTADO (gráfico)
        public List<ReporteOrdenCompraEstado> OrdenCompraPorEstado()
        {
            return objcd_Reporte.OrdenCompraPorEstado();
        }

        public List<ReporteTopProductosVendido> TopProductosVendidos(
            string fechainicio,
            string fechafin,
            int top)
        {
            return objcd_Reporte.TopProductosVendidos(fechainicio, fechafin, top);
        }

    }
}
