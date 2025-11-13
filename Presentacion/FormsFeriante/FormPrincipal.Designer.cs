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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            sidePnl = new Panel();
            PerfilLink = new LinkLabel();
            PosicionLbl = new Label();
            NombreLbl = new Label();
            btnCerrarSesion = new Button();
            eventosBtn = new Button();
            FeriantePnl = new Panel();
            label3 = new Label();
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
            sidePnl.Controls.Add(btnCerrarSesion);
            sidePnl.Controls.Add(eventosBtn);
            sidePnl.Location = new Point(0, 0);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(152, 821);
            sidePnl.TabIndex = 0;
            sidePnl.Paint += panel1_Paint;
            // 
            // PerfilLink
            // 
            PerfilLink.AutoSize = true;
            PerfilLink.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PerfilLink.LinkColor = Color.Teal;
            PerfilLink.Location = new Point(8, 16);
            PerfilLink.Name = "PerfilLink";
            PerfilLink.Size = new Size(102, 27);
            PerfilLink.TabIndex = 27;
            PerfilLink.TabStop = true;
            PerfilLink.Text = "Mi Perfil";
            PerfilLink.LinkClicked += PerfilLink_LinkClicked;
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Font = new Font("Century Gothic", 10.2F);
            PosicionLbl.Location = new Point(8, 96);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(60, 21);
            PosicionLbl.TabIndex = 26;
            PosicionLbl.Text = "label4";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Century Gothic", 10.2F);
            NombreLbl.Location = new Point(8, 64);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(60, 21);
            NombreLbl.TabIndex = 25;
            NombreLbl.Text = "label2";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Salmon;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(0, 760);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(152, 51);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = " Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrar_Click;
            // 
            // eventosBtn
            // 
            eventosBtn.BackColor = Color.Salmon;
            eventosBtn.Cursor = Cursors.Hand;
            eventosBtn.FlatAppearance.BorderSize = 0;
            eventosBtn.FlatStyle = FlatStyle.Flat;
            eventosBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventosBtn.ForeColor = Color.Black;
            eventosBtn.Location = new Point(0, 216);
            eventosBtn.Margin = new Padding(3, 4, 3, 4);
            eventosBtn.Name = "eventosBtn";
            eventosBtn.Size = new Size(210, 91);
            eventosBtn.TabIndex = 21;
            eventosBtn.Text = "   Eventos";
            eventosBtn.TextAlign = ContentAlignment.MiddleLeft;
            eventosBtn.UseVisualStyleBackColor = false;
            eventosBtn.Click += button1_Click;
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
            label3.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(831, 821);
            label3.TabIndex = 1;
            label3.Text = "Hola Mundo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 816);
            Controls.Add(FeriantePnl);
            Controls.Add(sidePnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 863);
            MinimumSize = new Size(1000, 863);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feriantes";
            Load += AdminWF_Load;
            sidePnl.ResumeLayout(false);
            sidePnl.PerformLayout();
            FeriantePnl.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Panel FeriantePnl;
        private System.Windows.Forms.Button eventosBtn;
        private System.Windows.Forms.Label label3;
        private Button btnCerrarSesion;
        private Label PosicionLbl;
        private Label NombreLbl;
        private LinkLabel PerfilLink;
    }
}

