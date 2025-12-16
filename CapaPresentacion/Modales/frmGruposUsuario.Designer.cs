namespace CapaPresentacion.Modales
{
    partial class frmGruposUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbousuarios = new ComboBox();
            dgvRoles = new DataGridView();
            Seleccionar = new DataGridViewCheckBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btncerrar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // cbousuarios
            // 
            cbousuarios.FormattingEnabled = true;
            cbousuarios.Location = new Point(398, 70);
            cbousuarios.Name = "cbousuarios";
            cbousuarios.Size = new Size(211, 28);
            cbousuarios.TabIndex = 0;
            cbousuarios.Click += cbousuarios_SelectedIndexChanged;
            // 
            // dgvRoles
            // 
            dgvRoles.BackgroundColor = SystemColors.Control;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { Seleccionar, IdRol, Descripcion });
            dgvRoles.Location = new Point(31, 70);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.RowTemplate.Height = 29;
            dgvRoles.Size = new Size(305, 355);
            dgvRoles.TabIndex = 1;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.MinimumWidth = 6;
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Width = 125;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(0, 64, 0);
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.Location = new Point(453, 293);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(156, 55);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.DarkRed;
            btncerrar.ForeColor = SystemColors.ControlLight;
            btncerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btncerrar.IconColor = Color.Black;
            btncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncerrar.Location = new Point(453, 370);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(156, 55);
            btncerrar.TabIndex = 3;
            btncerrar.Text = "Cerrar";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 4;
            label1.Text = "Roles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 47);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Usuarios:";
            // 
            // frmGruposUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 509);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncerrar);
            Controls.Add(btnguardar);
            Controls.Add(dgvRoles);
            Controls.Add(cbousuarios);
            Name = "frmGruposUsuario";
            Text = "frmGruposUsuario";
            Load += frmGruposUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbousuarios;
        private DataGridView dgvRoles;
        private DataGridViewCheckBoxColumn Seleccionar;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Descripcion;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btncerrar;
        private Label label1;
        private Label label2;
    }
}