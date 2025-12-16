namespace CapaPresentacion
{
    partial class frmVentas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txtidproducto = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtstock = new TextBox();
            txtprecio = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            txtcodproducto = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txtcantidad = new NumericUpDown();
            label7 = new Label();
            btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtidcliente = new TextBox();
            label5 = new Label();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            txttotalapagar = new TextBox();
            label12 = new Label();
            txtcambio = new TextBox();
            label2 = new Label();
            label13 = new Label();
            txtpagacon = new TextBox();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnAnularVenta = new FontAwesome.Sharp.IconButton();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(78, 12);
            label1.Name = "label1";
            label1.Padding = new Padding(2, 14, 0, 0);
            label1.Size = new Size(1112, 604);
            label1.TabIndex = 22;
            label1.Text = "Registrar Venta";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(141, 30);
            txtidproducto.Margin = new Padding(3, 4, 3, 4);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(36, 27);
            txtidproducto.TabIndex = 26;
            txtidproducto.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(763, 44);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 30;
            label11.Text = "Cantidad: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(643, 44);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 29;
            label10.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(531, 44);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 26;
            label9.Text = "Precio: ";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(643, 68);
            txtstock.Margin = new Padding(3, 4, 3, 4);
            txtstock.Name = "txtstock";
            txtstock.ReadOnly = true;
            txtstock.Size = new Size(105, 27);
            txtstock.TabIndex = 28;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(531, 68);
            txtprecio.Margin = new Padding(3, 4, 3, 4);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(105, 27);
            txtprecio.TabIndex = 26;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.White;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.ForeColor = Color.Black;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 16;
            btnbuscarproducto.Location = new Point(199, 68);
            btnbuscarproducto.Margin = new Padding(3, 4, 3, 4);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(50, 30);
            btnbuscarproducto.TabIndex = 27;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(256, 68);
            txtproducto.Margin = new Padding(3, 4, 3, 4);
            txtproducto.Name = "txtproducto";
            txtproducto.ReadOnly = true;
            txtproducto.Size = new Size(258, 27);
            txtproducto.TabIndex = 3;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(7, 68);
            txtcodproducto.Margin = new Padding(3, 4, 3, 4);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(185, 27);
            txtcodproducto.TabIndex = 2;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            txtcodproducto.KeyPress += textBoxNumeros_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 44);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 0;
            label8.Text = "Cod. Producto:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtstock);
            groupBox3.Controls.Add(txtprecio);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(97, 198);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(917, 128);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de producto";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(763, 68);
            txtcantidad.Margin = new Padding(3, 4, 3, 4);
            txtcantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(101, 27);
            txtcantidad.TabIndex = 31;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 44);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // btnbuscarcliente
            // 
            btnbuscarcliente.BackColor = Color.White;
            btnbuscarcliente.Cursor = Cursors.Hand;
            btnbuscarcliente.FlatAppearance.BorderColor = Color.Black;
            btnbuscarcliente.FlatStyle = FlatStyle.Flat;
            btnbuscarcliente.ForeColor = Color.Black;
            btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarcliente.IconColor = Color.Black;
            btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcliente.IconSize = 16;
            btnbuscarcliente.Location = new Point(258, 72);
            btnbuscarcliente.Margin = new Padding(3, 4, 3, 4);
            btnbuscarcliente.Name = "btnbuscarcliente";
            btnbuscarcliente.Size = new Size(50, 30);
            btnbuscarcliente.TabIndex = 26;
            btnbuscarcliente.UseVisualStyleBackColor = false;
            btnbuscarcliente.Click += btnbuscarproveedor_Click;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(327, 72);
            txtnombrecliente.Margin = new Padding(3, 4, 3, 4);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(266, 27);
            txtnombrecliente.TabIndex = 3;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(7, 74);
            txtdoccliente.Margin = new Padding(3, 4, 3, 4);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.ReadOnly = true;
            txtdoccliente.Size = new Size(229, 27);
            txtdoccliente.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 50);
            label6.Name = "label6";
            label6.Size = new Size(166, 20);
            label6.TabIndex = 0;
            label6.Text = "Número de Documento";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidcliente);
            groupBox2.Controls.Add(btnbuscarcliente);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(552, 62);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(600, 128);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de cliente";
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(557, 34);
            txtidcliente.Margin = new Padding(3, 4, 3, 4);
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(36, 27);
            txtidcliente.TabIndex = 25;
            txtidcliente.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 48);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre Completo:";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(216, 68);
            cbotipodocumento.Margin = new Padding(3, 4, 3, 4);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(225, 28);
            cbotipodocumento.TabIndex = 24;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(7, 68);
            txtfecha.Margin = new Padding(3, 4, 3, 4);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(185, 27);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 44);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(97, 62);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(448, 128);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de venta";
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.BackColor = SystemColors.Control;
            btnagregarproducto.Cursor = Cursors.Hand;
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnagregarproducto.IconColor = Color.ForestGreen;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarproducto.Location = new Point(1032, 198);
            btnagregarproducto.Margin = new Padding(3, 4, 3, 4);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(112, 93);
            btnagregarproducto.TabIndex = 29;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = false;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, Subtotal, btneliminar });
            dgvdata.Location = new Point(97, 342);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(917, 238);
            dgvdata.TabIndex = 30;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 8;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            IdProducto.Width = 150;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 8;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 150;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 8;
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 30;
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(1032, 348);
            txttotalapagar.Margin = new Padding(3, 4, 3, 4);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.ReadOnly = true;
            txttotalapagar.Size = new Size(114, 27);
            txttotalapagar.TabIndex = 33;
            txttotalapagar.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(1032, 324);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 32;
            label12.Text = "Total a Pagar:";
            // 
            // txtcambio
            // 
            txtcambio.Location = new Point(1032, 476);
            txtcambio.Margin = new Padding(3, 4, 3, 4);
            txtcambio.Name = "txtcambio";
            txtcambio.ReadOnly = true;
            txtcambio.Size = new Size(114, 27);
            txtcambio.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(1032, 452);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 34;
            label2.Text = "Cambio:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(1032, 387);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 36;
            label13.Text = "Paga con:";
            // 
            // txtpagacon
            // 
            txtpagacon.Location = new Point(1032, 411);
            txtpagacon.Margin = new Padding(3, 4, 3, 4);
            txtpagacon.Name = "txtpagacon";
            txtpagacon.Size = new Size(114, 27);
            txtpagacon.TabIndex = 37;
            txtpagacon.KeyDown += txtpagacon_KeyDown;
            txtpagacon.KeyPress += txtpagacon_KeyPress;
            // 
            // btnregistrar
            // 
            btnregistrar.Cursor = Cursors.Hand;
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = SystemColors.Highlight;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 27;
            btnregistrar.Location = new Point(1032, 522);
            btnregistrar.Margin = new Padding(3, 4, 3, 4);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(114, 58);
            btnregistrar.TabIndex = 38;
            btnregistrar.Text = "Crear Venta";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
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
            btnlimpiarbuscador.Location = new Point(1014, 20);
            btnlimpiarbuscador.Margin = new Padding(3, 4, 3, 4);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(138, 42);
            btnlimpiarbuscador.TabIndex = 66;
            btnlimpiarbuscador.Text = "Limpiar Venta";
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // btnAnularVenta
            // 
            btnAnularVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnularVenta.IconColor = Color.Black;
            btnAnularVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnularVenta.Location = new Point(323, 21);
            btnAnularVenta.Name = "btnAnularVenta";
            btnAnularVenta.Size = new Size(132, 41);
            btnAnularVenta.TabIndex = 67;
            btnAnularVenta.Text = "Anular Venta";
            btnAnularVenta.UseVisualStyleBackColor = true;
            btnAnularVenta.Click += btnAnularVenta_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 810);
            Controls.Add(btnAnularVenta);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnregistrar);
            Controls.Add(txtpagacon);
            Controls.Add(label13);
            Controls.Add(txtcambio);
            Controls.Add(label2);
            Controls.Add(txttotalapagar);
            Controls.Add(label12);
            Controls.Add(dgvdata);
            Controls.Add(btnagregarproducto);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtidproducto;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtstock;
        private TextBox txtprecio;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtproducto;
        private TextBox txtcodproducto;
        private Label label8;
        private GroupBox groupBox3;
        private NumericUpDown txtcantidad;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtidcliente;
        private Label label5;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn btneliminar;
        private TextBox txttotalapagar;
        private Label label12;
        private TextBox txtcambio;
        private Label label2;
        private Label label13;
        private TextBox txtpagacon;
        private FontAwesome.Sharp.IconButton btnregistrar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnAnularVenta;
    }
}