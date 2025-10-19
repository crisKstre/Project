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
            btnCerrar = new Button();
            ventasBtn = new Button();
            invBtn = new Button();
            adminPnl = new Panel();
            label3 = new Label();
            NombreAgrupacionLbl = new Label();
            NombreLbl = new Label();
            PosicionLbl = new Label();
            sidePnl.SuspendLayout();
            adminPnl.SuspendLayout();
            SuspendLayout();
            // 
            // sidePnl
            // 
            sidePnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sidePnl.BackColor = Color.Salmon;
            sidePnl.Controls.Add(PosicionLbl);
            sidePnl.Controls.Add(NombreLbl);
            sidePnl.Controls.Add(NombreAgrupacionLbl);
            sidePnl.Controls.Add(btnCerrar);
            sidePnl.Controls.Add(ventasBtn);
            sidePnl.Controls.Add(invBtn);
            sidePnl.Location = new Point(0, 0);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(211, 821);
            sidePnl.TabIndex = 0;
            sidePnl.Paint += panel1_Paint;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Salmon;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Leelawadee", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(0, 760);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(210, 51);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "   Cerrar Sesion";
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
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
            // adminPnl
            // 
            adminPnl.BackColor = Color.Snow;
            adminPnl.Controls.Add(label3);
            adminPnl.Location = new Point(206, 0);
            adminPnl.Margin = new Padding(3, 4, 3, 4);
            adminPnl.Name = "adminPnl";
            adminPnl.Size = new Size(777, 821);
            adminPnl.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Leelawadee", 30F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(777, 821);
            label3.TabIndex = 1;
            label3.Text = "Hola Mundo";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NombreAgrupacionLbl
            // 
            NombreAgrupacionLbl.AutoSize = true;
            NombreAgrupacionLbl.Location = new Point(8, 16);
            NombreAgrupacionLbl.Name = "NombreAgrupacionLbl";
            NombreAgrupacionLbl.Size = new Size(50, 20);
            NombreAgrupacionLbl.TabIndex = 24;
            NombreAgrupacionLbl.Text = "label1";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(8, 48);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(50, 20);
            NombreLbl.TabIndex = 25;
            NombreLbl.Text = "label2";
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Location = new Point(8, 80);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(50, 20);
            PosicionLbl.TabIndex = 26;
            PosicionLbl.Text = "label4";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 816);
            Controls.Add(adminPnl);
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
            adminPnl.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Panel adminPnl;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button ventasBtn;
        private System.Windows.Forms.Label label3;
        private Button btnCerrar;
        private Label PosicionLbl;
        private Label NombreLbl;
        private Label NombreAgrupacionLbl;
    }
}

