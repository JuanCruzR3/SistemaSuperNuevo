using System;
using System.Collections.Generic;

namespace CapaEntidad
{
    public class Orden_Compra
    {
        public int IdOrdenCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotalEstimado { get; set; }
        public string Estado { get; set; } 
        public List<Detalle_Orden_Compra> oDetalleOrdenCompra { get; set; }
        public string FechaRegistro { get; set; }
    }
}