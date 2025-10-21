namespace Presentacion.FormsAgrupacion
{
    partial class FormEventos
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
            dgvEventos = new DataGridView();
            NombreLbl = new Label();
            dtpFechaInicio = new DateTimePicker();
            txtNombre = new TextBox();
            dtpFechaFin = new DateTimePicker();
            FechaInicioLbl = new Label();
            FechaFinLbl = new Label();
            LugarLbl = new Label();
            txtLugar = new TextBox();
            CuposLbl = new Label();
            txtCupos = new TextBox();
            txtPrecio = new TextBox();
            PrecioLbl = new Label();
            txtDescripcion = new TextBox();
            DescLbl = new Label();
            btnCrearEvento = new Button();
            label1 = new Label();
            comboTipoEvento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(40, 440);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.Size = new Size(728, 304);
            dgvEventos.TabIndex = 0;
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(32, 56);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(138, 20);
            NombreLbl.TabIndex = 1;
            NombreLbl.Text = "Nombre del evento";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(240, 88);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 27);
            txtNombre.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(528, 88);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 27);
            dtpFechaFin.TabIndex = 4;
            // 
            // FechaInicioLbl
            // 
            FechaInicioLbl.AutoSize = true;
            FechaInicioLbl.Location = new Point(240, 56);
            FechaInicioLbl.Name = "FechaInicioLbl";
            FechaInicioLbl.Size = new Size(108, 20);
            FechaInicioLbl.TabIndex = 5;
            FechaInicioLbl.Text = "Fecha de inicio";
            // 
            // FechaFinLbl
            // 
            FechaFinLbl.AutoSize = true;
            FechaFinLbl.Location = new Point(528, 56);
            FechaFinLbl.Name = "FechaFinLbl";
            FechaFinLbl.Size = new Size(124, 20);
            FechaFinLbl.TabIndex = 6;
            FechaFinLbl.Text = "Fecha de termino";
            // 
            // LugarLbl
            // 
            LugarLbl.AutoSize = true;
            LugarLbl.Location = new Point(64, 144);
            LugarLbl.Name = "LugarLbl";
            LugarLbl.Size = new Size(46, 20);
            LugarLbl.TabIndex = 7;
            LugarLbl.Text = "Lugar";
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(64, 176);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(168, 27);
            txtLugar.TabIndex = 8;
            // 
            // CuposLbl
            // 
            CuposLbl.AutoSize = true;
            CuposLbl.Location = new Point(304, 144);
            CuposLbl.Name = "CuposLbl";
            CuposLbl.Size = new Size(50, 20);
            CuposLbl.TabIndex = 9;
            CuposLbl.Text = "Cupos";
            // 
            // txtCupos
            // 
            txtCupos.Location = new Point(304, 176);
            txtCupos.Name = "txtCupos";
            txtCupos.Size = new Size(168, 27);
            txtCupos.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(560, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(168, 27);
            txtPrecio.TabIndex = 12;
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Location = new Point(560, 144);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(105, 20);
            PrecioLbl.TabIndex = 11;
            PrecioLbl.Text = "Precio entrada";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(40, 264);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(392, 27);
            txtDescripcion.TabIndex = 14;
            // 
            // DescLbl
            // 
            DescLbl.AutoSize = true;
            DescLbl.Location = new Point(40, 232);
            DescLbl.Name = "DescLbl";
            DescLbl.Size = new Size(87, 20);
            DescLbl.TabIndex = 13;
            DescLbl.Text = "Descripcion";
            // 
            // btnCrearEvento
            // 
            btnCrearEvento.Location = new Point(608, 360);
            btnCrearEvento.Name = "btnCrearEvento";
            btnCrearEvento.Size = new Size(134, 45);
            btnCrearEvento.TabIndex = 15;
            btnCrearEvento.Text = "Publicar evento";
            btnCrearEvento.UseVisualStyleBackColor = true;
            btnCrearEvento.Click += btnCrearEvento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 232);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 16;
            label1.Text = "Tipo de evento";
            // 
            // comboTipoEvento
            // 
            comboTipoEvento.FormattingEnabled = true;
            comboTipoEvento.Location = new Point(528, 264);
            comboTipoEvento.Name = "comboTipoEvento";
            comboTipoEvento.Size = new Size(151, 28);
            comboTipoEvento.TabIndex = 17;
            // 
            // FormEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 774);
            Controls.Add(comboTipoEvento);
            Controls.Add(label1);
            Controls.Add(btnCrearEvento);
            Controls.Add(txtDescripcion);
            Controls.Add(DescLbl);
            Controls.Add(txtPrecio);
            Controls.Add(PrecioLbl);
            Controls.Add(txtCupos);
            Controls.Add(CuposLbl);
            Controls.Add(txtLugar);
            Controls.Add(LugarLbl);
            Controls.Add(FechaFinLbl);
            Controls.Add(FechaInicioLbl);
            Controls.Add(dtpFechaFin);
            Controls.Add(txtNombre);
            Controls.Add(dtpFechaInicio);
            Controls.Add(NombreLbl);
            Controls.Add(dgvEventos);
            Name = "FormEventos";
            Text = "FormEventos";
            Load += FormEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEventos;
        private Label NombreLbl;
        private DateTimePicker dtpFechaInicio;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaFin;
        private Label FechaInicioLbl;
        private Label FechaFinLbl;
        private Label LugarLbl;
        private TextBox txtLugar;
        private Label CuposLbl;
        private TextBox txtCupos;
        private TextBox txtPrecio;
        private Label PrecioLbl;
        private TextBox txtDescripcion;
        private Label DescLbl;
        private Button btnCrearEvento;
        private Label label1;
        private ComboBox comboTipoEvento;
    }
}