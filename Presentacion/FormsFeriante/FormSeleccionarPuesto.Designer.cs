namespace Presentacion.FormsFeriante
{
    partial class FormSeleccionarPuesto
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
            cmbPuestos = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbPuestos
            // 
            cmbPuestos.BackColor = SystemColors.Control;
            cmbPuestos.Cursor = Cursors.Hand;
            cmbPuestos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuestos.FlatStyle = FlatStyle.Flat;
            cmbPuestos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(40, 96);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.RightToLeft = RightToLeft.No;
            cmbPuestos.Size = new Size(151, 28);
            cmbPuestos.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Salmon;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(216, 88);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 43);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(344, 88);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 43);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(332, 23);
            label1.TabIndex = 24;
            label1.Text = "Seleccionar puesto para postular";
            // 
            // FormSeleccionarPuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(497, 184);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbPuestos);
            Name = "FormSeleccionarPuesto";
            Text = "Selección de Puesto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbPuestos;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
    }
}