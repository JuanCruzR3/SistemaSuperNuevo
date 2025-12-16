namespace CapaPresentacion
{
    partial class frmReporteOrdenCompra
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
            btnexpotarexcel = new FontAwesome.Sharp.IconButton();
            cbobuscarpor = new ComboBox();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            MontoTotalEstimado = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioEstimado = new DataGridViewTextBoxColumn();
            CantidadOrdenada = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            cboproveedor = new ComboBox();
            txtfechafin = new DateTimePicker();
            txtfechainicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            btnGenerarGrafico = new FontAwesome.Sharp.IconButton();
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
            btnbuscarpor.Location = new Point(1246, 129);
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
            btnlimpiarbuscador.Location = new Point(1303, 129);
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
            txtbusqueda.Location = new Point(1032, 131);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(206, 27);
            txtbusqueda.TabIndex = 101;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(797, 137);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 99;
            label11.Text = "Buscar por:";
            // 
            // btnexpotarexcel
            // 
            btnexpotarexcel.BackColor = SystemColors.Control;
            btnexpotarexcel.Cursor = Cursors.Hand;
            btnexpotarexcel.FlatAppearance.BorderColor = Color.Black;
            btnexpotarexcel.FlatStyle = FlatStyle.Flat;
            btnexpotarexcel.ForeColor = Color.Black;
            btnexpotarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexpotarexcel.IconColor = Color.LimeGreen;
            btnexpotarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexpotarexcel.IconSize = 16;
            btnexpotarexcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpotarexcel.Location = new Point(53, 129);
            btnexpotarexcel.Margin = new Padding(3, 4, 3, 4);
            btnexpotarexcel.Name = "btnexpotarexcel";
            btnexpotarexcel.Size = new Size(153, 36);
            btnexpotarexcel.TabIndex = 98;
            btnexpotarexcel.Text = "Descargar Excel";
            btnexpotarexcel.UseVisualStyleBackColor = false;
            btnexpotarexcel.Click += btnexportar_Click;
            // 
            // cbobuscarpor
            // 
            cbobuscarpor.BackColor = SystemColors.Control;
            cbobuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscarpor.FormattingEnabled = true;
            cbobuscarpor.Location = new Point(879, 131);
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, NumeroDocumento, Estado, MontoTotalEstimado, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioEstimado, CantidadOrdenada, Subtotal });
            dgvdata.Location = new Point(53, 173);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1305, 437);
            dgvdata.TabIndex = 97;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 8;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Num Documento";
            NumeroDocumento.MinimumWidth = 8;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            NumeroDocumento.Width = 120;
            // 
            // Estado
            // 
            Estado.FillWeight = 80F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 90;
            // 
            // MontoTotalEstimado
            // 
            MontoTotalEstimado.HeaderText = "Monto Estimado";
            MontoTotalEstimado.MinimumWidth = 8;
            MontoTotalEstimado.Name = "MontoTotalEstimado";
            MontoTotalEstimado.ReadOnly = true;
            MontoTotalEstimado.Width = 75;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.MinimumWidth = 8;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.ReadOnly = true;
            UsuarioRegistro.Width = 90;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Doc Proveedor ";
            DocumentoProveedor.MinimumWidth = 8;
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            DocumentoProveedor.Width = 125;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 8;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 125;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Cod Producto";
            CodigoProducto.MinimumWidth = 8;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 150;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 125;
            // 
            // PrecioEstimado
            // 
            PrecioEstimado.HeaderText = "Precio Estimado";
            PrecioEstimado.MinimumWidth = 6;
            PrecioEstimado.Name = "PrecioEstimado";
            PrecioEstimado.ReadOnly = true;
            PrecioEstimado.Width = 90;
            // 
            // CantidadOrdenada
            // 
            CantidadOrdenada.HeaderText = "Cantidad Ordenada";
            CantidadOrdenada.MinimumWidth = 6;
            CantidadOrdenada.Name = "CantidadOrdenada";
            CantidadOrdenada.ReadOnly = true;
            CantidadOrdenada.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 125;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(37, 121);
            label4.Name = "label4";
            label4.Padding = new Padding(2, 0, 0, 0);
            label4.Size = new Size(1372, 596);
            label4.TabIndex = 96;
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
            btnbuscarproveedor.Location = new Point(769, 53);
            btnbuscarproveedor.Margin = new Padding(3, 4, 3, 4);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(102, 30);
            btnbuscarproveedor.TabIndex = 95;
            btnbuscarproveedor.Text = "Buscar";
            btnbuscarproveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproveedor.UseVisualStyleBackColor = false;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(495, 63);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 94;
            label3.Text = "Proveedor:";
            // 
            // cboproveedor
            // 
            cboproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboproveedor.FormattingEnabled = true;
            cboproveedor.Location = new Point(575, 55);
            cboproveedor.Margin = new Padding(3, 4, 3, 4);
            cboproveedor.Name = "cboproveedor";
            cboproveedor.Size = new Size(187, 28);
            cboproveedor.TabIndex = 93;
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(357, 55);
            txtfechafin.Margin = new Padding(3, 4, 3, 4);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(113, 27);
            txtfechafin.TabIndex = 90;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(143, 55);
            txtfechainicio.Margin = new Padding(3, 4, 3, 4);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(113, 27);
            txtfechainicio.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(281, 63);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 92;
            label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(53, 63);
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
            label10.Location = new Point(37, 9);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(1439, 92);
            label10.TabIndex = 89;
            label10.Text = "Reporte Orden Compras";
            // 
            // btnGenerarGrafico
            // 
            btnGenerarGrafico.BackColor = Color.Cyan;
            btnGenerarGrafico.ForeColor = Color.Black;
            btnGenerarGrafico.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            btnGenerarGrafico.IconColor = Color.Black;
            btnGenerarGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarGrafico.Location = new Point(1020, 29);
            btnGenerarGrafico.Name = "btnGenerarGrafico";
            btnGenerarGrafico.Size = new Size(180, 54);
            btnGenerarGrafico.TabIndex = 104;
            btnGenerarGrafico.Text = "Ver Estados de Ordenes";
            btnGenerarGrafico.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGenerarGrafico.UseVisualStyleBackColor = false;
            btnGenerarGrafico.Click += btnGenerarGrafico_Click;
            // 
            // frmReporteOrdenCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 733);
            Controls.Add(btnGenerarGrafico);
            Controls.Add(btnbuscarpor);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(label11);
            Controls.Add(btnexpotarexcel);
            Controls.Add(cbobuscarpor);
            Controls.Add(dgvdata);
            Controls.Add(label4);
            Controls.Add(btnbuscarproveedor);
            Controls.Add(label3);
            Controls.Add(cboproveedor);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmReporteOrdenCompra";
            Text = "frmReporteOrdenCompra";
            Load += frmReporteOrdenCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscarpor;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnexpotarexcel;
        private ComboBox cbobuscarpor;
        private DataGridView dgvdata;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private Label label3;
        private ComboBox cboproveedor;
        private DateTimePicker txtfechafin;
        private DateTimePicker txtfechainicio;
        private Label label2;
        private Label label1;
        private Label label10;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn MontoTotalEstimado;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioEstimado;
        private DataGridViewTextBoxColumn CantidadOrdenada;
        private DataGridViewTextBoxColumn Subtotal;
        private FontAwesome.Sharp.IconButton btnGenerarGrafico;
    }
}