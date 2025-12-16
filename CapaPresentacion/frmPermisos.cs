using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            dgvPermisos.AutoGenerateColumns = false;
            dgvPermisos.AllowUserToAddRows = false;
            dgvPermisos.RowHeadersVisible = false;
            txtDescripcionRol.Text = "";
            CargarPermisos();
            CargarGrupos();
        }

        private void CargarPermisos()
        {
            dgvPermisos.Columns.Clear();
            dgvPermisos.Rows.Clear();
            dgvPermisos.AllowUserToAddRows = false;

            dgvPermisos.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Seleccionar",
                Name = "Seleccionar"
            });

            dgvPermisos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nombre",
                Name = "NombreMenu"
            });

            dgvPermisos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "IdPermiso",
                Name = "IdPermiso",
                Visible = false
            });

            List<Permiso> listaPermisos = new CN_Permiso().ListarTodos();

            foreach (Permiso p in listaPermisos)
            {
                dgvPermisos.Rows.Add(false, p.NombreMenu, p.IdPermiso);
            }


        }

        private void CargarGrupos()
        {
            dgvGrupos.Columns.Clear();
            dgvGrupos.Rows.Clear();
            dgvGrupos.Columns.Add("IdRol", "ID");
            dgvGrupos.Columns["IdRol"].Visible = false;
            dgvGrupos.Columns.Add("Descripcion", "Descripción");

            List<Rol> listaRoles = new CN_Rol().Listar();
            foreach (Rol r in listaRoles)
            {
                dgvGrupos.Rows.Add(r.IdRol, r.Descripcion);
            }
        }

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idRol = Convert.ToInt32(dgvGrupos.Rows[e.RowIndex].Cells["IdRol"].Value);
                string descripcion = dgvGrupos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtDescripcionRol.Text = descripcion;
                txtDescripcionRol.Tag = idRol;

                foreach (DataGridViewRow row in dgvPermisos.Rows)
                    row.Cells["Seleccionar"].Value = false;

                List<int> permisos = new CN_RelacionPermisoRol().ListarIdPermisosPorRol(idRol);

                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    int idPermiso = Convert.ToInt32(row.Cells["IdPermiso"].Value);
                    if (permisos.Contains(idPermiso))
                        row.Cells["Seleccionar"].Value = true;
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string descripcion = txtDescripcionRol.Text.Trim();
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Ingrese un nombre para el grupo.");
                return;
            }

            List<int> permisosSeleccionados = new();
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                    permisosSeleccionados.Add(Convert.ToInt32(row.Cells["IdPermiso"].Value));
            }

            if (permisosSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un permiso.");
                return;
            }

            string mensaje;
            int idRol = new CN_Rol().Registrar(new Rol() { Descripcion = descripcion }, out mensaje);

            if (idRol > 0)
            {
                foreach (int idPermiso in permisosSeleccionados)
                    new CN_RelacionPermisoRol().AgregarRelacion(idPermiso, idRol);

                MessageBox.Show("Grupo creado correctamente.");
                txtDescripcionRol.Clear();
                txtDescripcionRol.Tag = null;
                LimpiarSeleccionPermisos();
                CargarGrupos();
            }
            else
            {
                MessageBox.Show("Error al crear el grupo: " + mensaje);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            if (txtDescripcionRol.Tag == null)
            {
                MessageBox.Show("Seleccione un grupo.");
                return;
            }

            int idRol = Convert.ToInt32(txtDescripcionRol.Tag);
            string descripcion = txtDescripcionRol.Text.Trim();

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }

            List<int> permisosSeleccionados = new();
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                    permisosSeleccionados.Add(Convert.ToInt32(row.Cells["IdPermiso"].Value));
            }

            if (permisosSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un permiso.");
                return;
            }

            string mensaje;
            new CN_Rol().Modificar(new Rol() { IdRol = idRol, Descripcion = descripcion }, out mensaje);
            new CN_RelacionPermisoRol().EliminarTodosPorRol(idRol);

            foreach (int idPermiso in permisosSeleccionados)
                new CN_RelacionPermisoRol().AgregarRelacion(idPermiso, idRol);

            MessageBox.Show("Grupo actualizado.");
            txtDescripcionRol.Clear();
            txtDescripcionRol.Tag = null;
            LimpiarSeleccionPermisos();
            CargarGrupos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (txtDescripcionRol.Tag == null)
            {
                MessageBox.Show("Seleccione un grupo.");
                return;
            }

            int idRol = Convert.ToInt32(txtDescripcionRol.Tag);

            if (new CN_Rol().VerificarUsoPorUsuarios(idRol))
            {
                MessageBox.Show("Este grupo está asignado a usuarios.");
                return;
            }

            if (MessageBox.Show("¿Eliminar grupo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new CN_RelacionPermisoRol().EliminarTodosPorRol(idRol);

                string mensaje;
                new CN_Rol().Eliminar(idRol, out mensaje);

                MessageBox.Show("Grupo eliminado.");
                txtDescripcionRol.Clear();
                txtDescripcionRol.Tag = null;
                LimpiarSeleccionPermisos();
                CargarGrupos();
            }
        }

        private void LimpiarSeleccionPermisos()
        {
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                if (row.Cells["Seleccionar"] != null)
                {
                    row.Cells["Seleccionar"].Value = false;
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtDescripcionRol.Clear();
            txtDescripcionRol.Tag = null;
            LimpiarSeleccionPermisos();
            dgvGrupos.ClearSelection();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btngruposusuarios_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de grupos por usuario
            frmGruposUsuario frm = new frmGruposUsuario();
            frm.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}
