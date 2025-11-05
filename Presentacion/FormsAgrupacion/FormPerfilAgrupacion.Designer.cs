namespace Presentacion.FormsAgrupacion
{
    partial class FormPerfilAgrupacion
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
            dgvPostulaciones = new DataGridView();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).BeginInit();
            inv_tl_Bg.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPostulaciones
            // 
            dgvPostulaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPostulaciones.Location = new Point(32, 120);
            dgvPostulaciones.Name = "dgvPostulaciones";
            dgvPostulaciones.RowHeadersWidth = 51;
            dgvPostulaciones.Size = new Size(768, 624);
            dgvPostulaciones.TabIndex = 0;
            dgvPostulaciones.CellContentClick += dgvPostulaciones_CellContentClick;
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.PaleGreen;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(8, 8);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(293, 42);
            inv_tl_Bg.TabIndex = 23;
            // 
            // tituloLbl
            // 
            tituloLbl.BackColor = Color.PaleGreen;
            tituloLbl.Dock = DockStyle.Fill;
            tituloLbl.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloLbl.Location = new Point(0, 0);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(293, 42);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "  Perfil";
            tituloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormPerfilAgrupacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 799);
            Controls.Add(inv_tl_Bg);
            Controls.Add(dgvPostulaciones);
            Name = "FormPerfilAgrupacion";
            Text = "Perfil";
            Load += FormPerfilAgrupacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).EndInit();
            inv_tl_Bg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPostulaciones;
        private Panel inv_tl_Bg;
        private Label tituloLbl;
    }
}