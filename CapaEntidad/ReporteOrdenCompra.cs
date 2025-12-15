using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteOrdenCompra
    {
        public string FechaRegistro { get; set; }
        public string NumeroDocumento { get; set; }
        public string Estado { get; set; }
        public decimal MontoTotalEstimado { get; set; }
        public string UsuarioRegistro { get; set; }
        public string DocumentoProveedor { get; set; }
        public string RazonSocial { get; set; }

        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }

        public decimal PrecioEstimado { get; set; }
        public int CantidadOrdenada { get; set; }
        public decimal SubTotal { get; set; }
    }
}

