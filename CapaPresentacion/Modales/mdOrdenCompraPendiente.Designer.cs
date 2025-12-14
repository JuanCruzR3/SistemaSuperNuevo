namespace CapaPresentacion.Modales
{
    partial class mdOrdenCompraPendiente
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
            NumeroDocumento = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            ProveedorRazonSocial = new DataGridViewTextBoxColumn();
            MontoTotalEstimado = new DataGridViewTextBoxColumn();
            IdOrdenCompra = new DataGridViewTextBoxColumn();
            IdProveedor = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            dgvdetalles = new DataGridView();
            CodigoProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            CantidadOrdenada = new DataGridViewTextBoxColumn();
            CantidadRecibida = new DataGridViewTextBoxColumn();
            CantidadPendiente = new DataGridViewTextBoxColumn();
            PrecioEstimado = new DataGridViewTextBoxColumn();
            SubtotalEstimado = new DataGridViewTextBoxColumn();
            IdDetalleOrdenCompra = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btnAnularOC = new FontAwesome.Sharp.IconButton();
            btnEditarOC = new FontAwesome.Sharp.IconButton();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = SystemColors.Control;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { NumeroDocumento, FechaRegistro, ProveedorRazonSocial, MontoTotalEstimado, IdOrdenCompra, IdProveedor, DocumentoProveedor });
            dgvdata.Location = new Point(12, 67);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(924, 265);
            dgvdata.TabIndex = 0;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Nro. Orden";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // ProveedorRazonSocial
            // 
            ProveedorRazonSocial.HeaderText = "Proveedor";
            ProveedorRazonSocial.MinimumWidth = 6;
            ProveedorRazonSocial.Name = "ProveedorRazonSocial";
            ProveedorRazonSocial.Width = 125;
            // 
            // MontoTotalEstimado
            // 
            MontoTotalEstimado.HeaderText = "Total Estimado";
            MontoTotalEstimado.MinimumWidth = 6;
            MontoTotalEstimado.Name = "MontoTotalEstimado";
            MontoTotalEstimado.Width = 125;
            // 
            // IdOrdenCompra
            // 
            IdOrdenCompra.HeaderText = "IdOrdenCompra";
            IdOrdenCompra.MinimumWidth = 6;
            IdOrdenCompra.Name = "IdOrdenCompra";
            IdOrdenCompra.Visible = false;
            IdOrdenCompra.Width = 125;
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "IdProveedor";
            IdProveedor.MinimumWidth = 6;
            IdProveedor.Name = "IdProveedor";
            IdProveedor.Visible = false;
            IdProveedor.Width = 125;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "DocumentoProveedor";
            DocumentoProveedor.MinimumWidth = 6;
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.Visible = false;
            DocumentoProveedor.Width = 125;
            // 
            // dgvdetalles
            // 
            dgvdetalles.AllowUserToAddRows = false;
            dgvdetalles.AllowUserToDeleteRows = false;
            dgvdetalles.BackgroundColor = SystemColors.Control;
            dgvdetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdetalles.Columns.AddRange(new DataGridViewColumn[] { CodigoProducto, Producto, CantidadOrdenada, CantidadRecibida, CantidadPendiente, PrecioEstimado, SubtotalEstimado, IdDetalleOrdenCompra, IdProducto });
            dgvdetalles.Location = new Point(12, 358);
            dgvdetalles.Name = "dgvdetalles";
            dgvdetalles.ReadOnly = true;
            dgvdetalles.RowHeadersWidth = 51;
            dgvdetalles.RowTemplate.Height = 29;
            dgvdetalles.Size = new Size(924, 282);
            dgvdetalles.TabIndex = 1;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Código";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // CantidadOrdenada
            // 
            CantidadOrdenada.HeaderText = "Cant. Ordenada";
            CantidadOrdenada.MinimumWidth = 6;
            CantidadOrdenada.Name = "CantidadOrdenada";
            CantidadOrdenada.ReadOnly = true;
            CantidadOrdenada.Width = 125;
            // 
            // CantidadRecibida
            // 
            CantidadRecibida.HeaderText = "Cant. Recibida";
            CantidadRecibida.MinimumWidth = 6;
            CantidadRecibida.Name = "CantidadRecibida";
            CantidadRecibida.ReadOnly = true;
            CantidadRecibida.Width = 125;
            // 
            // CantidadPendiente
            // 
            CantidadPendiente.HeaderText = "Cant. Pendiente";
            CantidadPendiente.MinimumWidth = 6;
            CantidadPendiente.Name = "CantidadPendiente";
            CantidadPendiente.ReadOnly = true;
            CantidadPendiente.Width = 125;
            // 
            // PrecioEstimado
            // 
            PrecioEstimado.HeaderText = "Precio";
            PrecioEstimado.MinimumWidth = 6;
            PrecioEstimado.Name = "PrecioEstimado";
            PrecioEstimado.ReadOnly = true;
            PrecioEstimado.Width = 125;
            // 
            // SubtotalEstimado
            // 
            SubtotalEstimado.HeaderText = "Subtotal";
            SubtotalEstimado.MinimumWidth = 6;
            SubtotalEstimado.Name = "SubtotalEstimado";
            SubtotalEstimado.ReadOnly = true;
            SubtotalEstimado.Width = 125;
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
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 2;
            label1.Text = "Ordenes de Compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 335);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Productos: ";
            // 
            // btnAnularOC
            // 
            btnAnularOC.ForeColor = Color.Red;
            btnAnularOC.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            btnAnularOC.IconColor = Color.Red;
            btnAnularOC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnularOC.Location = new Point(963, 194);
            btnAnularOC.Name = "btnAnularOC";
            btnAnularOC.Size = new Size(113, 58);
            btnAnularOC.TabIndex = 4;
            btnAnularOC.Text = "Anular Orden";
            btnAnularOC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnularOC.UseVisualStyleBackColor = true;
            btnAnularOC.Click += btnAnularOC_Click;
            // 
            // btnEditarOC
            // 
            btnEditarOC.ForeColor = Color.Blue;
            btnEditarOC.IconChar = FontAwesome.Sharp.IconChar.Brush;
            btnEditarOC.IconColor = Color.Blue;
            btnEditarOC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarOC.Location = new Point(963, 274);
            btnEditarOC.Name = "btnEditarOC";
            btnEditarOC.Size = new Size(113, 58);
            btnEditarOC.TabIndex = 5;
            btnEditarOC.Text = "Editar";
            btnEditarOC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarOC.UseVisualStyleBackColor = true;
            btnEditarOC.Click += btnEditarOC_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.DarkSlateGray;
            btnRegresar.ForeColor = Color.White;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnRegresar.IconColor = Color.White;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.Location = new Point(942, 15);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(134, 50);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
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
            btnbuscar.Location = new Point(682, 24);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(50, 31);
            btnbuscar.TabIndex = 58;
            btnbuscar.UseVisualStyleBackColor = false;
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
            btnlimpiarbuscador.Location = new Point(740, 24);
            btnlimpiarbuscador.Margin = new Padding(3, 4, 3, 4);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(43, 31);
            btnlimpiarbuscador.TabIndex = 59;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(469, 25);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(206, 27);
            txtbusqueda.TabIndex = 57;
            // 
            // cbobusqueda
            // 
            cbobusqueda.BackColor = SystemColors.Control;
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(316, 25);
            cbobusqueda.Margin = new Padding(3, 4, 3, 4);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(146, 28);
            cbobusqueda.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Location = new Point(233, 32);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 55;
            label11.Text = "Buscar por:";
            // 
            // mdOrdenCompraPendiente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 652);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label11);
            Controls.Add(btnRegresar);
            Controls.Add(btnEditarOC);
            Controls.Add(btnAnularOC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvdetalles);
            Controls.Add(dgvdata);
            Name = "mdOrdenCompraPendiente";
            Text = "mdOrdenCompraPendiente";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn ProveedorRazonSocial;
        private DataGridViewTextBoxColumn MontoTotalEstimado;
        private DataGridViewTextBoxColumn IdOrdenCompra;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridView dgvdetalles;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn CantidadOrdenada;
        private DataGridViewTextBoxColumn CantidadRecibida;
        private DataGridViewTextBoxColumn CantidadPendiente;
        private DataGridViewTextBoxColumn PrecioEstimado;
        private DataGridViewTextBoxColumn SubtotalEstimado;
        private DataGridViewTextBoxColumn IdDetalleOrdenCompra;
        private DataGridViewTextBoxColumn IdProducto;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnAnularOC;
        private FontAwesome.Sharp.IconButton btnEditarOC;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label11;
    }
}