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
            IniciarSLink = new LinkLabel();
            RegistrarPnl = new Panel();
            FoA = new CheckBox();
            btnRegistrar = new Button();
            txtTelefono = new TextBox();
            TelefonoLbl = new Label();
            txtPass = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegistrarPnl.SuspendLayout();
            SuspendLayout();
            // 
            // IniciarSLink
            // 
            IniciarSLink.AutoSize = true;
            IniciarSLink.Cursor = Cursors.Hand;
            IniciarSLink.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IniciarSLink.LinkColor = Color.DimGray;
            IniciarSLink.Location = new Point(600, 448);
            IniciarSLink.Name = "IniciarSLink";
            IniciarSLink.Size = new Size(56, 23);
            IniciarSLink.TabIndex = 6;
            IniciarSLink.TabStop = true;
            IniciarSLink.Text = "Aquí";
            IniciarSLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegistrarPnl
            // 
            RegistrarPnl.Controls.Add(FoA);
            RegistrarPnl.Controls.Add(btnRegistrar);
            RegistrarPnl.Controls.Add(txtTelefono);
            RegistrarPnl.Controls.Add(TelefonoLbl);
            RegistrarPnl.Controls.Add(txtPass);
            RegistrarPnl.Controls.Add(label5);
            RegistrarPnl.Controls.Add(txtEmail);
            RegistrarPnl.Controls.Add(label4);
            RegistrarPnl.Controls.Add(txtUsuario);
            RegistrarPnl.Controls.Add(label3);
            RegistrarPnl.Controls.Add(txtNombre);
            RegistrarPnl.Controls.Add(label2);
            RegistrarPnl.Controls.Add(label1);
            RegistrarPnl.Controls.Add(IniciarSLink);
            RegistrarPnl.Dock = DockStyle.Fill;
            RegistrarPnl.Location = new Point(0, 0);
            RegistrarPnl.Name = "RegistrarPnl";
            RegistrarPnl.Size = new Size(964, 499);
            RegistrarPnl.TabIndex = 8;
            RegistrarPnl.Paint += RegistrarPnl_Paint;
            // 
            // FoA
            // 
            FoA.AutoSize = true;
            FoA.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoA.Location = new Point(504, 272);
            FoA.Name = "FoA";
            FoA.Size = new Size(288, 31);
            FoA.TabIndex = 19;
            FoA.Text = "Feriante o Agrupacion";
            FoA.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkTurquoise;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.DarkTurquoise;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Turquoise;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Azure;
            btnRegistrar.Location = new Point(224, 352);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(523, 64);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(96, 272);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(312, 20);
            txtTelefono.TabIndex = 17;
            // 
            // TelefonoLbl
            // 
            TelefonoLbl.AutoSize = true;
            TelefonoLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            TelefonoLbl.Location = new Point(184, 232);
            TelefonoLbl.Name = "TelefonoLbl";
            TelefonoLbl.Size = new Size(108, 27);
            TelefonoLbl.TabIndex = 16;
            TelefonoLbl.Text = "Telefono";
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(528, 176);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(312, 20);
            txtPass.TabIndex = 15;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label5.Location = new Point(608, 136);
            label5.Name = "label5";
            label5.Size = new Size(142, 27);
            label5.TabIndex = 14;
            label5.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(96, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 20);
            txtEmail.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label4.Location = new Point(200, 136);
            label4.Name = "label4";
            label4.Size = new Size(73, 27);
            label4.TabIndex = 12;
            label4.Text = "Email";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(528, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(312, 20);
            txtUsuario.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 32);
            label3.Name = "label3";
            label3.Size = new Size(363, 27);
            label3.TabIndex = 10;
            label3.Text = "Nombre Negocio / Agrupación";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(96, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 20);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 448);
            label1.Name = "label1";
            label1.Size = new Size(313, 23);
            label1.TabIndex = 7;
            label1.Text = "Ya tienes cuenta? Inicia sesion ";
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(964, 499);
            Controls.Add(RegistrarPnl);
            MaximizeBox = false;
            Name = "Registrar";
            Text = "Registrar";
            RegistrarPnl.ResumeLayout(false);
            RegistrarPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel IniciarSLink;
        private Panel RegistrarPnl;
        private Label label1;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPass;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtTelefono;
        private Label TelefonoLbl;
        private Button btnRegistrar;
        private CheckBox FoA;
    }
}