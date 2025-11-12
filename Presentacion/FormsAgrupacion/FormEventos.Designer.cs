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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            label1 = new Label();
            comboTipoEvento = new ComboBox();
            dgvEventos = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            NombreLbl.Location = new Point(32, 56);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(169, 19);
            NombreLbl.TabIndex = 1;
            NombreLbl.Text = "Nombre del evento";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Century Gothic", 9F);
            dtpFechaInicio.Location = new Point(240, 88);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 26);
            dtpFechaInicio.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9F);
            txtNombre.Location = new Point(32, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 26);
            txtNombre.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Century Gothic", 9F);
            dtpFechaFin.Location = new Point(528, 88);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 26);
            dtpFechaFin.TabIndex = 4;
            // 
            // FechaInicioLbl
            // 
            FechaInicioLbl.AutoSize = true;
            FechaInicioLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FechaInicioLbl.Location = new Point(240, 56);
            FechaInicioLbl.Name = "FechaInicioLbl";
            FechaInicioLbl.Size = new Size(136, 19);
            FechaInicioLbl.TabIndex = 5;
            FechaInicioLbl.Text = "Fecha de inicio";
            // 
            // FechaFinLbl
            // 
            FechaFinLbl.AutoSize = true;
            FechaFinLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FechaFinLbl.Location = new Point(528, 56);
            FechaFinLbl.Name = "FechaFinLbl";
            FechaFinLbl.Size = new Size(153, 19);
            FechaFinLbl.TabIndex = 6;
            FechaFinLbl.Text = "Fecha de termino";
            // 
            // LugarLbl
            // 
            LugarLbl.AutoSize = true;
            LugarLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            LugarLbl.Location = new Point(64, 144);
            LugarLbl.Name = "LugarLbl";
            LugarLbl.Size = new Size(53, 19);
            LugarLbl.TabIndex = 7;
            LugarLbl.Text = "Lugar";
            // 
            // txtLugar
            // 
            txtLugar.Font = new Font("Century Gothic", 9F);
            txtLugar.Location = new Point(64, 176);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(168, 26);
            txtLugar.TabIndex = 8;
            // 
            // CuposLbl
            // 
            CuposLbl.AutoSize = true;
            CuposLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            CuposLbl.Location = new Point(304, 144);
            CuposLbl.Name = "CuposLbl";
            CuposLbl.Size = new Size(62, 19);
            CuposLbl.TabIndex = 9;
            CuposLbl.Text = "Cupos";
            // 
            // txtCupos
            // 
            txtCupos.Font = new Font("Century Gothic", 9F);
            txtCupos.Location = new Point(304, 176);
            txtCupos.Name = "txtCupos";
            txtCupos.Size = new Size(168, 26);
            txtCupos.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Century Gothic", 9F);
            txtPrecio.Location = new Point(560, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(168, 26);
            txtPrecio.TabIndex = 12;
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            PrecioLbl.Location = new Point(560, 144);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(129, 19);
            PrecioLbl.TabIndex = 11;
            PrecioLbl.Text = "Precio entrada";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 9F);
            txtDescripcion.Location = new Point(40, 264);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(392, 26);
            txtDescripcion.TabIndex = 14;
            // 
            // DescLbl
            // 
            DescLbl.AutoSize = true;
            DescLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            DescLbl.Location = new Point(40, 232);
            DescLbl.Name = "DescLbl";
            DescLbl.Size = new Size(107, 19);
            DescLbl.TabIndex = 13;
            DescLbl.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.Location = new Point(528, 232);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 16;
            label1.Text = "Tipo de evento";
            // 
            // comboTipoEvento
            // 
            comboTipoEvento.Font = new Font("Century Gothic", 9F);
            comboTipoEvento.FormattingEnabled = true;
            comboTipoEvento.Location = new Point(528, 264);
            comboTipoEvento.Name = "comboTipoEvento";
            comboTipoEvento.Size = new Size(151, 28);
            comboTipoEvento.TabIndex = 17;
            // 
            // dgvEventos
            // 
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.AllowUserToDeleteRows = false;
            dgvEventos.AllowUserToResizeColumns = false;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEventos.BackgroundColor = Color.White;
            dgvEventos.BorderStyle = BorderStyle.None;
            dgvEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEventos.ColumnHeadersHeight = 48;
            dgvEventos.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEventos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEventos.EnableHeadersVisualStyles = false;
            dgvEventos.GridColor = SystemColors.ControlDark;
            dgvEventos.Location = new Point(16, 416);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.RowHeadersVisible = false;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(776, 336);
            dgvEventos.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(624, 336);
            button1.Name = "button1";
            button1.Size = new Size(152, 53);
            button1.TabIndex = 30;
            button1.Text = "Crear evento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCrearEvento_Click;
            // 
            // FormEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 774);
            Controls.Add(button1);
            Controls.Add(dgvEventos);
            Controls.Add(comboTipoEvento);
            Controls.Add(label1);
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
            Name = "FormEventos";
            Text = "FormEventos";
            Load += FormEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
        private ComboBox comboTipoEvento;
        private DataGridView dgvEventos;
        private Button btnCrearEvento;
        private Button button1;
    }
}