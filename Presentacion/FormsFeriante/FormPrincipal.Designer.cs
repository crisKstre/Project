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
            label1 = new Label();
            button1 = new Button();
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
            sidePnl.BackColor = Color.FromArgb(0, 102, 102);
            sidePnl.Controls.Add(label1);
            sidePnl.Controls.Add(button1);
            sidePnl.Controls.Add(PosicionLbl);
            sidePnl.Controls.Add(NombreLbl);
            sidePnl.Controls.Add(btnCerrarSesion);
            sidePnl.Controls.Add(eventosBtn);
            sidePnl.Location = new Point(0, 0);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.MaximumSize = new Size(1920, 1080);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(280, 1040);
            sidePnl.TabIndex = 0;
            sidePnl.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 29;
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
            button1.Location = new Point(0, 200);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(280, 112);
            button1.TabIndex = 28;
            button1.Text = "          Perfil";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            PosicionLbl.ForeColor = Color.WhiteSmoke;
            PosicionLbl.Location = new Point(16, 64);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(82, 27);
            PosicionLbl.TabIndex = 26;
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
            NombreLbl.TabIndex = 25;
            NombreLbl.Text = "label2";
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
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = "         Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrar_Click;
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
            eventosBtn.Location = new Point(0, 328);
            eventosBtn.Margin = new Padding(3, 4, 3, 4);
            eventosBtn.Name = "eventosBtn";
            eventosBtn.Size = new Size(280, 112);
            eventosBtn.TabIndex = 21;
            eventosBtn.Text = "          Eventos";
            eventosBtn.TextAlign = ContentAlignment.MiddleLeft;
            eventosBtn.UseVisualStyleBackColor = false;
            eventosBtn.Click += button1_Click;
            // 
            // FeriantePnl
            // 
            FeriantePnl.BackColor = Color.CadetBlue;
            FeriantePnl.Controls.Add(label3);
            FeriantePnl.Location = new Point(280, 0);
            FeriantePnl.Margin = new Padding(3, 4, 3, 4);
            FeriantePnl.Name = "FeriantePnl";
            FeriantePnl.Size = new Size(1792, 1040);
            FeriantePnl.TabIndex = 1;
            // 
            // label3
            // 
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
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 993);
            Controls.Add(FeriantePnl);
            Controls.Add(sidePnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(1918, 1018);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feriantes";
            FormClosed += FormPrincipal_FormClosed;
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
        private Button button1;
        private Label label1;
    }
}

