namespace CapaPresentacion
{
    partial class frmReporteVentas
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
            btnbuscarpor = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label11 = new Label();
            btnexpotar = new FontAwesome.Sharp.IconButton();
            cbobuscarpor = new ComboBox();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtfechafin = new DateTimePicker();
            txtfechainicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            btnGraficoTopProductos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnbuscarpor
            // 
            btnbuscarpor.BackColor = Color.White;
            btnbuscarpor.Cursor = Cursors.Hand;
            btnbuscarpor.FlatAppearance.BorderColor = Color.Black;
            btnbuscarpor.FlatStyle = FlatStyle.Flat;
            btnbuscarpor.ForeColor = Color.Black;
            btnbuscarpor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarpor.IconColor = Color.Black;
            btnbuscarpor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarpor.IconSize = 16;
            btnbuscarpor.Location = new Point(1223, 132);
            btnbuscarpor.Margin = new Padding(3, 4, 3, 4);
            btnbuscarpor.Name = "btnbuscarpor";
            btnbuscarpor.Size = new Size(50, 30);
            btnbuscarpor.TabIndex = 102;
            btnbuscarpor.UseVisualStyleBackColor = false;
            btnbuscarpor.Click += btnbuscarpor_Click;
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
            btnlimpiarbuscador.Location = new Point(1280, 132);
            btnlimpiarbuscador.Margin = new Padding(3, 4, 3, 4);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 30);
            btnlimpiarbuscador.TabIndex = 103;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1009, 134);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(206, 27);
            txtbusqueda.TabIndex = 101;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(774, 140);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 99;
            label11.Text = "Buscar por:";
            // 
            // btnexpotar
            // 
            btnexpotar.BackColor = SystemColors.Control;
            btnexpotar.Cursor = Cursors.Hand;
            btnexpotar.FlatAppearance.BorderColor = Color.Black;
            btnexpotar.FlatStyle = FlatStyle.Flat;
            btnexpotar.ForeColor = Color.Black;
            btnexpotar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexpotar.IconColor = Color.LimeGreen;
            btnexpotar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexpotar.IconSize = 16;
            btnexpotar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpotar.Location = new Point(30, 132);
            btnexpotar.Margin = new Padding(3, 4, 3, 4);
            btnexpotar.Name = "btnexpotar";
            btnexpotar.Size = new Size(153, 36);
            btnexpotar.TabIndex = 98;
            btnexpotar.Text = "Descargar Excel";
            btnexpotar.UseVisualStyleBackColor = false;
            btnexpotar.Click += btnexpotar_Click;
            // 
            // cbobuscarpor
            // 
            cbobuscarpor.BackColor = SystemColors.Control;
            cbobuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscarpor.FormattingEnabled = true;
            cbobuscarpor.Location = new Point(856, 134);
            cbobuscarpor.Margin = new Padding(3, 4, 3, 4);
            cbobuscarpor.Name = "cbobuscarpor";
            cbobuscarpor.Size = new Size(146, 28);
            cbobuscarpor.TabIndex = 100;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoCliente, NombreCliente, CodigoProducto, NombreProducto, Categoria, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(30, 176);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1307, 422);
            dgvdata.TabIndex = 97;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 8;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 150;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 8;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.Width = 120;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 8;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            NumeroDocumento.Width = 150;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 8;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            MontoTotal.Width = 75;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.MinimumWidth = 8;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.ReadOnly = true;
            UsuarioRegistro.Width = 150;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Documento Cliente";
            DocumentoCliente.MinimumWidth = 8;
            DocumentoCliente.Name = "DocumentoCliente";
            DocumentoCliente.ReadOnly = true;
            DocumentoCliente.Width = 150;
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.MinimumWidth = 8;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            NombreCliente.Width = 150;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.MinimumWidth = 8;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 150;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 8;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 150;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 8;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 90;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 8;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 75;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Subtotal";
            SubTotal.MinimumWidth = 8;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 85;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(14, 124);
            label4.Name = "label4";
            label4.Padding = new Padding(2, 0, 0, 0);
            label4.Size = new Size(1344, 596);
            label4.TabIndex = 96;
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(334, 58);
            txtfechafin.Margin = new Padding(3, 4, 3, 4);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(113, 27);
            txtfechafin.TabIndex = 90;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(120, 58);
            txtfechainicio.Margin = new Padding(3, 4, 3, 4);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(113, 27);
            txtfechainicio.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(258, 66);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 92;
            label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(30, 66);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 91;
            label1.Text = "Fecha Inicio:";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(14, 12);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(1344, 92);
            label10.TabIndex = 89;
            label10.Text = "Reporte Ventas";
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.BackColor = Color.White;
            btnbuscarproveedor.Cursor = Cursors.Hand;
            btnbuscarproveedor.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproveedor.FlatStyle = FlatStyle.Flat;
            btnbuscarproveedor.ForeColor = Color.Black;
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 16;
            btnbuscarproveedor.Location = new Point(491, 58);
            btnbuscarproveedor.Margin = new Padding(3, 4, 3, 4);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(102, 30);
            btnbuscarproveedor.TabIndex = 104;
            btnbuscarproveedor.Text = "Buscar";
            btnbuscarproveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproveedor.UseVisualStyleBackColor = false;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click_1;
            // 
            // btnGraficoTopProductos
            // 
            btnGraficoTopProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGraficoTopProductos.IconColor = Color.Black;
            btnGraficoTopProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGraficoTopProductos.Location = new Point(856, 23);
            btnGraficoTopProductos.Name = "btnGraficoTopProductos";
            btnGraficoTopProductos.Size = new Size(135, 62);
            btnGraficoTopProductos.TabIndex = 105;
            btnGraficoTopProductos.Text = "Generar Gráfica";
            btnGraficoTopProductos.UseVisualStyleBackColor = true;
            btnGraficoTopProductos.Click += btnGraficoTopProductos_Click;
            // 
            // frmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 754);
            Controls.Add(btnGraficoTopProductos);
            Controls.Add(btnbuscarproveedor);
            Controls.Add(btnbuscarpor);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(label11);
            Controls.Add(btnexpotar);
            Controls.Add(cbobuscarpor);
            Controls.Add(dgvdata);
            Controls.Add(label4);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReporteVentas";
            Text = "frmReporteVentas";
            Load += frmReporteVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscarpor;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnexpotar;
        private ComboBox cbobuscarpor;
        private DataGridView dgvdata;
        private Label label4;
        private DateTimePicker txtfechafin;
        private DateTimePicker txtfechainicio;
        private Label label2;
        private Label label1;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnGraficoTopProductos;
    }
}