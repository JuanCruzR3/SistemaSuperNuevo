namespace CapaPresentacion
{
    partial class frmDetalleOrdenCompra
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnexpotar = new FontAwesome.Sharp.IconButton();
            txtmontototal = new TextBox();
            label12 = new Label();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioEstimado = new DataGridViewTextBoxColumn();
            CantidadOrdenada = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            CantidadRecibida = new DataGridViewTextBoxColumn();
            Pendiente = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtnumerodocumento = new TextBox();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtestado = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtfecha = new TextBox();
            txttipodocumento = new TextBox();
            txtusuario = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnexpotar
            // 
            btnexpotar.BackColor = SystemColors.Control;
            btnexpotar.Cursor = Cursors.Hand;
            btnexpotar.FlatAppearance.BorderColor = Color.Black;
            btnexpotar.FlatStyle = FlatStyle.Flat;
            btnexpotar.ForeColor = Color.Black;
            btnexpotar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnexpotar.IconColor = SystemColors.ControlDarkDark;
            btnexpotar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexpotar.IconSize = 16;
            btnexpotar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpotar.Location = new Point(805, 560);
            btnexpotar.Margin = new Padding(3, 4, 3, 4);
            btnexpotar.Name = "btnexpotar";
            btnexpotar.Size = new Size(197, 38);
            btnexpotar.TabIndex = 82;
            btnexpotar.Text = "Descargar en PDF";
            btnexpotar.UseVisualStyleBackColor = false;
            btnexpotar.Click += btnexportarpdf_Click;
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(302, 566);
            txtmontototal.Margin = new Padding(3, 4, 3, 4);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(114, 27);
            txtmontototal.TabIndex = 81;
            txtmontototal.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(210, 570);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 80;
            label12.Text = "Monto Total:";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioEstimado, CantidadOrdenada, Subtotal, CantidadRecibida, Pendiente });
            dgvdata.Location = new Point(135, 326);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(935, 226);
            dgvdata.TabIndex = 79;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 8;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // PrecioEstimado
            // 
            PrecioEstimado.HeaderText = "Precio Estimado";
            PrecioEstimado.MinimumWidth = 6;
            PrecioEstimado.Name = "PrecioEstimado";
            PrecioEstimado.ReadOnly = true;
            PrecioEstimado.Width = 125;
            // 
            // CantidadOrdenada
            // 
            CantidadOrdenada.HeaderText = "Cantidad Ordenada";
            CantidadOrdenada.MinimumWidth = 8;
            CantidadOrdenada.Name = "CantidadOrdenada";
            CantidadOrdenada.ReadOnly = true;
            CantidadOrdenada.Width = 180;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 150;
            // 
            // CantidadRecibida
            // 
            CantidadRecibida.HeaderText = "Cantidad Recibida";
            CantidadRecibida.MinimumWidth = 8;
            CantidadRecibida.Name = "CantidadRecibida";
            CantidadRecibida.ReadOnly = true;
            CantidadRecibida.Width = 150;
            // 
            // Pendiente
            // 
            Pendiente.HeaderText = "Pendiente";
            Pendiente.MinimumWidth = 6;
            Pendiente.Name = "Pendiente";
            Pendiente.ReadOnly = true;
            Pendiente.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(215, 185);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(775, 118);
            groupBox2.TabIndex = 78;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de proveedor";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(690, 54);
            txtnumerodocumento.Margin = new Padding(3, 4, 3, 4);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(70, 27);
            txtnumerodocumento.TabIndex = 25;
            txtnumerodocumento.Visible = false;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(262, 54);
            txtnombreproveedor.Margin = new Padding(3, 4, 3, 4);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.ReadOnly = true;
            txtnombreproveedor.Size = new Size(266, 27);
            txtnombreproveedor.TabIndex = 3;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(7, 54);
            txtdocproveedor.Margin = new Padding(3, 4, 3, 4);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.ReadOnly = true;
            txtdocproveedor.Size = new Size(236, 27);
            txtdocproveedor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 31);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 1;
            label5.Text = "Razón Social:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 31);
            label6.Name = "label6";
            label6.Size = new Size(166, 20);
            label6.TabIndex = 0;
            label6.Text = "Número de Documento";
            // 
            // txtestado
            // 
            txtestado.Location = new Point(576, 566);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(113, 27);
            txtestado.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 25;
            label1.Text = "Usuario:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(7, 48);
            txtfecha.Margin = new Padding(3, 4, 3, 4);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(185, 27);
            txtfecha.TabIndex = 2;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(216, 48);
            txttipodocumento.Margin = new Padding(3, 4, 3, 4);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(258, 27);
            txttipodocumento.TabIndex = 27;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(511, 48);
            txtusuario.Margin = new Padding(3, 4, 3, 4);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(223, 27);
            txtusuario.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(215, 65);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(775, 112);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 25);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
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
            btnbuscar.Location = new Point(780, 27);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(102, 30);
            btnbuscar.TabIndex = 75;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnlimpiarbuscador.Location = new Point(888, 27);
            btnlimpiarbuscador.Margin = new Padding(3, 4, 3, 4);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(102, 30);
            btnlimpiarbuscador.TabIndex = 76;
            btnlimpiarbuscador.Text = "Limpiar";
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(566, 27);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(206, 27);
            txtbusqueda.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(453, 37);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 73;
            label11.Text = "Nro Documento";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(115, 9);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(975, 628);
            label10.TabIndex = 72;
            label10.Text = "Detalle Orden Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(440, 570);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 83;
            label2.Text = "Estado del pedido:";
            // 
            // frmDetalleOrdenCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 662);
            Controls.Add(label2);
            Controls.Add(txtestado);
            Controls.Add(btnexpotar);
            Controls.Add(txtmontototal);
            Controls.Add(label12);
            Controls.Add(dgvdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(label11);
            Controls.Add(label10);
            Name = "frmDetalleOrdenCompra";
            Text = "frmDetalleOrdenCompra";
            Load += frmDetalleOrdenCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnexpotar;
        private TextBox txtmontototal;
        private Label label12;
        private DataGridView dgvdata;
        private GroupBox groupBox2;
        private TextBox txtnumerodocumento;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label1;
        private TextBox txtfecha;
        private TextBox txttipodocumento;
        private TextBox txtusuario;
        private GroupBox groupBox1;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private Label label11;
        private Label label10;
        private TextBox txtestado;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioEstimado;
        private DataGridViewTextBoxColumn CantidadOrdenada;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn CantidadRecibida;
        private DataGridViewTextBoxColumn Pendiente;
        private Label label2;
    }
}