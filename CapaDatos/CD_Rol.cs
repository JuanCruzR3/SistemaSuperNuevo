using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdRol, Descripcion FROM ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<Rol>();
                }
            }

            return lista;
        }

        public int Registrar(Rol rol, out string mensaje)
        {
            mensaje = "";
            int idRol = 0;

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO ROL (Descripcion) OUTPUT INSERTED.IdRol VALUES (@Descripcion)", con, tran);
                    cmd.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
                    idRol = (int)cmd.ExecuteScalar();

                    foreach (var idPermiso in rol.Permisos.Select(p => p.IdPermiso))
                    {
                        SqlCommand cmdPerm = new SqlCommand("INSERT INTO RelacionPermisoRol (IdRol, IdPermiso) VALUES (@IdRol, @IdPermiso)", con, tran);
                        cmdPerm.Parameters.AddWithValue("@IdRol", idRol);
                        cmdPerm.Parameters.AddWithValue("@IdPermiso", idPermiso);
                        cmdPerm.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    mensaje = "Error al registrar rol: " + ex.Message;
                    idRol = 0;
                }
            }

            return idRol;
        }

        public bool Modificar(Rol rol, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE ROL SET Descripcion = @Descripcion WHERE IdRol = @IdRol", con, tran);
                    cmd.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
                    cmd.Parameters.AddWithValue("@IdRol", rol.IdRol);
                    cmd.ExecuteNonQuery();

                    tran.Commit();
                    resultado = true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    mensaje = "Error al modificar rol: " + ex.Message;
                    resultado = false;
                }
            }

            return resultado;
        }

        public bool Eliminar(int idRol, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    SqlCommand cmdPerm = new SqlCommand("DELETE FROM RelacionPermisoRol WHERE IdRol = @IdRol", con, tran);
                    cmdPerm.Parameters.AddWithValue("@IdRol", idRol);
                    cmdPerm.ExecuteNonQuery();

                    SqlCommand cmdRol = new SqlCommand("DELETE FROM ROL WHERE IdRol = @IdRol", con, tran);
                    cmdRol.Parameters.AddWithValue("@IdRol", idRol);
                    cmdRol.ExecuteNonQuery();

                    tran.Commit();
                    resultado = true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    mensaje = "Error al eliminar rol: " + ex.Message;
                    resultado = false;
                }
            }

            return resultado;
        }

        public List<int> ObtenerPermisosPorRol(int idRol)
        {
            List<int> permisos = new List<int>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdPermiso FROM RelacionPermisoRol WHERE IdRol = @IdRol";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            permisos.Add(Convert.ToInt32(dr["IdPermiso"]));
                        }
                    }
                }
                catch
                {
                    permisos = new List<int>();
                }
            }

            return permisos;
        }

        public bool ActualizarPermisosDeRol(int idRol, List<int> nuevosPermisos)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM RelacionPermisoRol WHERE IdRol = @IdRol", con, tran);
                    deleteCmd.Parameters.AddWithValue("@IdRol", idRol);
                    deleteCmd.ExecuteNonQuery();

                    foreach (int idPermiso in nuevosPermisos)
                    {
                        SqlCommand insertCmd = new SqlCommand("INSERT INTO RelacionPermisoRol (IdRol, IdPermiso) VALUES (@IdRol, @IdPermiso)", con, tran);
                        insertCmd.Parameters.AddWithValue("@IdRol", idRol);
                        insertCmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                        insertCmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        public bool VerificarUsoPorUsuarios(int idRol)
        {
            bool enUso = false;

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM USUARIO WHERE IdRol = @IdRol";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    enUso = count > 0;
                }
                catch
                {
                    enUso = false;
                }
            }

            return enUso;
        }
    }
}
