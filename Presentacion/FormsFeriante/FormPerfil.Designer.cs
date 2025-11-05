namespace Presentacion.FormsFeriante
{
    partial class FormPerfil
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
            label1 = new Label();
            txtNombrePuesto = new TextBox();
            txtCategoria = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            dgvPuestos = new DataGridView();
            btnRegistrarPuesto = new Button();
            label4 = new Label();
            dgvPostulaciones = new DataGridView();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).BeginInit();
            inv_tl_Bg.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre puesto";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Location = new Point(40, 152);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(160, 27);
            txtNombrePuesto.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(240, 152);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(160, 27);
            txtCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 120);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(448, 152);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(160, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 120);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // dgvPuestos
            // 
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(48, 224);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.Size = new Size(616, 144);
            dgvPuestos.TabIndex = 6;
            // 
            // btnRegistrarPuesto
            // 
            btnRegistrarPuesto.Location = new Point(656, 144);
            btnRegistrarPuesto.Name = "btnRegistrarPuesto";
            btnRegistrarPuesto.Size = new Size(152, 37);
            btnRegistrarPuesto.TabIndex = 7;
            btnRegistrarPuesto.Text = "Registrar puesto";
            btnRegistrarPuesto.UseVisualStyleBackColor = true;
            btnRegistrarPuesto.Click += btnRegistrarPuesto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 400);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 8;
            label4.Text = "Historial Postulaciones";
            // 
            // dgvPostulaciones
            // 
            dgvPostulaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPostulaciones.Location = new Point(48, 432);
            dgvPostulaciones.Name = "dgvPostulaciones";
            dgvPostulaciones.RowHeadersWidth = 51;
            dgvPostulaciones.Size = new Size(616, 112);
            dgvPostulaciones.TabIndex = 9;
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.Salmon;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(8, 8);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(293, 42);
            inv_tl_Bg.TabIndex = 22;
            // 
            // tituloLbl
            // 
            tituloLbl.BackColor = Color.LightSalmon;
            tituloLbl.Dock = DockStyle.Fill;
            tituloLbl.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloLbl.Location = new Point(0, 0);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(293, 42);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "  Perfil";
            tituloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 799);
            Controls.Add(inv_tl_Bg);
            Controls.Add(dgvPostulaciones);
            Controls.Add(label4);
            Controls.Add(btnRegistrarPuesto);
            Controls.Add(dgvPuestos);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(txtNombrePuesto);
            Controls.Add(label1);
            Name = "FormPerfil";
            Text = "FormPerfil";
            Load += FormPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).EndInit();
            inv_tl_Bg.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrePuesto;
        private TextBox txtCategoria;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private DataGridView dgvPuestos;
        private Button btnRegistrarPuesto;
        private Label label4;
        private DataGridView dgvPostulaciones;
        private Panel inv_tl_Bg;
        private Label tituloLbl;
    }
}