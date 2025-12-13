using System;
using System.Collections.Generic;

namespace CapaEntidad
{
    public class Detalle_Orden_Compra
    {
        public int IdDetalleOrdenCompra { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioEstimado { get; set; }
        public int CantidadOrdenada { get; set; }
        public int CantidadRecibida { get; set; }
        public decimal MontoTotalEstimado { get; set; }
        public string FechaRegistro { get; set; }
    }
}