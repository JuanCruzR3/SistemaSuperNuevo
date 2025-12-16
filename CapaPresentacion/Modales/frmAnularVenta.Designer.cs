namespace CapaPresentacion.Modales
{
    partial class frmAnularVenta
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
            dgvdata = new DataGridView();
            btnanular = new FontAwesome.Sharp.IconButton();
            btncerrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobuscarpor = new ComboBox();
            label11 = new Label();
            IdVenta = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = SystemColors.Control;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdVenta, FechaRegistro, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoTotal, Estado });
            dgvdata.Location = new Point(12, 50);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(823, 390);
            dgvdata.TabIndex = 0;
            // 
            // btnanular
            // 
            btnanular.IconChar = FontAwesome.Sharp.IconChar.None;
            btnanular.IconColor = Color.Black;
            btnanular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnanular.Location = new Point(841, 116);
            btnanular.Name = "btnanular";
            btnanular.Size = new Size(113, 51);
            btnanular.TabIndex = 1;
            btnanular.Text = "Anular";
            btnanular.UseVisualStyleBackColor = true;
            btnanular.Click += btnanular_Click;
            // 
            // btncerrar
            // 
            btncerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btncerrar.IconColor = Color.Black;
            btncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncerrar.Location = new Point(841, 257);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(113, 51);
            btncerrar.TabIndex = 2;
            btncerrar.Text = "Cerrar";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncancelar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 16;
            btnbuscar.Location = new Point(488, 12);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(50, 31);
            btnbuscar.TabIndex = 63;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.Black;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 18;
            btnlimpiarbuscador.Location = new Point(546, 12);
            btnlimpiarbuscador.Margin = new Padding(3, 4, 3, 4);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 31);
            btnlimpiarbuscador.TabIndex = 64;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(275, 13);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(206, 27);
            txtbusqueda.TabIndex = 62;
            // 
            // cbobuscarpor
            // 
            cbobuscarpor.BackColor = SystemColors.Control;
            cbobuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscarpor.FormattingEnabled = true;
            cbobuscarpor.Location = new Point(122, 13);
            cbobuscarpor.Margin = new Padding(3, 4, 3, 4);
            cbobuscarpor.Name = "cbobuscarpor";
            cbobuscarpor.Size = new Size(146, 28);
            cbobuscarpor.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Location = new Point(39, 20);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 60;
            label11.Text = "Buscar por:";
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "IdVenta";
            IdVenta.MinimumWidth = 6;
            IdVenta.Name = "IdVenta";
            IdVenta.Visible = false;
            IdVenta.Width = 125;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Doc.";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Num Doc";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Doc Cliente";
            DocumentoCliente.MinimumWidth = 6;
            DocumentoCliente.Name = "DocumentoCliente";
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.MinimumWidth = 6;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // frmAnularVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 515);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobuscarpor);
            Controls.Add(label11);
            Controls.Add(btncerrar);
            Controls.Add(btnanular);
            Controls.Add(dgvdata);
            Name = "frmAnularVenta";
            Text = "frmAnularVenta";
            Load += frmAnularVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnanular;
        private FontAwesome.Sharp.IconButton btncerrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbobuscarpor;
        private Label label11;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn Estado;
    }
}