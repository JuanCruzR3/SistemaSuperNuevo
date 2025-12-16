using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Modales 
{
    public partial class frmGruposUsuario : Form
    {
        public frmGruposUsuario()
        {
            InitializeComponent();

            // Si los controles existen, engancho eventos
            if (cbousuarios != null)
                cbousuarios.SelectedIndexChanged += cbousuarios_SelectedIndexChanged;
        }

        private void frmGruposUsuario_Load(object sender, EventArgs e)
        {
            ConfigurarGridRoles();
            CargarUsuarios();
            CargarRoles();
            MarcarRolesDelUsuarioActual();
        }

        private void CargarUsuarios()
        {
            cbousuarios.Items.Clear();

            // ✅ Si tu clase se llama distinto (por ejemplo CN_Usuarios), cambialo acá.
            List<Usuario> usuarios = new CN_Usuario().Listar();

            foreach (var u in usuarios)
            {
                cbousuarios.Items.Add(new OpcionCombo
                {
                    Valor = u.IdUsuario,
                    Texto = u.NombreCompleto
                });
            }

            cbousuarios.DisplayMember = "Texto";
            cbousuarios.ValueMember = "Valor";

            if (cbousuarios.Items.Count > 0)
                cbousuarios.SelectedIndex = 0;
        }

        private void ConfigurarGridRoles()
        {
            dgvRoles.Columns.Clear();
            dgvRoles.Rows.Clear();

            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.MultiSelect = false;

            dgvRoles.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Sel",
                Name = "Seleccionar",
                Width = 50
            });

            dgvRoles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "IdRol",
                Name = "IdRol",
                Visible = false
            });

            dgvRoles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Grupo",
                Name = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void CargarRoles()
        {
            dgvRoles.Rows.Clear();

            List<Rol> roles = new CN_Rol().Listar();

            foreach (var r in roles)
            {
                dgvRoles.Rows.Add(false, r.IdRol, r.Descripcion);
            }
        }

        private void MarcarRolesDelUsuarioActual()
        {
            if (cbousuarios.SelectedItem == null) return;

            int idUsuario = Convert.ToInt32(((OpcionCombo)cbousuarios.SelectedItem).Valor);

            List<int> rolesUsuario = new CN_UsuarioRol().ListarRolesPorUsuario(idUsuario);

            // limpiar checks
            foreach (DataGridViewRow row in dgvRoles.Rows)
                row.Cells["Seleccionar"].Value = false;

            // marcar
            foreach (DataGridViewRow row in dgvRoles.Rows)
            {
                int idRol = Convert.ToInt32(row.Cells["IdRol"].Value);
                if (rolesUsuario.Contains(idRol))
                    row.Cells["Seleccionar"].Value = true;
            }
        }

        private void cbousuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcarRolesDelUsuarioActual();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cbousuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int idUsuario = Convert.ToInt32(((OpcionCombo)cbousuarios.SelectedItem).Valor);

            List<int> rolesSeleccionados = new List<int>();

            foreach (DataGridViewRow row in dgvRoles.Rows)
            {
                bool sel = row.Cells["Seleccionar"].Value != null && Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                if (sel)
                    rolesSeleccionados.Add(Convert.ToInt32(row.Cells["IdRol"].Value));
            }

            bool ok = new CN_UsuarioRol().GuardarRolesUsuario(idUsuario, rolesSeleccionados);

            if (ok)
                MessageBox.Show("Grupos del usuario guardados correctamente.");
            else
                MessageBox.Show("No se pudo guardar. Revisá SPs / conexión / permisos.");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
