using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_Reporte = new CD_Reporte();

        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_Reporte.Compra(fechainicio, fechafin, idproveedor);
        }

        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            return objcd_Reporte.Venta(fechainicio, fechafin);
        }

        // ✅ NUEVO: HISTORIAL ORDEN DE COMPRA
        public List<ReporteOrdenCompra> OrdenCompra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_Reporte.OrdenCompra(fechainicio, fechafin, idproveedor);
        }
    }
}
