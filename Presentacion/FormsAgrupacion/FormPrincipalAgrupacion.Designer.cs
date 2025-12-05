namespace Presentacion.FormsAgrupacion
{
    partial class FormPrincipalAgrupacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalAgrupacion));
            sidePnl = new Panel();
            btnCerrarSesion = new Button();
            NombreAgrupacionLbl = new Label();
            label1 = new Label();
            button1 = new Button();
            PosicionLbl = new Label();
            NombreLbl = new Label();
            eventosBtn = new Button();
            label3 = new Label();
            AgrupacionPnl = new Panel();
            sidePnl.SuspendLayout();
            AgrupacionPnl.SuspendLayout();
            SuspendLayout();
            // 
            // sidePnl
            // 
            sidePnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sidePnl.BackColor = Color.FromArgb(0, 102, 102);
            sidePnl.Controls.Add(btnCerrarSesion);
            sidePnl.Controls.Add(NombreAgrupacionLbl);
            sidePnl.Controls.Add(label1);
            sidePnl.Controls.Add(button1);
            sidePnl.Controls.Add(PosicionLbl);
            sidePnl.Controls.Add(NombreLbl);
            sidePnl.Controls.Add(eventosBtn);
            sidePnl.Location = new Point(0, -2);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(280, 1040);
            sidePnl.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.DarkSlateGray;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Snow;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 904);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(280, 72);
            btnCerrarSesion.TabIndex = 36;
            btnCerrarSesion.Text = "         Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click_1;
            // 
            // NombreAgrupacionLbl
            // 
            NombreAgrupacionLbl.AutoSize = true;
            NombreAgrupacionLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            NombreAgrupacionLbl.ForeColor = Color.WhiteSmoke;
            NombreAgrupacionLbl.Location = new Point(16, 64);
            NombreAgrupacionLbl.Name = "NombreAgrupacionLbl";
            NombreAgrupacionLbl.Size = new Size(82, 27);
            NombreAgrupacionLbl.TabIndex = 35;
            NombreAgrupacionLbl.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 192);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(280, 112);
            button1.TabIndex = 33;
            button1.Text = "          Perfil";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            PosicionLbl.ForeColor = Color.WhiteSmoke;
            PosicionLbl.Location = new Point(16, 112);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(82, 27);
            PosicionLbl.TabIndex = 32;
            PosicionLbl.Text = "label4";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            NombreLbl.ForeColor = Color.WhiteSmoke;
            NombreLbl.Location = new Point(16, 16);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(82, 27);
            NombreLbl.TabIndex = 31;
            NombreLbl.Text = "label2";
            // 
            // eventosBtn
            // 
            eventosBtn.BackColor = Color.DarkSlateGray;
            eventosBtn.Cursor = Cursors.Hand;
            eventosBtn.FlatAppearance.BorderSize = 0;
            eventosBtn.FlatStyle = FlatStyle.Flat;
            eventosBtn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventosBtn.ForeColor = Color.Snow;
            eventosBtn.Image = (Image)resources.GetObject("eventosBtn.Image");
            eventosBtn.ImageAlign = ContentAlignment.MiddleLeft;
            eventosBtn.Location = new Point(0, 320);
            eventosBtn.Margin = new Padding(3, 4, 3, 4);
            eventosBtn.Name = "eventosBtn";
            eventosBtn.Size = new Size(280, 112);
            eventosBtn.TabIndex = 30;
            eventosBtn.Text = "          Eventos";
            eventosBtn.TextAlign = ContentAlignment.MiddleLeft;
            eventosBtn.UseVisualStyleBackColor = false;
            eventosBtn.Click += eventosBtn_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.CadetBlue;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1792, 1040);
            label3.TabIndex = 1;
            label3.Text = "Bienvenido";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgrupacionPnl
            // 
            AgrupacionPnl.BackColor = Color.Snow;
            AgrupacionPnl.Controls.Add(label3);
            AgrupacionPnl.Location = new Point(280, 0);
            AgrupacionPnl.Margin = new Padding(3, 4, 3, 4);
            AgrupacionPnl.Name = "AgrupacionPnl";
            AgrupacionPnl.Size = new Size(1792, 1040);
            AgrupacionPnl.TabIndex = 3;
            // 
            // FormPrincipalAgrupacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 993);
            Controls.Add(AgrupacionPnl);
            Controls.Add(sidePnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(1918, 1018);
            Name = "FormPrincipalAgrupacion";
            Text = "Agrupaciones";
            FormClosed += FormPrincipalAgrupacion_FormClosed;
            Load += FormPrincipalAgrupacion_Load;
            sidePnl.ResumeLayout(false);
            sidePnl.PerformLayout();
            AgrupacionPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePnl;
        private Label label3;
        private Panel AgrupacionPnl;
        private Label NombreAgrupacionLbl;
        private Label label1;
        private Button button1;
        private Label PosicionLbl;
        private Label NombreLbl;
        private Button eventosBtn;
        private Button btnCerrarSesion;
    }
}