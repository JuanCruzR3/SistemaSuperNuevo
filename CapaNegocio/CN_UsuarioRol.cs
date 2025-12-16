using System.Collections.Generic;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_UsuarioRol
    {
        private CD_UsuarioRol obj = new CD_UsuarioRol();

        public List<int> ListarRolesPorUsuario(int idUsuario)
        {
            return obj.ListarRolesPorUsuario(idUsuario);
        }

        public bool GuardarRolesUsuario(int idUsuario, List<int> roles)
        {
            // guarda relación
            bool ok = obj.GuardarRolesUsuario(idUsuario, roles);

            if (!ok) return false;

            // rol principal (compatibilidad): primer rol
            int? rolPrincipal = (roles != null && roles.Count > 0) ? roles[0] : (int?)null;
            obj.ActualizarRolPrincipalUsuario(idUsuario, rolPrincipal);

            return true;
        }
    }
}
