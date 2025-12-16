using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_UsuarioRol
    {
        public List<int> ListarRolesPorUsuario(int idUsuario)
        {
            var lista = new List<int>();

            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarRolesPorUsuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(Convert.ToInt32(dr["IdRol"]));
                        }
                    }
                }
                catch
                {
                    lista = new List<int>();
                }
            }

            return lista;
        }

        public bool GuardarRolesUsuario(int idUsuario, List<int> roles)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string rolesCsv = (roles == null || roles.Count == 0) ? "" : string.Join(",", roles);

                    SqlCommand cmd = new SqlCommand("sp_GuardarRolesUsuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@RolesCSV", rolesCsv);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool ActualizarRolPrincipalUsuario(int idUsuario, int? idRolPrincipal)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE USUARIO SET IdRol = @IdRol WHERE IdUsuario = @IdUsuario";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                 
                    object valorRol = idRolPrincipal.HasValue ? (object)idRolPrincipal.Value : DBNull.Value;
                    cmd.Parameters.AddWithValue("@IdRol", valorRol);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
