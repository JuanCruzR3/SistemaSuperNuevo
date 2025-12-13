namespace CapaPresentacion
{
    partial class frmCompras
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            btnSeleccionarOC = new FontAwesome.Sharp.IconButton();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txtcantidad = new NumericUpDown();
            txtidproducto = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
            txtproducto = new TextBox();
            txtcodproducto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            IdDetalleOrdenCompra = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            CantidadPendienteMax = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            txttotalapagar = new TextBox();
            label12 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtIndiceFila = new TextBox();
            txtidDetalleOrdenCompra = new TextBox();
            txtcantidadpendientemax = new TextBox();
            dgvpendientesOC = new DataGridView();
            IdDetalleOrdenCompraOC = new DataGridViewTextBoxColumn();
            IdProductoOC = new DataGridViewTextBoxColumn();
            ProductoOC = new DataGridViewTextBoxColumn();
            PrecioEstimadoOC = new DataGridViewTextBoxColumn();
            CantidadOrdenadaOC = new DataGridViewTextBoxColumn();
            CantidadRecibidaOC = new DataGridViewTextBoxColumn();
            CantidadPendienteOC = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvpendientesOC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Padding = new Padding(2, 0, 0, 0);
            label1.Size = new Size(1376, 630);
            label1.TabIndex = 21;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(40, 26);
            label2.Name = "label2";
            label2.Size = new Size(249, 32);
            label2.TabIndex = 22;
            label2.Text = "Registrar compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(45, 66);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(448, 128);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de compra";
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(btnSeleccionarOC);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(499, 66);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(600, 128);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(557, 34);
            txtidproveedor.Margin = new Padding(3, 4, 3, 4);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(36, 27);
            txtidproveedor.TabIndex = 25;
            txtidproveedor.Visible = false;
            // 
            // btnSeleccionarOC
            // 
            btnSeleccionarOC.BackColor = Color.White;
            btnSeleccionarOC.Cursor = Cursors.Hand;
            btnSeleccionarOC.FlatAppearance.BorderColor = Color.Black;
            btnSeleccionarOC.FlatStyle = FlatStyle.Flat;
            btnSeleccionarOC.ForeColor = Color.Black;
            btnSeleccionarOC.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSeleccionarOC.IconColor = Color.Black;
            btnSeleccionarOC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeleccionarOC.IconSize = 16;
            btnSeleccionarOC.Location = new Point(258, 72);
            btnSeleccionarOC.Margin = new Padding(3, 4, 3, 4);
            btnSeleccionarOC.Name = "btnSeleccionarOC";
            btnSeleccionarOC.Size = new Size(50, 30);
            btnSeleccionarOC.TabIndex = 26;
            btnSeleccionarOC.UseVisualStyleBackColor = false;
            btnSeleccionarOC.Click += btnSeleccionarOC_Click;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(327, 72);
            txtnombreproveedor.Margin = new Padding(3, 4, 3, 4);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.ReadOnly = true;
            txtnombreproveedor.Size = new Size(266, 27);
            txtnombreproveedor.TabIndex = 3;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(7, 74);
            txtdocproveedor.Margin = new Padding(3, 4, 3, 4);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.ReadOnly = true;
            txtdocproveedor.Size = new Size(229, 27);
            txtdocproveedor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 48);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 1;
            label5.Text = "Razón Social:";
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(txtpreciocompra);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(45, 202);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1054, 128);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de producto";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(892, 68);
            txtcantidad.Margin = new Padding(3, 4, 3, 4);
            txtcantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(101, 27);
            txtcantidad.TabIndex = 31;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(197, 12);
            txtidproducto.Margin = new Padding(3, 4, 3, 4);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(36, 27);
            txtidproducto.TabIndex = 26;
            txtidproducto.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(892, 44);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 30;
            label11.Text = "Cantidad: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(772, 44);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 29;
            label10.Text = "Precio Venta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(660, 44);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 26;
            label9.Text = "Precio Compra: ";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(772, 68);
            txtprecioventa.Margin = new Padding(3, 4, 3, 4);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(105, 27);
            txtprecioventa.TabIndex = 28;
            txtprecioventa.KeyPress += txtprecioventa_KeyPress;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(660, 68);
            txtpreciocompra.Margin = new Padding(3, 4, 3, 4);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(105, 27);
            txtpreciocompra.TabIndex = 26;
            txtpreciocompra.KeyPress += txtpreciocompra_KeyPress;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(216, 67);
            txtproducto.Margin = new Padding(3, 4, 3, 4);
            txtproducto.Name = "txtproducto";
            txtproducto.ReadOnly = true;
            txtproducto.Size = new Size(177, 27);
            txtproducto.TabIndex = 3;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(7, 67);
            txtcodproducto.Margin = new Padding(3, 4, 3, 4);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(185, 27);
            txtcodproducto.TabIndex = 2;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            txtcodproducto.KeyPress += textBoxNumeros_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(216, 43);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 43);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 0;
            label8.Text = "Cod. Producto:";
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.BackColor = SystemColors.Control;
            btnagregarproducto.Cursor = Cursors.Hand;
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnagregarproducto.IconColor = Color.ForestGreen;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarproducto.Location = new Point(1246, 246);
            btnagregarproducto.Margin = new Padding(3, 4, 3, 4);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(112, 86);
            btnagregarproducto.TabIndex = 27;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = false;
            btnagregarproducto.Click += btnagregarproducto_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdDetalleOrdenCompra, IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, Subtotal, CantidadPendienteMax, btneliminar });
            dgvdata.Location = new Point(590, 348);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(626, 265);
            dgvdata.TabIndex = 28;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // IdDetalleOrdenCompra
            // 
            IdDetalleOrdenCompra.HeaderText = "IdDetalleOrdenCompra";
            IdDetalleOrdenCompra.MinimumWidth = 6;
            IdDetalleOrdenCompra.Name = "IdDetalleOrdenCompra";
            IdDetalleOrdenCompra.ReadOnly = true;
            IdDetalleOrdenCompra.Visible = false;
            IdDetalleOrdenCompra.Width = 125;
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
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 8;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 180;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 8;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            PrecioVenta.Width = 150;
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
            // CantidadPendienteMax
            // 
            CantidadPendienteMax.HeaderText = "CantidadPendienteMax";
            CantidadPendienteMax.MinimumWidth = 6;
            CantidadPendienteMax.Name = "CantidadPendienteMax";
            CantidadPendienteMax.ReadOnly = true;
            CantidadPendienteMax.Visible = false;
            CantidadPendienteMax.Width = 125;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 8;
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 30;
            // 
            // btnregistrar
            // 
            btnregistrar.Cursor = Cursors.Hand;
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = SystemColors.Highlight;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 27;
            btnregistrar.Location = new Point(1241, 522);
            btnregistrar.Margin = new Padding(3, 4, 3, 4);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(120, 50);
            btnregistrar.TabIndex = 29;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(1246, 470);
            txttotalapagar.Margin = new Padding(3, 4, 3, 4);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.ReadOnly = true;
            txttotalapagar.Size = new Size(114, 27);
            txttotalapagar.TabIndex = 31;
            txttotalapagar.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(1246, 446);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 30;
            label12.Text = "Total a Pagar:";
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
            btnlimpiarbuscador.Location = new Point(1241, 370);
            btnlimpiarbuscador.Margin = new Padding(3, 4, 3, 4);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(138, 42);
            btnlimpiarbuscador.TabIndex = 67;
            btnlimpiarbuscador.Text = "Limpiar Compra";
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtIndiceFila
            // 
            txtIndiceFila.Location = new Point(441, 31);
            txtIndiceFila.Name = "txtIndiceFila";
            txtIndiceFila.Size = new Size(63, 27);
            txtIndiceFila.TabIndex = 32;
            // 
            // txtidDetalleOrdenCompra
            // 
            txtidDetalleOrdenCompra.Location = new Point(521, 31);
            txtidDetalleOrdenCompra.Name = "txtidDetalleOrdenCompra";
            txtidDetalleOrdenCompra.Size = new Size(63, 27);
            txtidDetalleOrdenCompra.TabIndex = 68;
            // 
            // txtcantidadpendientemax
            // 
            txtcantidadpendientemax.Location = new Point(590, 32);
            txtcantidadpendientemax.Name = "txtcantidadpendientemax";
            txtcantidadpendientemax.Size = new Size(63, 27);
            txtcantidadpendientemax.TabIndex = 69;
            // 
            // dgvpendientesOC
            // 
            dgvpendientesOC.BackgroundColor = Color.White;
            dgvpendientesOC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpendientesOC.Columns.AddRange(new DataGridViewColumn[] { IdDetalleOrdenCompraOC, IdProductoOC, ProductoOC, PrecioEstimadoOC, CantidadOrdenadaOC, CantidadRecibidaOC, CantidadPendienteOC });
            dgvpendientesOC.Location = new Point(30, 348);
            dgvpendientesOC.Name = "dgvpendientesOC";
            dgvpendientesOC.RowHeadersWidth = 51;
            dgvpendientesOC.RowTemplate.Height = 29;
            dgvpendientesOC.Size = new Size(554, 265);
            dgvpendientesOC.TabIndex = 70;
            // 
            // IdDetalleOrdenCompraOC
            // 
            IdDetalleOrdenCompraOC.HeaderText = "IdDetalleOrdenCompraOC";
            IdDetalleOrdenCompraOC.MinimumWidth = 6;
            IdDetalleOrdenCompraOC.Name = "IdDetalleOrdenCompraOC";
            IdDetalleOrdenCompraOC.Visible = false;
            IdDetalleOrdenCompraOC.Width = 125;
            // 
            // IdProductoOC
            // 
            IdProductoOC.HeaderText = "IdProductoOC";
            IdProductoOC.MinimumWidth = 6;
            IdProductoOC.Name = "IdProductoOC";
            IdProductoOC.Visible = false;
            IdProductoOC.Width = 125;
            // 
            // ProductoOC
            // 
            ProductoOC.HeaderText = "Producto";
            ProductoOC.MinimumWidth = 6;
            ProductoOC.Name = "ProductoOC";
            ProductoOC.Width = 125;
            // 
            // PrecioEstimadoOC
            // 
            PrecioEstimadoOC.HeaderText = "Precio Estimado";
            PrecioEstimadoOC.MinimumWidth = 6;
            PrecioEstimadoOC.Name = "PrecioEstimadoOC";
            PrecioEstimadoOC.Width = 125;
            // 
            // CantidadOrdenadaOC
            // 
            CantidadOrdenadaOC.HeaderText = "Ordenada";
            CantidadOrdenadaOC.MinimumWidth = 6;
            CantidadOrdenadaOC.Name = "CantidadOrdenadaOC";
            CantidadOrdenadaOC.Width = 125;
            // 
            // CantidadRecibidaOC
            // 
            CantidadRecibidaOC.HeaderText = "Recibida";
            CantidadRecibidaOC.MinimumWidth = 6;
            CantidadRecibidaOC.Name = "CantidadRecibidaOC";
            CantidadRecibidaOC.Width = 125;
            // 
            // CantidadPendienteOC
            // 
            CantidadPendienteOC.HeaderText = "Pendiente";
            CantidadPendienteOC.MinimumWidth = 6;
            CantidadPendienteOC.Name = "CantidadPendienteOC";
            CantidadPendienteOC.Width = 125;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 675);
            Controls.Add(dgvpendientesOC);
            Controls.Add(txtcantidadpendientemax);
            Controls.Add(txtidDetalleOrdenCompra);
            Controls.Add(txtIndiceFila);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txttotalapagar);
            Controls.Add(label12);
            Controls.Add(btnregistrar);
            Controls.Add(dgvdata);
            Controls.Add(btnagregarproducto);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCompras";
            Text = "frmCompras";
            Load += frmCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvpendientesOC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox txtfecha;
        private ComboBox cbotipodocumento;
        private GroupBox groupBox2;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnSeleccionarOC;
        private TextBox txtidproveedor;
        private GroupBox groupBox3;
        private TextBox txtcodproducto;
        private Label label7;
        private Label label8;
        private TextBox txtidproducto;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
        private TextBox txtproducto;
        private NumericUpDown txtcantidad;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnregistrar;
        private TextBox txttotalapagar;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtIndiceFila;
        private TextBox txtidDetalleOrdenCompra;
        private TextBox txtcantidadpendientemax;
        private DataGridView dgvpendientesOC;
        private DataGridViewTextBoxColumn IdDetalleOrdenCompra;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn CantidadPendienteMax;
        private DataGridViewButtonColumn btneliminar;
        private DataGridViewTextBoxColumn IdDetalleOrdenCompraOC;
        private DataGridViewTextBoxColumn IdProductoOC;
        private DataGridViewTextBoxColumn ProductoOC;
        private DataGridViewTextBoxColumn PrecioEstimadoOC;
        private DataGridViewTextBoxColumn CantidadOrdenadaOC;
        private DataGridViewTextBoxColumn CantidadRecibidaOC;
        private DataGridViewTextBoxColumn CantidadPendienteOC;
    }
}