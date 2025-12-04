namespace Presentacion
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            IniciarSLink = new LinkLabel();
            RegistrarPnl = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            errorLbl = new Label();
            groupBox1 = new GroupBox();
            cbAgrupacion = new CheckBox();
            cbFeriante = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            txtEmail = new TextBox();
            RegistrarPnl.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // IniciarSLink
            // 
            IniciarSLink.AutoSize = true;
            IniciarSLink.Cursor = Cursors.Hand;
            IniciarSLink.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IniciarSLink.LinkColor = Color.DimGray;
            IniciarSLink.Location = new Point(512, 608);
            IniciarSLink.Name = "IniciarSLink";
            IniciarSLink.Size = new Size(56, 23);
            IniciarSLink.TabIndex = 6;
            IniciarSLink.TabStop = true;
            IniciarSLink.Text = "Aquí";
            IniciarSLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegistrarPnl
            // 
            RegistrarPnl.BackColor = Color.PaleTurquoise;
            RegistrarPnl.Controls.Add(panel1);
            RegistrarPnl.Dock = DockStyle.Fill;
            RegistrarPnl.Location = new Point(0, 0);
            RegistrarPnl.Name = "RegistrarPnl";
            RegistrarPnl.Size = new Size(1382, 853);
            RegistrarPnl.TabIndex = 8;
            RegistrarPnl.Paint += RegistrarPnl_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(errorLbl);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(IniciarSLink);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(320, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 704);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateGray;
            panel6.Location = new Point(416, 224);
            panel6.Name = "panel6";
            panel6.Size = new Size(320, 1);
            panel6.TabIndex = 28;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Location = new Point(416, 320);
            panel5.Name = "panel5";
            panel5.Size = new Size(320, 1);
            panel5.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Location = new Point(32, 416);
            panel4.Name = "panel4";
            panel4.Size = new Size(320, 1);
            panel4.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Location = new Point(32, 320);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 1);
            panel3.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(32, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 1);
            panel2.TabIndex = 21;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLbl.Image = (Image)resources.GetObject("errorLbl.Image");
            errorLbl.ImageAlign = ContentAlignment.MiddleLeft;
            errorLbl.Location = new Point(128, 480);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(47, 21);
            errorLbl.TabIndex = 24;
            errorLbl.Text = "Error";
            errorLbl.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAgrupacion);
            groupBox1.Controls.Add(cbFeriante);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(416, 352);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 96);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rol";
            // 
            // cbAgrupacion
            // 
            cbAgrupacion.AutoSize = true;
            cbAgrupacion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAgrupacion.Location = new Point(32, 32);
            cbAgrupacion.Name = "cbAgrupacion";
            cbAgrupacion.Size = new Size(147, 27);
            cbAgrupacion.TabIndex = 19;
            cbAgrupacion.Text = "Agrupación";
            cbAgrupacion.UseVisualStyleBackColor = true;
            cbAgrupacion.CheckedChanged += cbAgrupacion_CheckedChanged;
            // 
            // cbFeriante
            // 
            cbFeriante.AutoSize = true;
            cbFeriante.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFeriante.Location = new Point(32, 64);
            cbFeriante.Name = "cbFeriante";
            cbFeriante.Size = new Size(110, 27);
            cbFeriante.TabIndex = 22;
            cbFeriante.Text = "Feriante";
            cbFeriante.UseVisualStyleBackColor = true;
            cbFeriante.CheckedChanged += cbFeriante_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(288, 64);
            label7.Name = "label7";
            label7.Size = new Size(195, 40);
            label7.TabIndex = 21;
            label7.Text = "Registrarse";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(416, 160);
            label6.Name = "label6";
            label6.Size = new Size(174, 16);
            label6.TabIndex = 20;
            label6.Text = "* Con esto iniciaras sesión";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightCyan;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Century Gothic", 13.2000008F);
            txtNombre.Location = new Point(32, 192);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Personal";
            txtNombre.Size = new Size(320, 32);
            txtNombre.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CadetBlue;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.DarkTurquoise;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Turquoise;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Azure;
            btnRegistrar.Location = new Point(128, 512);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(523, 64);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 608);
            label1.Name = "label1";
            label1.Size = new Size(325, 23);
            label1.TabIndex = 7;
            label1.Text = "Ya tienes cuenta?   Inicia sesion ";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightCyan;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Century Gothic", 13.2000008F);
            txtTelefono.Location = new Point(32, 384);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Télefono";
            txtTelefono.Size = new Size(320, 32);
            txtTelefono.TabIndex = 17;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.LightCyan;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 13.2000008F);
            txtPass.Location = new Point(416, 288);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(320, 32);
            txtPass.TabIndex = 15;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.LightCyan;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 13.2000008F);
            txtUsuario.Location = new Point(416, 192);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre cuenta / Agrupacion";
            txtUsuario.Size = new Size(320, 32);
            txtUsuario.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightCyan;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Century Gothic", 13.2000008F);
            txtEmail.Location = new Point(32, 288);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(320, 32);
            txtEmail.TabIndex = 13;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1382, 853);
            Controls.Add(RegistrarPnl);
            MaximizeBox = false;
            Name = "Registrar";
            Text = "Registrar";
            RegistrarPnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel IniciarSLink;
        private Panel RegistrarPnl;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private TextBox txtPass;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Button btnRegistrar;
        private CheckBox cbAgrupacion;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private CheckBox cbFeriante;
        private GroupBox groupBox1;
        private Label errorLbl;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
    }
}