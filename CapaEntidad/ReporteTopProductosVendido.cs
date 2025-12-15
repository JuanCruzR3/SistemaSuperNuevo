using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteTopProductosVendido
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }   
        public int CantidadVendida { get; set; }
    }
}
