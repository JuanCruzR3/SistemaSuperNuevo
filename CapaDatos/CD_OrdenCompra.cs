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
        // 1. REGISTRAR ORDEN DE COMPRA
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
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotalEstimado", obj.MontoTotalEstimado);

                    cmd.Parameters.AddWithValue("DetalleOrdenCompra", DetalleOrdenCompra);

                    cmd.Parameters.Add("IdOrdenCompraResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

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
        // 2. LISTAR ÓRDENES PENDIENTES
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
                            Orden_Compra oc = new Orden_Compra
                            {
                                IdOrdenCompra = Convert.ToInt32(dr["IdOrdenCompra"]),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                MontoTotalEstimado = Convert.ToDecimal(dr["MontoTotalEstimado"]),
                                oProveedor = new Proveedor
                                {
                                    IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                    Documento = dr["Documento"].ToString(),
                                    RazonSocial = dr["ProveedorRazonSocial"].ToString()
                                }
                            };

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
        // 3. OBTENER DETALLE DE ORDEN
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

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Orden_Compra
                            {
                                IdDetalleOrdenCompra = Convert.ToInt32(dr["IdDetalleOrdenCompra"]),
                                PrecioEstimado = Convert.ToDecimal(dr["PrecioEstimado"]),
                                CantidadOrdenada = Convert.ToInt32(dr["CantidadOrdenada"]),
                                CantidadRecibida = Convert.ToInt32(dr["CantidadRecibida"]),
                                MontoTotalEstimado = Convert.ToDecimal(dr["MontoTotalEstimado"]),
                                oProducto = new Producto
                                {
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    Codigo = dr["Codigo"].ToString()
                                }
                            });
                        }
                    }
                }
                catch
                {
                    oLista = new List<Detalle_Orden_Compra>();
                }
            }
            return oLista;
        }

        // --------------------------------------------------------------------------------
        // 4. OBTENER ORDEN COMPLETA PARA EDICIÓN
        // --------------------------------------------------------------------------------
        public Orden_Compra ObtenerOrdenParaEdicion(int idOrdenCompra)
        {
            Orden_Compra oc = null;

            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                cn.Open();

                string query = @"
                    SELECT OC.IdOrdenCompra, OC.NumeroDocumento, OC.MontoTotalEstimado,
                           OC.IdProveedor, P.Documento, P.RazonSocial
                    FROM ORDEN_COMPRA OC
                    INNER JOIN PROVEEDOR P ON P.IdProveedor = OC.IdProveedor
                    WHERE OC.IdOrdenCompra = @id";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", idOrdenCompra);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        oc = new Orden_Compra
                        {
                            IdOrdenCompra = idOrdenCompra,
                            NumeroDocumento = dr["NumeroDocumento"].ToString(),
                            MontoTotalEstimado = Convert.ToDecimal(dr["MontoTotalEstimado"]),
                            oProveedor = new Proveedor
                            {
                                IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString()
                            },
                            oDetalleOrdenCompra = new List<Detalle_Orden_Compra>()
                        };
                    }
                }

                if (oc != null)
                    oc.oDetalleOrdenCompra = ObtenerDetalleOrdenCompra(idOrdenCompra);
            }

            return oc ?? new Orden_Compra();
        }

        // --------------------------------------------------------------------------------
        // 5. ACTUALIZAR ORDEN DE COMPRA (EDICIÓN)
        // --------------------------------------------------------------------------------
        public bool ActualizarOrdenCompra(int idOrdenCompra, int idProveedor, decimal montoTotalEstimado,
            DataTable detalleOrdenCompra, int idUsuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = "";

            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarOrdenCompra", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdOrdenCompra", idOrdenCompra);
                    cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@MontoTotalEstimado", montoTotalEstimado);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@DetalleOrdenCompra", detalleOrdenCompra);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        // --------------------------------------------------------------------------------
        // 6. ANULAR ORDEN DE COMPRA
        // --------------------------------------------------------------------------------
        public bool Anular(int idOrdenCompra, int idUsuario, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_AnularOrdenCompra", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdOrdenCompra", idOrdenCompra);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        // --------------------------------------------------------------------------------
        // 7. VALIDAR SI SE PUEDE EDITAR
        // --------------------------------------------------------------------------------
        public bool PuedeEditar(int idOrdenCompra, out string mensaje)
        {
            mensaje = "";

            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                cn.Open();

                string q1 = @"SELECT COUNT(*) 
                              FROM DETALLE_ORDEN_COMPRA 
                              WHERE IdOrdenCompra = @id AND ISNULL(CantidadRecibida,0) > 0";

                SqlCommand cmd1 = new SqlCommand(q1, cn);
                cmd1.Parameters.AddWithValue("@id", idOrdenCompra);

                if (Convert.ToInt32(cmd1.ExecuteScalar()) > 0)
                {
                    mensaje = "No se puede editar: la orden ya tiene recepciones.";
                    return false;
                }

                string q2 = @"SELECT COUNT(*) FROM COMPRA WHERE IdOrdenCompra = @id";
                SqlCommand cmd2 = new SqlCommand(q2, cn);
                cmd2.Parameters.AddWithValue("@id", idOrdenCompra);

                if (Convert.ToInt32(cmd2.ExecuteScalar()) > 0)
                {
                    mensaje = "No se puede editar: ya hay compras registradas para esta orden.";
                    return false;
                }

                return true;
            }
        }

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT COUNT(*) + 1 FROM ORDEN_COMPRA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        idcorrelativo = Convert.ToInt32(result);
                }
                catch
                {
                    idcorrelativo = 0;
                }
            }

            return idcorrelativo;
        }

    }

}
