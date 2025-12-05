namespace Presentacion
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            LoginPnl = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            errorLbl = new Label();
            txtUsuario = new TextBox();
            linkLabel1 = new LinkLabel();
            txtPass = new TextBox();
            LoginPnl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPnl
            // 
            LoginPnl.Anchor = AnchorStyles.None;
            LoginPnl.BackColor = Color.LightCyan;
            LoginPnl.BackgroundImageLayout = ImageLayout.None;
            LoginPnl.Controls.Add(panel1);
            LoginPnl.Location = new Point(0, 0);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(1400, 856);
            LoginPnl.TabIndex = 0;
            LoginPnl.Paint += LoginPnl_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.PaleTurquoise;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(errorLbl);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(txtPass);
            panel1.Location = new Point(416, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 512);
            panel1.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(84, 252);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 1);
            panel3.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(84, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 1);
            panel2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 63);
            label1.Name = "label1";
            label1.Size = new Size(253, 44);
            label1.TabIndex = 15;
            label1.Text = "Iniciar Sesión";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CadetBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.DarkTurquoise;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Turquoise;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Azure;
            btnLogin.Location = new Point(36, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(512, 64);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLbl.Image = (Image)resources.GetObject("errorLbl.Image");
            errorLbl.ImageAlign = ContentAlignment.MiddleLeft;
            errorLbl.Location = new Point(36, 288);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(47, 21);
            errorLbl.TabIndex = 14;
            errorLbl.Text = "Error";
            errorLbl.Visible = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.PaleTurquoise;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(96, 156);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Nombre de Usuario";
            txtUsuario.Size = new Size(391, 32);
            txtUsuario.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(236, 424);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 23);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.PaleTurquoise;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(96, 216);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(391, 27);
            txtPass.TabIndex = 11;
            txtPass.UseSystemPasswordChar = true;
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1382, 853);
            Controls.Add(LoginPnl);
            MaximizeBox = false;
            MaximumSize = new Size(1400, 900);
            Name = "LoginUI";
            Text = "LoginUI";
            Resize += LoginUI_Resize;
            LoginPnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPnl;
        private LinkLabel linkLabel1;
        private TextBox txtPass;
        private Button btnLogin;
        private TextBox txtUsuario;
        private Label errorLbl;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
    }
}