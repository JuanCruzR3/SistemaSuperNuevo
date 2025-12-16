namespace CapaPresentacion
{
    partial class frmPermisos
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
            dgvPermisos = new DataGridView();
            txtDescripcionRol = new TextBox();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnmodificar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            dgvGrupos = new DataGridView();
            btncancelar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnregresar = new FontAwesome.Sharp.IconButton();
            btngruposusuarios = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // dgvPermisos
            // 
            dgvPermisos.BackgroundColor = SystemColors.Control;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Location = new Point(285, 18);
            dgvPermisos.Margin = new Padding(2, 2, 2, 2);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.RowHeadersWidth = 62;
            dgvPermisos.RowTemplate.Height = 33;
            dgvPermisos.Size = new Size(296, 326);
            dgvPermisos.TabIndex = 0;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Location = new Point(60, 48);
            txtDescripcionRol.Margin = new Padding(2, 2, 2, 2);
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(210, 27);
            txtDescripcionRol.TabIndex = 1;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Firebrick;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.White;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 16;
            btneliminar.Location = new Point(60, 185);
            btneliminar.Margin = new Padding(3, 4, 3, 4);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(209, 30);
            btneliminar.TabIndex = 20;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.RoyalBlue;
            btnmodificar.Cursor = Cursors.Hand;
            btnmodificar.FlatAppearance.BorderColor = Color.Black;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.ForeColor = Color.White;
            btnmodificar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnmodificar.IconColor = Color.White;
            btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnmodificar.IconSize = 18;
            btnmodificar.Location = new Point(60, 146);
            btnmodificar.Margin = new Padding(3, 4, 3, 4);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(209, 30);
            btnmodificar.TabIndex = 19;
            btnmodificar.Text = "Modificar";
            btnmodificar.TextAlign = ContentAlignment.MiddleRight;
            btnmodificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.ForestGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Folder;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 16;
            btnguardar.Location = new Point(60, 108);
            btnguardar.Margin = new Padding(3, 4, 3, 4);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(209, 30);
            btnguardar.TabIndex = 18;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // dgvGrupos
            // 
            dgvGrupos.BackgroundColor = SystemColors.Control;
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(605, 18);
            dgvGrupos.Margin = new Padding(2, 2, 2, 2);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.RowHeadersWidth = 62;
            dgvGrupos.RowTemplate.Height = 33;
            dgvGrupos.Size = new Size(254, 326);
            dgvGrupos.TabIndex = 21;
            dgvGrupos.CellContentClick += dgvGrupos_CellClick;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Coral;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.White;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.Hand;
            btncancelar.IconColor = Color.White;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 16;
            btncancelar.Location = new Point(60, 223);
            btncancelar.Margin = new Padding(3, 4, 3, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(209, 30);
            btncancelar.TabIndex = 22;
            btncancelar.Text = "Cancelar Selección";
            btncancelar.TextAlign = ContentAlignment.MiddleRight;
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 23;
            label1.Text = "Nombre del grupo:";
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.Teal;
            btnregresar.Cursor = Cursors.Hand;
            btnregresar.FlatAppearance.BorderColor = Color.Black;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.ForeColor = Color.White;
            btnregresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnregresar.IconColor = Color.White;
            btnregresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregresar.IconSize = 16;
            btnregresar.Location = new Point(488, 357);
            btnregresar.Margin = new Padding(3, 4, 3, 4);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(209, 30);
            btnregresar.TabIndex = 24;
            btnregresar.Text = "Regresar";
            btnregresar.TextAlign = ContentAlignment.MiddleRight;
            btnregresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // btngruposusuarios
            // 
            btngruposusuarios.BackColor = Color.DarkKhaki;
            btngruposusuarios.Cursor = Cursors.Hand;
            btngruposusuarios.FlatAppearance.BorderColor = Color.Black;
            btngruposusuarios.FlatStyle = FlatStyle.Flat;
            btngruposusuarios.ForeColor = Color.Black;
            btngruposusuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btngruposusuarios.IconColor = Color.Black;
            btngruposusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btngruposusuarios.IconSize = 16;
            btngruposusuarios.Location = new Point(60, 304);
            btngruposusuarios.Margin = new Padding(3, 4, 3, 4);
            btngruposusuarios.Name = "btngruposusuarios";
            btngruposusuarios.Size = new Size(209, 30);
            btngruposusuarios.TabIndex = 29;
            btngruposusuarios.Text = "Usuarios Especiales";
            btngruposusuarios.TextAlign = ContentAlignment.MiddleRight;
            btngruposusuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btngruposusuarios.UseVisualStyleBackColor = false;
            btngruposusuarios.Click += btngruposusuarios_Click;
            // 
            // frmPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 398);
            Controls.Add(btngruposusuarios);
            Controls.Add(btnregresar);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(dgvGrupos);
            Controls.Add(btneliminar);
            Controls.Add(btnmodificar);
            Controls.Add(btnguardar);
            Controls.Add(txtDescripcionRol);
            Controls.Add(dgvPermisos);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmPermisos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPermisos";
            Load += frmPermisos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPermisos;
        private TextBox txtDescripcionRol;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnmodificar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private DataGridView dgvGrupos;
        private FontAwesome.Sharp.IconButton btncancelar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnregresar;
        private FontAwesome.Sharp.IconButton btngruposusuarios;
    }
}