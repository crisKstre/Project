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
            PosicionLbl = new Label();
            NombreLbl = new Label();
            NombreAgrupacionLbl = new Label();
            btnCerrarSesion = new Button();
            ventasBtn = new Button();
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
            label3.Font = new Font("Leelawadee", 30F, FontStyle.Bold);
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
            sidePnl.Controls.Add(PosicionLbl);
            sidePnl.Controls.Add(NombreLbl);
            sidePnl.Controls.Add(NombreAgrupacionLbl);
            sidePnl.Controls.Add(btnCerrarSesion);
            sidePnl.Controls.Add(ventasBtn);
            sidePnl.Controls.Add(EventosBtn);
            sidePnl.Location = new Point(0, -2);
            sidePnl.Margin = new Padding(3, 4, 3, 4);
            sidePnl.Name = "sidePnl";
            sidePnl.Size = new Size(152, 821);
            sidePnl.TabIndex = 2;
            // 
            // PosicionLbl
            // 
            PosicionLbl.AutoSize = true;
            PosicionLbl.Font = new Font("Leelawadee", 10F);
            PosicionLbl.Location = new Point(8, 80);
            PosicionLbl.Name = "PosicionLbl";
            PosicionLbl.Size = new Size(54, 20);
            PosicionLbl.TabIndex = 26;
            PosicionLbl.Text = "label4";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Leelawadee", 10F);
            NombreLbl.Location = new Point(8, 48);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(54, 20);
            NombreLbl.TabIndex = 25;
            NombreLbl.Text = "label2";
            // 
            // NombreAgrupacionLbl
            // 
            NombreAgrupacionLbl.AutoSize = true;
            NombreAgrupacionLbl.Font = new Font("Leelawadee", 10F);
            NombreAgrupacionLbl.Location = new Point(8, 16);
            NombreAgrupacionLbl.Name = "NombreAgrupacionLbl";
            NombreAgrupacionLbl.Size = new Size(54, 20);
            NombreAgrupacionLbl.TabIndex = 24;
            NombreAgrupacionLbl.Text = "label1";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.PaleGreen;
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
            // 
            // ventasBtn
            // 
            ventasBtn.BackColor = Color.PaleGreen;
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
            ventasBtn.Text = "   Historial";
            ventasBtn.TextAlign = ContentAlignment.MiddleLeft;
            ventasBtn.UseVisualStyleBackColor = false;
            // 
            // EventosBtn
            // 
            EventosBtn.BackColor = Color.PaleGreen;
            EventosBtn.Cursor = Cursors.Hand;
            EventosBtn.FlatAppearance.BorderSize = 0;
            EventosBtn.FlatStyle = FlatStyle.Flat;
            EventosBtn.Font = new Font("Leelawadee", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventosBtn.ForeColor = Color.Black;
            EventosBtn.Location = new Point(-2, 175);
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
        private Button ventasBtn;
        private Button EventosBtn;
    }
}