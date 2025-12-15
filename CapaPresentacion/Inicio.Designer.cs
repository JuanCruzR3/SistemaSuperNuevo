namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            submenunegocio = new ToolStripMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            submenuordendecompra = new ToolStripMenuItem();
            submenuverordenes = new ToolStripMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            submenureportecompras = new ToolStripMenuItem();
            submenureporteventas = new ToolStripMenuItem();
            submenureporteordenescompra = new ToolStripMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            menutitulo = new MenuStrip();
            label1 = new Label();
            contenedor = new Panel();
            label2 = new Label();
            lblusuario = new Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { menuusuarios, menumantenedor, menuventas, menucompras, menuclientes, menuproveedores, menureportes, menuacercade });
            menu.Location = new Point(0, 78);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 2, 0, 2);
            menu.Size = new Size(1400, 78);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            menuusuarios.IconColor = Color.Black;
            menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuarios.IconSize = 50;
            menuusuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuusuarios.Name = "menuusuarios";
            menuusuarios.Size = new Size(79, 74);
            menuusuarios.Text = "Usuarios";
            menuusuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuusuarios.Click += menuusuarios_Click;
            // 
            // menumantenedor
            // 
            menumantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenucategoria, submenuproducto, submenunegocio });
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            menumantenedor.IconColor = Color.Black;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 50;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(104, 74);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            submenucategoria.IconColor = Color.Black;
            submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenucategoria.Name = "submenucategoria";
            submenucategoria.Size = new Size(157, 26);
            submenucategoria.Text = "Categoria";
            submenucategoria.Click += submenucategoria_Click;
            // 
            // submenuproducto
            // 
            submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuproducto.IconColor = Color.Black;
            submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuproducto.Name = "submenuproducto";
            submenuproducto.Size = new Size(157, 26);
            submenuproducto.Text = "Producto";
            submenuproducto.Click += submenuproducto_Click;
            // 
            // submenunegocio
            // 
            submenunegocio.Name = "submenunegocio";
            submenunegocio.Size = new Size(157, 26);
            submenunegocio.Text = "Negocio";
            submenunegocio.Click += submenunegocio_Click;
            // 
            // menuventas
            // 
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 50;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(66, 74);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarventa.IconColor = Color.Black;
            submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(165, 26);
            submenuregistrarventa.Text = "Registrar";
            submenuregistrarventa.Click += submenuregistrarventa_Click;
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetalleventa.IconColor = Color.Black;
            submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(165, 26);
            submenuverdetalleventa.Text = "Ver Detalle";
            submenuverdetalleventa.Click += submenuverdetalleventa_Click;
            // 
            // menucompras
            // 
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarcompra, submenuverdetallecompra, submenuordendecompra, submenuverordenes });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(82, 74);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarcompra
            // 
            submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarcompra.IconColor = Color.Black;
            submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(225, 26);
            submenuregistrarcompra.Text = "Registrar";
            submenuregistrarcompra.Click += submenuregistrarcompra_Click;
            // 
            // submenuverdetallecompra
            // 
            submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetallecompra.IconColor = Color.Black;
            submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetallecompra.Name = "submenuverdetallecompra";
            submenuverdetallecompra.Size = new Size(225, 26);
            submenuverdetallecompra.Text = "Ver Detalle";
            submenuverdetallecompra.Click += submenuverdetallecompra_Click;
            // 
            // submenuordendecompra
            // 
            submenuordendecompra.Name = "submenuordendecompra";
            submenuordendecompra.Size = new Size(225, 26);
            submenuordendecompra.Text = "Ordenes de Compra";
            submenuordendecompra.Click += submenuordendecompra_Click;
            // 
            // submenuverordenes
            // 
            submenuverordenes.Name = "submenuverordenes";
            submenuverordenes.Size = new Size(225, 26);
            submenuverordenes.Text = "Ver Ordenes";
            submenuverordenes.Click += submenuverordenes_Click;
            // 
            // menuclientes
            // 
            menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menuclientes.IconColor = Color.Black;
            menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuclientes.IconSize = 50;
            menuclientes.ImageScaling = ToolStripItemImageScaling.None;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(75, 74);
            menuclientes.Text = "Clientes";
            menuclientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuclientes.Click += menuclientes_Click;
            // 
            // menuproveedores
            // 
            menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuproveedores.IconColor = Color.Black;
            menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuproveedores.IconSize = 50;
            menuproveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuproveedores.Name = "menuproveedores";
            menuproveedores.Size = new Size(105, 74);
            menuproveedores.Text = "Proveedores";
            menuproveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuproveedores.Click += menuproveedores_Click;
            // 
            // menureportes
            // 
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { submenureportecompras, submenureporteventas, submenureporteordenescompra });
            menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(82, 74);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenureportecompras
            // 
            submenureportecompras.Name = "submenureportecompras";
            submenureportecompras.Size = new Size(261, 26);
            submenureportecompras.Text = "Reporte Compras";
            submenureportecompras.Click += submenureportecompras_Click;
            // 
            // submenureporteventas
            // 
            submenureporteventas.Name = "submenureporteventas";
            submenureporteventas.Size = new Size(261, 26);
            submenureporteventas.Text = "Reporte Ventas";
            submenureporteventas.Click += submenureporteventas_Click;
            // 
            // submenureporteordenescompra
            // 
            submenureporteordenescompra.Name = "submenureporteordenescompra";
            submenureporteordenescompra.Size = new Size(261, 26);
            submenureporteordenescompra.Text = "Reporte Ordenes Compra";
            submenureporteordenescompra.Click += submenureporteordenescompra_Click;
            // 
            // menuacercade
            // 
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(91, 74);
            menuacercade.Text = "Acerca De";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            menuacercade.Click += menuacercade_Click;
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.SteelBlue;
            menutitulo.ImageScalingSize = new Size(24, 24);
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.Padding = new Padding(7, 2, 0, 2);
            menutitulo.RightToLeft = RightToLeft.Yes;
            menutitulo.Size = new Size(1400, 78);
            menutitulo.TabIndex = 1;
            menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(348, 41);
            label1.TabIndex = 2;
            label1.Text = "SUPER PRIMAVERA";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 156);
            contenedor.Margin = new Padding(3, 4, 3, 4);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1400, 665);
            contenedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(822, 30);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.SteelBlue;
            lblusuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(886, 30);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(86, 23);
            lblusuario.TabIndex = 5;
            lblusuario.Text = "lblUsuario";
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.SteelBlue;
            btnsalir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.ForeColor = Color.SteelBlue;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnsalir.IconColor = Color.Firebrick;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 40;
            btnsalir.Location = new Point(1299, 10);
            btnsalir.Margin = new Padding(3, 4, 3, 4);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(72, 62);
            btnsalir.TabIndex = 6;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 821);
            Controls.Add(btnsalir);
            Controls.Add(lblusuario);
            Controls.Add(label2);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menutitulo);
            MainMenuStrip = menu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private Panel contenedor;
        private Label label2;
        private Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private ToolStripMenuItem submenunegocio;
        private ToolStripMenuItem submenureportecompras;
        private ToolStripMenuItem submenureporteventas;
        private FontAwesome.Sharp.IconButton btnsalir;
        private ToolStripMenuItem submenuordendecompra;
        private ToolStripMenuItem submenuverordenes;
        private ToolStripMenuItem submenureporteordenescompra;
    }
}