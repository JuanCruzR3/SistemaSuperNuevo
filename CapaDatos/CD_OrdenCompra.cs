using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_OrdenCompra
    {
        // --------------------------------------------------------------------------------
        // 1. REGISTRAR ORDEN DE COMPRA (Funciona, se mantiene)
        // --------------------------------------------------------------------------------

        public int Registrar(Orden_Compra obj, DataTable DetalleOrdenCompra, out string Mensaje)
        {
            int idOrdenCompraGenerada = 0;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarOrdenCompra", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotalEstimado", obj.MontoTotalEstimado);

                    // Usamos el tipo de tabla [EDetalle_OrdenCompra] que espera el SP
                    cmd.Parameters.AddWithValue("DetalleOrdenCompra", DetalleOrdenCompra);

                    cmd.Parameters.Add("IdOrdenCompraResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idOrdenCompraGenerada = Convert.ToInt32(cmd.Parameters["IdOrdenCompraResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    idOrdenCompraGenerada = 0;
                    Mensaje = ex.Message;
                }
            }
            return idOrdenCompraGenerada;
        }

        // --------------------------------------------------------------------------------
        // 2. LISTAR ORDENES PENDIENTES (CORREGIDO: Mapeo a prueba de nulos)
        // --------------------------------------------------------------------------------

        public List<Orden_Compra> ListarOrdenesPendientes()
        {
            List<Orden_Compra> lista = new List<Orden_Compra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT 
                    OC.IdOrdenCompra, 
                    OC.NumeroDocumento, 
                    CONVERT(VARCHAR(10), OC.FechaRegistro, 103) AS FechaRegistro, 
                    OC.MontoTotalEstimado,
                    OC.IdProveedor,
                    P.Documento,        
                    P.RazonSocial AS ProveedorRazonSocial 
                FROM ORDEN_COMPRA OC
                LEFT JOIN PROVEEDOR P ON P.IdProveedor = OC.IdProveedor   
                WHERE OC.Estado IN ('PENDIENTE', 'RECIBIDO_PARCIAL')
                ORDER BY OC.FechaRegistro DESC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Orden_Compra oc = new Orden_Compra()
                            {
                                oProveedor = new Proveedor()
                            };

                            oc.IdOrdenCompra = Convert.ToInt32(dr["IdOrdenCompra"]);
                            oc.NumeroDocumento = dr["NumeroDocumento"].ToString();
                            oc.FechaRegistro = dr["FechaRegistro"].ToString();
                            oc.MontoTotalEstimado = Convert.ToDecimal(dr["MontoTotalEstimado"]);

                            oc.oProveedor.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
                            oc.oProveedor.Documento = dr["Documento"].ToString();
                            oc.oProveedor.RazonSocial = dr["ProveedorRazonSocial"].ToString();

                            lista.Add(oc);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en ListarOrdenesPendientes");
                }
            }
            return lista;
        }


        // --------------------------------------------------------------------------------
        // 3. OBTENER DETALLE DE ORDEN DE COMPRA (CORREGIDO: Mapeo a prueba de nulos)
        // --------------------------------------------------------------------------------

        public List<Detalle_Orden_Compra> ObtenerDetalleOrdenCompra(int idOrdenCompra)
        {
            List<Detalle_Orden_Compra> oLista = new List<Detalle_Orden_Compra>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT DOC.IdDetalleOrdenCompra, P.IdProducto, P.Nombre, P.Codigo,");
                    query.AppendLine("DOC.PrecioEstimado, DOC.CantidadOrdenada, DOC.CantidadRecibida, DOC.MontoTotalEstimado");
                    query.AppendLine("FROM DETALLE_ORDEN_COMPRA DOC");
                    query.AppendLine("INNER JOIN PRODUCTO P ON P.IdProducto = DOC.IdProducto");
                    query.AppendLine("WHERE DOC.IdOrdenCompra = @idOrdenCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idOrdenCompra", idOrdenCompra);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Detalle_Orden_Compra doc = new Detalle_Orden_Compra();

                            // 1. Mapeo Seguro de la Entidad
                            doc.IdDetalleOrdenCompra = dr["IdDetalleOrdenCompra"] != DBNull.Value ? Convert.ToInt32(dr["IdDetalleOrdenCompra"]) : 0;
                            doc.PrecioEstimado = dr["PrecioEstimado"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioEstimado"]) : 0.00m;
                            doc.CantidadOrdenada = dr["CantidadOrdenada"] != DBNull.Value ? Convert.ToInt32(dr["CantidadOrdenada"]) : 0;
                            doc.CantidadRecibida = dr["CantidadRecibida"] != DBNull.Value ? Convert.ToInt32(dr["CantidadRecibida"]) : 0;
                            doc.MontoTotalEstimado = dr["MontoTotalEstimado"] != DBNull.Value ? Convert.ToDecimal(dr["MontoTotalEstimado"]) : 0.00m;

                            // 2. Mapeo del Producto
                            doc.oProducto = new Producto()
                            {
                                IdProducto = dr["IdProducto"] != DBNull.Value ? Convert.ToInt32(dr["IdProducto"]) : 0,
                                Nombre = dr["Nombre"].ToString(),
                                Codigo = dr["Codigo"].ToString()
                            };

                            oLista.Add(doc);
                        }
                    }
                }
                catch (Exception ex)
                {
                    oLista = new List<Detalle_Orden_Compra>();
                }
            }
            return oLista;
        }

        // --------------------------------------------------------------------------------
        // 4. OBTENER CORRELATIVO (Se mantiene)
        // --------------------------------------------------------------------------------

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select COUNT(*) + 1 from ORDEN_COMPRA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    // La conversión debe ser segura
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idcorrelativo = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }
    }
}