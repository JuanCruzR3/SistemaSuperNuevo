using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol();

        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }

        public int Registrar(Rol rol, out string mensaje)
        {
            return objcd_rol.Registrar(rol, out mensaje);
        }

        public bool Modificar(Rol rol, out string mensaje)
        {
            return objcd_rol.Modificar(rol, out mensaje);
        }

        public bool Eliminar(int idRol, out string mensaje)
        {
            return objcd_rol.Eliminar(idRol, out mensaje);
        }

        public List<int> ObtenerPermisosDeRol(int idRol)
        {
            return objcd_rol.ObtenerPermisosPorRol(idRol);
        }

        public bool ActualizarPermisosDeRol(int idRol, List<int> nuevosPermisos)
        {
            return objcd_rol.ActualizarPermisosDeRol(idRol, nuevosPermisos);
        }

        public bool AsignarPermisosARol(int idRol, List<int> idPermisos)
        {
            return objcd_rol.ActualizarPermisosDeRol(idRol, idPermisos);
        }

        //  Verificar si un rol está asignado a algún usuario
        public bool VerificarUsoPorUsuarios(int idRol)
        {
            return objcd_rol.VerificarUsoPorUsuarios(idRol);
        }
    }
}
