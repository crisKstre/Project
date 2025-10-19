namespace Presentacion
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
            LoginPnl = new Panel();
            panel2 = new Panel();
            LoginTitle = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPnl
            // 
            LoginPnl.BackColor = Color.Azure;
            LoginPnl.Dock = DockStyle.Fill;
            LoginPnl.Location = new Point(0, 104);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(982, 499);
            LoginPnl.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(LoginTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 104);
            panel2.TabIndex = 0;
            // 
            // LoginTitle
            // 
            LoginTitle.BackColor = Color.DarkTurquoise;
            LoginTitle.Dock = DockStyle.Fill;
            LoginTitle.Font = new Font("Leelawadee", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitle.ForeColor = Color.DarkSlateGray;
            LoginTitle.Location = new Point(0, 0);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.Size = new Size(982, 104);
            LoginTitle.TabIndex = 0;
            LoginTitle.Text = "Bienvenido";
            LoginTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(LoginPnl);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPnl;
        private Panel panel2;
        private Label LoginTitle;
    }
}