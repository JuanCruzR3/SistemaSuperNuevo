namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtnumerodocumento = new TextBox();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtusuario = new TextBox();
            label7 = new Label();
            txtfecha = new TextBox();
            txttipodocumento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtmontopago = new TextBox();
            label13 = new Label();
            txtmontocambio = new TextBox();
            label2 = new Label();
            txtmontototal = new TextBox();
            label12 = new Label();
            label1 = new Label();
            btnexpotar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            txtbusqueda = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txtestado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Subtotal });
            dgvdata.Location = new Point(312, 340);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(720, 227);
            dgvdata.TabIndex = 41;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(312, 212);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(720, 120);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de cliente";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(639, 72);
            txtnumerodocumento.Margin = new Padding(3, 4, 3, 4);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(74, 27);
            txtnumerodocumento.TabIndex = 25;
            txtnumerodocumento.Visible = false;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(287, 74);
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
            txtdoccliente.Size = new Size(249, 27);
            txtdoccliente.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 50);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 50);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 0;
            label6.Text = "Número de Cliente:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(312, 86);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(720, 120);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de venta";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(458, 68);
            txtusuario.Margin = new Padding(3, 4, 3, 4);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(254, 27);
            txtusuario.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(458, 44);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 4;
            label7.Text = "Usuario:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(7, 68);
            txtfecha.Margin = new Padding(3, 4, 3, 4);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(195, 27);
            txtfecha.TabIndex = 3;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(209, 68);
            txttipodocumento.Margin = new Padding(3, 4, 3, 4);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(242, 27);
            txttipodocumento.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 44);
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
            // txtmontopago
            // 
            txtmontopago.Location = new Point(555, 582);
            txtmontopago.Margin = new Padding(3, 4, 3, 4);
            txtmontopago.Name = "txtmontopago";
            txtmontopago.ReadOnly = true;
            txtmontopago.Size = new Size(50, 27);
            txtmontopago.TabIndex = 47;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(462, 585);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 46;
            label13.Text = "Monto Pago:";
            // 
            // txtmontocambio
            // 
            txtmontocambio.Location = new Point(723, 581);
            txtmontocambio.Margin = new Padding(3, 4, 3, 4);
            txtmontocambio.Name = "txtmontocambio";
            txtmontocambio.ReadOnly = true;
            txtmontocambio.Size = new Size(50, 27);
            txtmontocambio.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(612, 585);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 44;
            label2.Text = "Monto Cambio:";
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(404, 577);
            txtmontototal.Margin = new Padding(3, 4, 3, 4);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(50, 27);
            txtmontototal.TabIndex = 43;
            txtmontototal.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(312, 581);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 42;
            label12.Text = "Monto Total: ";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(294, 16);
            label1.Name = "label1";
            label1.Padding = new Padding(2, 14, 0, 0);
            label1.Size = new Size(760, 638);
            label1.TabIndex = 38;
            label1.Text = "Detalle Venta";
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
            btnexpotar.Location = new Point(840, 575);
            btnexpotar.Margin = new Padding(3, 4, 3, 4);
            btnexpotar.Name = "btnexpotar";
            btnexpotar.Size = new Size(192, 40);
            btnexpotar.TabIndex = 72;
            btnexpotar.Text = "Descargar en PDF";
            btnexpotar.UseVisualStyleBackColor = false;
            btnexpotar.Click += btnexpotar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(510, 52);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 73;
            label8.Text = "Numero Documento:";
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(654, 47);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(157, 27);
            txtbusqueda.TabIndex = 74;
            txtbusqueda.KeyPress += textBoxNumeros_KeyPress;
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
            btnbuscar.Location = new Point(818, 46);
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
            btnlimpiarbuscador.Location = new Point(930, 47);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(319, 618);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 77;
            label9.Text = "Estado de la venta:";
            // 
            // txtestado
            // 
            txtestado.Location = new Point(468, 619);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(125, 27);
            txtestado.TabIndex = 78;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 840);
            Controls.Add(txtestado);
            Controls.Add(label9);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(label8);
            Controls.Add(btnexpotar);
            Controls.Add(dgvdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtmontopago);
            Controls.Add(label13);
            Controls.Add(txtmontocambio);
            Controls.Add(label2);
            Controls.Add(txtmontototal);
            Controls.Add(label12);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private GroupBox groupBox2;
        private TextBox txtnumerodocumento;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox cbotipodocumento;
        private TextBox txttipodocumento;
        private Label label4;
        private Label label3;
        private TextBox txtmontopago;
        private Label label13;
        private TextBox txtmontocambio;
        private Label label2;
        private TextBox txtmontototal;
        private Label label12;
        private Label label1;
        private TextBox txtusuario;
        private Label label7;
        private TextBox txtfecha;
        private FontAwesome.Sharp.IconButton btnexpotar;
        private Label label8;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private Label label9;
        private TextBox txtestado;
    }
}