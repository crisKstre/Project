namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            sidePnl = new Panel();
            PosicionLbl = new Label();
            NombreLbl = new Label();
            NombreAgrupacionLbl = new Label();
            btnCerrarSesion = new Button();
            ventasBtn = new Button();
            invBtn = new Button();
            FeriantePnl = new Panel();
            label3 = new Label();
            PerfilLink = new LinkLabel();
            sidePnl.SuspendLayout();
            FeriantePnl.SuspendLayout();
            SuspendLayout();
            // 
            // sidePnl
            // 
            sidePnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sidePnl.BackColor = Color.Salmon;
            sidePnl.Controls.Add(PerfilLink);
            sidePnl.Controls.Add(PosicionLbl);
            sidePnl.Controls.Add(NombreLbl);
            sidePnl.Controls.Add(NombreAgrupacionLbl);
            sidePnl.Controls.Add(btnCerrarSesion);
            sidePnl.Controls.Add(ventasBtn);
            sidePnl.Controls.Add(invBtn);
            sidePnl.Location = new Point(0, 0);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(152, 821);
            sidePnl.TabIndex = 0;
            sidePnl.Paint += panel1_Paint;
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Font = new Font("Leelawadee", 10F);
            PosicionLbl.Location = new Point(8, 128);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(54, 20);
            PosicionLbl.TabIndex = 26;
            PosicionLbl.Text = "label4";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Leelawadee", 10F);
            NombreLbl.Location = new Point(8, 96);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(54, 20);
            NombreLbl.TabIndex = 25;
            NombreLbl.Text = "label2";
            // 
            // NombreAgrupacionLbl
            // 
            NombreAgrupacionLbl.AutoSize = true;
            NombreAgrupacionLbl.Font = new Font("Leelawadee", 10F);
            NombreAgrupacionLbl.Location = new Point(8, 64);
            NombreAgrupacionLbl.Name = "NombreAgrupacionLbl";
            NombreAgrupacionLbl.Size = new Size(54, 20);
            NombreAgrupacionLbl.TabIndex = 24;
            NombreAgrupacionLbl.Text = "label1";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Salmon;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Leelawadee", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(0, 760);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(210, 51);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = "   Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrar_Click;
            // 
            // ventasBtn
            // 
            ventasBtn.BackColor = Color.Salmon;
            ventasBtn.Cursor = Cursors.Hand;
            ventasBtn.FlatAppearance.BorderSize = 0;
            ventasBtn.FlatStyle = FlatStyle.Flat;
            ventasBtn.Font = new Font("Leelawadee", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventasBtn.ForeColor = Color.Black;
            ventasBtn.Location = new Point(-2, 274);
            ventasBtn.Margin = new Padding(3, 4, 3, 4);
            ventasBtn.Name = "ventasBtn";
            ventasBtn.Size = new Size(210, 91);
            ventasBtn.TabIndex = 22;
            ventasBtn.Text = "   Ventas";
            ventasBtn.TextAlign = ContentAlignment.MiddleLeft;
            ventasBtn.UseVisualStyleBackColor = false;
            ventasBtn.Click += button1_Click_1;
            // 
            // invBtn
            // 
            invBtn.BackColor = Color.Salmon;
            invBtn.Cursor = Cursors.Hand;
            invBtn.FlatAppearance.BorderSize = 0;
            invBtn.FlatStyle = FlatStyle.Flat;
            invBtn.Font = new Font("Leelawadee", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invBtn.ForeColor = Color.Black;
            invBtn.Location = new Point(-2, 175);
            invBtn.Margin = new Padding(3, 4, 3, 4);
            invBtn.Name = "invBtn";
            invBtn.Size = new Size(210, 91);
            invBtn.TabIndex = 21;
            invBtn.Text = "   Inventario";
            invBtn.TextAlign = ContentAlignment.MiddleLeft;
            invBtn.UseVisualStyleBackColor = false;
            invBtn.Click += button1_Click;
            // 
            // FeriantePnl
            // 
            FeriantePnl.BackColor = Color.Snow;
            FeriantePnl.Controls.Add(label3);
            FeriantePnl.Location = new Point(152, 0);
            FeriantePnl.Margin = new Padding(3, 4, 3, 4);
            FeriantePnl.Name = "FeriantePnl";
            FeriantePnl.Size = new Size(831, 821);
            FeriantePnl.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Leelawadee", 30F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(831, 821);
            label3.TabIndex = 1;
            label3.Text = "Hola Mundo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PerfilLink
            // 
            PerfilLink.AutoSize = true;
            PerfilLink.Font = new Font("Segoe UI", 13F);
            PerfilLink.LinkColor = Color.Teal;
            PerfilLink.Location = new Point(8, 16);
            PerfilLink.Name = "PerfilLink";
            PerfilLink.Size = new Size(61, 30);
            PerfilLink.TabIndex = 27;
            PerfilLink.TabStop = true;
            PerfilLink.Text = "Perfil";
            PerfilLink.LinkClicked += PerfilLink_LinkClicked;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 816);
            Controls.Add(FeriantePnl);
            Controls.Add(sidePnl);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 863);
            MinimumSize = new Size(1000, 863);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminWF_Load;
            sidePnl.ResumeLayout(false);
            sidePnl.PerformLayout();
            FeriantePnl.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Panel FeriantePnl;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button ventasBtn;
        private System.Windows.Forms.Label label3;
        private Button btnCerrarSesion;
        private Label PosicionLbl;
        private Label NombreLbl;
        private Label NombreAgrupacionLbl;
        private LinkLabel PerfilLink;
    }
}

