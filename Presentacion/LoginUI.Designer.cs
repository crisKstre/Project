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
            errorLbl = new Label();
            linkLabel1 = new LinkLabel();
            txtPass = new TextBox();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            LoginPnl.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPnl
            // 
            LoginPnl.Controls.Add(errorLbl);
            LoginPnl.Controls.Add(linkLabel1);
            LoginPnl.Controls.Add(txtPass);
            LoginPnl.Controls.Add(btnLogin);
            LoginPnl.Controls.Add(txtUsuario);
            LoginPnl.Dock = DockStyle.Fill;
            LoginPnl.Location = new Point(0, 0);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(964, 452);
            LoginPnl.TabIndex = 0;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.Font = new Font("Segoe UI", 11F);
            errorLbl.Image = (Image)resources.GetObject("errorLbl.Image");
            errorLbl.ImageAlign = ContentAlignment.MiddleLeft;
            errorLbl.Location = new Point(224, 192);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(54, 25);
            errorLbl.TabIndex = 14;
            errorLbl.Text = "Error";
            errorLbl.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Leelawadee", 12F);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(424, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 24);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Leelawadee", 13F);
            txtPass.Location = new Point(221, 143);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(515, 26);
            txtPass.TabIndex = 12;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkTurquoise;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.DarkTurquoise;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Turquoise;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Leelawadee", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Azure;
            btnLogin.Location = new Point(224, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(512, 64);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Leelawadee", 13F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(221, 78);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Nombre de Usuario";
            txtUsuario.Size = new Size(515, 26);
            txtUsuario.TabIndex = 10;
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(964, 452);
            Controls.Add(LoginPnl);
            Name = "LoginUI";
            Text = "LoginUI";
            LoginPnl.ResumeLayout(false);
            LoginPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPnl;
        private LinkLabel linkLabel1;
        private TextBox txtPass;
        private Button btnLogin;
        private TextBox txtUsuario;
        private Label errorLbl;
    }
}