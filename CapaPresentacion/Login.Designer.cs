namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtdocumento = new TextBox();
            txtclave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btningresar = new FontAwesome.Sharp.IconButton();
            btncancelar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            LLrestablecerclave = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 275);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 188);
            label2.Name = "label2";
            label2.Size = new Size(223, 26);
            label2.TabIndex = 1;
            label2.Text = "SUPER PRIMAVERA";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 131;
            iconPictureBox1.Location = new Point(53, 31);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(131, 153);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(258, 66);
            txtdocumento.Margin = new Padding(3, 4, 3, 4);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(233, 27);
            txtdocumento.TabIndex = 3;
            txtdocumento.KeyPress += textBoxNumeros_KeyPress;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(258, 131);
            txtclave.Margin = new Padding(3, 4, 3, 4);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(233, 27);
            txtclave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 42);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Nro Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 107);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.RoyalBlue;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatAppearance.BorderColor = Color.Black;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.ForeColor = Color.White;
            btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btningresar.IconColor = Color.White;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.IconSize = 21;
            btningresar.Location = new Point(269, 202);
            btningresar.Margin = new Padding(3, 4, 3, 4);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(128, 55);
            btningresar.TabIndex = 7;
            btningresar.Text = "Ingresar";
            btningresar.TextAlign = ContentAlignment.MiddleRight;
            btningresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Firebrick;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.White;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            btncancelar.IconColor = Color.White;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 21;
            btncancelar.Location = new Point(414, 202);
            btncancelar.Margin = new Padding(3, 4, 3, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(135, 55);
            btncancelar.TabIndex = 8;
            btncancelar.Text = "Cancelar";
            btncancelar.TextAlign = ContentAlignment.MiddleRight;
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(338, 14);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 9;
            label5.Text = "INICIAR SESIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(512, 14);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LLrestablecerclave
            // 
            LLrestablecerclave.AutoSize = true;
            LLrestablecerclave.Location = new Point(312, 178);
            LLrestablecerclave.Name = "LLrestablecerclave";
            LLrestablecerclave.Size = new Size(161, 20);
            LLrestablecerclave.TabIndex = 11;
            LLrestablecerclave.TabStop = true;
            LLrestablecerclave.Text = "¿Olvidó su contraseña?";
            LLrestablecerclave.LinkClicked += LLrestablecerclave_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(598, 275);
            Controls.Add(LLrestablecerclave);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtclave);
            Controls.Add(txtdocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtdocumento;
        private TextBox txtclave;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private Label label5;
        private PictureBox pictureBox1;
        private LinkLabel LLrestablecerclave;
    }
}