namespace CapaPresentacion
{
    partial class frmOrdenCompra
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
            txtCantidadOrdenada = new TextBox();
            txtPrecioEstimado = new TextBox();
            dgvDetalleOC = new DataGridView();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            btnRegistrarOrden = new FontAwesome.Sharp.IconButton();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            txtidproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            txtnombreproveedor = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtidproducto = new TextBox();
            txtcodproducto = new TextBox();
            txtproducto = new TextBox();
            txtTotalEstimado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumeroDocumento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleOC).BeginInit();
            SuspendLayout();
            // 
            // txtCantidadOrdenada
            // 
            txtCantidadOrdenada.Location = new Point(161, 150);
            txtCantidadOrdenada.Name = "txtCantidadOrdenada";
            txtCantidadOrdenada.Size = new Size(94, 27);
            txtCantidadOrdenada.TabIndex = 1;
            // 
            // txtPrecioEstimado
            // 
            txtPrecioEstimado.Location = new Point(514, 112);
            txtPrecioEstimado.Name = "txtPrecioEstimado";
            txtPrecioEstimado.Size = new Size(125, 27);
            txtPrecioEstimado.TabIndex = 3;
            // 
            // dgvDetalleOC
            // 
            dgvDetalleOC.BackgroundColor = SystemColors.Control;
            dgvDetalleOC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleOC.Location = new Point(12, 233);
            dgvDetalleOC.Name = "dgvDetalleOC";
            dgvDetalleOC.RowHeadersWidth = 51;
            dgvDetalleOC.RowTemplate.Height = 29;
            dgvDetalleOC.Size = new Size(869, 269);
            dgvDetalleOC.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarProducto.IconColor = Color.LightGreen;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.Location = new Point(502, 157);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(137, 70);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click_1;
            // 
            // btnRegistrarOrden
            // 
            btnRegistrarOrden.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrarOrden.IconColor = Color.Black;
            btnRegistrarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarOrden.Location = new Point(887, 431);
            btnRegistrarOrden.Name = "btnRegistrarOrden";
            btnRegistrarOrden.Size = new Size(179, 46);
            btnRegistrarOrden.TabIndex = 6;
            btnRegistrarOrden.Text = "Registrar  Orden";
            btnRegistrarOrden.UseVisualStyleBackColor = true;
            btnRegistrarOrden.Click += btnRegistrarOrden_Click;
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
            btnbuscarproveedor.Location = new Point(182, 35);
            btnbuscarproveedor.Margin = new Padding(3, 4, 3, 4);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(50, 30);
            btnbuscarproveedor.TabIndex = 69;
            btnbuscarproveedor.UseVisualStyleBackColor = false;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(104, 2);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(51, 27);
            txtidproveedor.TabIndex = 70;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(21, 35);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(155, 27);
            txtdocproveedor.TabIndex = 71;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(247, 35);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(224, 27);
            txtnombreproveedor.TabIndex = 72;
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
            btnbuscarproducto.Location = new Point(182, 109);
            btnbuscarproducto.Margin = new Padding(3, 4, 3, 4);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(50, 30);
            btnbuscarproducto.TabIndex = 73;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(104, 76);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(51, 27);
            txtidproducto.TabIndex = 74;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(21, 109);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(155, 27);
            txtcodproducto.TabIndex = 75;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(247, 112);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(224, 27);
            txtproducto.TabIndex = 76;
            // 
            // txtTotalEstimado
            // 
            txtTotalEstimado.Location = new Point(668, 112);
            txtTotalEstimado.Name = "txtTotalEstimado";
            txtTotalEstimado.Size = new Size(125, 27);
            txtTotalEstimado.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 153);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 78;
            label1.Text = "Cantidad a ordenar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 5);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 79;
            label2.Text = "Proveedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 80;
            label3.Text = "Producto";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(815, 28);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(172, 27);
            txtNumeroDocumento.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 35);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 81;
            label4.Text = "Número de orden:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 79);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 82;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(668, 83);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 83;
            label6.Text = "Total estimado: ";
            // 
            // frmOrdenCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 514);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotalEstimado);
            Controls.Add(txtproducto);
            Controls.Add(txtcodproducto);
            Controls.Add(txtidproducto);
            Controls.Add(btnbuscarproducto);
            Controls.Add(txtnombreproveedor);
            Controls.Add(txtdocproveedor);
            Controls.Add(txtidproveedor);
            Controls.Add(btnbuscarproveedor);
            Controls.Add(btnRegistrarOrden);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvDetalleOC);
            Controls.Add(txtPrecioEstimado);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(txtCantidadOrdenada);
            Name = "frmOrdenCompra";
            Text = "frmOrdenCompra";
            Load += frmOrdenCompra_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleOC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCantidadOrdenada;
        private TextBox txtPrecioEstimado;
        private DataGridView dgvDetalleOC;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton btnRegistrarOrden;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private TextBox txtidproveedor;
        private TextBox txtdocproveedor;
        private TextBox txtnombreproveedor;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtidproducto;
        private TextBox txtcodproducto;
        private TextBox txtproducto;
        private TextBox txtTotalEstimado;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumeroDocumento;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}