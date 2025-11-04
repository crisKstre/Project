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
            btnAceptar = new Button();
            btnCancelar = new Button();
            cmbPuestos = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(240, 96);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(352, 96);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbPuestos
            // 
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(64, 96);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(151, 28);
            cmbPuestos.TabIndex = 2;
            // 
            // FormSeleccionarPuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 251);
            Controls.Add(cmbPuestos);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FormSeleccionarPuesto";
            Text = "FormSeleccionarPuesto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cmbPuestos;
    }
}