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
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre puesto";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Location = new Point(40, 64);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(160, 27);
            txtNombrePuesto.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(240, 64);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(160, 27);
            txtCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 32);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(448, 64);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(160, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 32);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // dgvPuestos
            // 
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(48, 136);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.Size = new Size(616, 144);
            dgvPuestos.TabIndex = 6;
            // 
            // btnRegistrarPuesto
            // 
            btnRegistrarPuesto.Location = new Point(656, 56);
            btnRegistrarPuesto.Name = "btnRegistrarPuesto";
            btnRegistrarPuesto.Size = new Size(152, 37);
            btnRegistrarPuesto.TabIndex = 7;
            btnRegistrarPuesto.Text = "Registrar puesto";
            btnRegistrarPuesto.UseVisualStyleBackColor = true;
            btnRegistrarPuesto.Click += btnRegistrarPuesto_Click;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 491);
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
    }
}