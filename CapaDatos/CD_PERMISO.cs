using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            var lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT DISTINCT p.IdPermiso, p.NombreMenu
                        FROM PERMISO p
                        INNER JOIN RelacionPermisoRol rr ON rr.IdPermiso = p.IdPermiso
                        INNER JOIN (
                            SELECT ur.IdRol
                            FROM USUARIO_ROL ur
                            WHERE ur.IdUsuario = @idusuario

                            UNION

                            SELECT u.IdRol
                            FROM USUARIO u
                            WHERE u.IdUsuario = @idusuario AND u.IdRol IS NOT NULL
                        ) roles ON roles.IdRol = rr.IdRol
                        ORDER BY p.NombreMenu;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@idusuario", idusuario);

                        oconexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Permiso
                                {
                                    IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                    NombreMenu = dr["NombreMenu"].ToString()
                                });
                            }
                        }
                    }
                }
                catch
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;
        }

        public List<Permiso> ListarTodos()
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT MIN(IdPermiso) AS IdPermiso, NombreMenu
                FROM PERMISO
                GROUP BY NombreMenu
                ORDER BY NombreMenu";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Permiso()
                                {
                                    IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                    NombreMenu = dr["NombreMenu"].ToString()
                                });
                            }
                        }
                    }
                }
                catch
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;
        }

    }
}
