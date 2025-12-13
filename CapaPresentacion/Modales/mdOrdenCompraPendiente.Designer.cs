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
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = SystemColors.Control;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { NumeroDocumento, FechaRegistro, ProveedorRazonSocial, MontoTotalEstimado, IdOrdenCompra, IdProveedor, DocumentoProveedor });
            dgvdata.Location = new Point(12, 33);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(924, 295);
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
            dgvdetalles.Size = new Size(924, 230);
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
            // mdOrdenCompraPendiente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 630);
            Controls.Add(dgvdetalles);
            Controls.Add(dgvdata);
            Name = "mdOrdenCompraPendiente";
            Text = "mdOrdenCompraPendiente";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetalles).EndInit();
            ResumeLayout(false);
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
    }
}