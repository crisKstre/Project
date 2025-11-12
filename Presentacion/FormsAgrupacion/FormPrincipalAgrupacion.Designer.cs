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
            AgrupacionPnl = new Panel();
            label3 = new Label();
            sidePnl = new Panel();
            PerfilLink = new LinkLabel();
            PosicionLbl = new Label();
            NombreLbl = new Label();
            NombreAgrupacionLbl = new Label();
            btnCerrarSesion = new Button();
            EventosBtn = new Button();
            AgrupacionPnl.SuspendLayout();
            sidePnl.SuspendLayout();
            SuspendLayout();
            // 
            // AgrupacionPnl
            // 
            AgrupacionPnl.BackColor = Color.Snow;
            AgrupacionPnl.Controls.Add(label3);
            AgrupacionPnl.Location = new Point(152, -2);
            AgrupacionPnl.Margin = new Padding(3, 4, 3, 4);
            AgrupacionPnl.Name = "AgrupacionPnl";
            AgrupacionPnl.Size = new Size(831, 821);
            AgrupacionPnl.TabIndex = 3;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(831, 821);
            label3.TabIndex = 1;
            label3.Text = "Hola Mundo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sidePnl
            // 
            sidePnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sidePnl.BackColor = Color.PaleGreen;
            sidePnl.Controls.Add(PerfilLink);
            sidePnl.Controls.Add(PosicionLbl);
            sidePnl.Controls.Add(NombreLbl);
            sidePnl.Controls.Add(NombreAgrupacionLbl);
            sidePnl.Controls.Add(btnCerrarSesion);
            sidePnl.Controls.Add(EventosBtn);
            sidePnl.Location = new Point(0, -2);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(152, 821);
            sidePnl.TabIndex = 2;
            // 
            // PerfilLink
            // 
            PerfilLink.AutoSize = true;
            PerfilLink.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PerfilLink.LinkColor = Color.Teal;
            PerfilLink.Location = new Point(8, 16);
            PerfilLink.Name = "PerfilLink";
            PerfilLink.Size = new Size(102, 27);
            PerfilLink.TabIndex = 28;
            PerfilLink.TabStop = true;
            PerfilLink.Text = "Mi Perfil";
            PerfilLink.LinkClicked += PerfilLink_LinkClicked;
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Font = new Font("Century Gothic", 10.2F);
            PosicionLbl.Location = new Point(8, 128);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(60, 21);
            PosicionLbl.TabIndex = 26;
            PosicionLbl.Text = "label4";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Century Gothic", 10.2F);
            NombreLbl.Location = new Point(8, 96);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(60, 21);
            NombreLbl.TabIndex = 25;
            NombreLbl.Text = "label2";
            // 
            // NombreAgrupacionLbl
            // 
            NombreAgrupacionLbl.AutoSize = true;
            NombreAgrupacionLbl.Font = new Font("Century Gothic", 10.2F);
            NombreAgrupacionLbl.Location = new Point(8, 64);
            NombreAgrupacionLbl.Name = "NombreAgrupacionLbl";
            NombreAgrupacionLbl.Size = new Size(60, 21);
            NombreAgrupacionLbl.TabIndex = 24;
            NombreAgrupacionLbl.Text = "label1";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.PaleGreen;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(0, 760);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(210, 51);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = " Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // EventosBtn
            // 
            EventosBtn.BackColor = Color.PaleGreen;
            EventosBtn.Cursor = Cursors.Hand;
            EventosBtn.FlatAppearance.BorderSize = 0;
            EventosBtn.FlatStyle = FlatStyle.Flat;
            EventosBtn.Font = new Font("Leelawadee", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventosBtn.ForeColor = Color.Black;
            EventosBtn.Location = new Point(0, 216);
            EventosBtn.Margin = new Padding(3, 4, 3, 4);
            EventosBtn.Name = "EventosBtn";
            EventosBtn.Size = new Size(210, 91);
            EventosBtn.TabIndex = 21;
            EventosBtn.Text = "   Eventos";
            EventosBtn.TextAlign = ContentAlignment.MiddleLeft;
            EventosBtn.UseVisualStyleBackColor = false;
            EventosBtn.Click += EventosBtn_Click;
            // 
            // FormPrincipalAgrupacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 816);
            Controls.Add(AgrupacionPnl);
            Controls.Add(sidePnl);
            MaximumSize = new Size(1000, 863);
            MinimumSize = new Size(1000, 863);
            Name = "FormPrincipalAgrupacion";
            Text = "FormPrincipalAgrupacion";
            Load += FormPrincipalAgrupacion_Load;
            AgrupacionPnl.ResumeLayout(false);
            sidePnl.ResumeLayout(false);
            sidePnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AgrupacionPnl;
        private Label label3;
        private Panel sidePnl;
        private Label PosicionLbl;
        private Label NombreLbl;
        private Label NombreAgrupacionLbl;
        private Button btnCerrarSesion;
        private Button EventosBtn;
        private LinkLabel PerfilLink;
    }
}