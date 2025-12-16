using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);
                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }

        // ✅ Listar para anular
        public List<Compra> ListarParaAnular()
        {
            return objcd_compra.ListarParaAnular();
        }

        // ✅ Anular
        public bool Anular(int idCompra, out string mensaje)
        {
            return objcd_compra.AnularCompra(idCompra, out mensaje);
        }
    }
}
