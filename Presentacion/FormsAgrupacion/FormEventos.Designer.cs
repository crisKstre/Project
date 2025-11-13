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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventos));
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
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            inv_tl_Bg.SuspendLayout();
            SuspendLayout();
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            NombreLbl.Location = new Point(32, 72);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(169, 19);
            NombreLbl.TabIndex = 1;
            NombreLbl.Text = "Nombre del evento";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Cursor = Cursors.Hand;
            dtpFechaInicio.Font = new Font("Century Gothic", 9F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(240, 104);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 26);
            dtpFechaInicio.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9F);
            txtNombre.Location = new Point(32, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 26);
            txtNombre.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarMonthBackground = Color.PaleGreen;
            dtpFechaFin.Cursor = Cursors.Hand;
            dtpFechaFin.Font = new Font("Century Gothic", 9F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(528, 104);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 26);
            dtpFechaFin.TabIndex = 4;
            // 
            // FechaInicioLbl
            // 
            FechaInicioLbl.AutoSize = true;
            FechaInicioLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FechaInicioLbl.Location = new Point(240, 72);
            FechaInicioLbl.Name = "FechaInicioLbl";
            FechaInicioLbl.Size = new Size(136, 19);
            FechaInicioLbl.TabIndex = 5;
            FechaInicioLbl.Text = "Fecha de inicio";
            // 
            // FechaFinLbl
            // 
            FechaFinLbl.AutoSize = true;
            FechaFinLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FechaFinLbl.Location = new Point(528, 72);
            FechaFinLbl.Name = "FechaFinLbl";
            FechaFinLbl.Size = new Size(153, 19);
            FechaFinLbl.TabIndex = 6;
            FechaFinLbl.Text = "Fecha de termino";
            // 
            // LugarLbl
            // 
            LugarLbl.AutoSize = true;
            LugarLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            LugarLbl.Location = new Point(64, 160);
            LugarLbl.Name = "LugarLbl";
            LugarLbl.Size = new Size(53, 19);
            LugarLbl.TabIndex = 7;
            LugarLbl.Text = "Lugar";
            // 
            // txtLugar
            // 
            txtLugar.Font = new Font("Century Gothic", 9F);
            txtLugar.Location = new Point(64, 192);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(168, 26);
            txtLugar.TabIndex = 8;
            // 
            // CuposLbl
            // 
            CuposLbl.AutoSize = true;
            CuposLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            CuposLbl.Location = new Point(304, 160);
            CuposLbl.Name = "CuposLbl";
            CuposLbl.Size = new Size(62, 19);
            CuposLbl.TabIndex = 9;
            CuposLbl.Text = "Cupos";
            // 
            // txtCupos
            // 
            txtCupos.Font = new Font("Century Gothic", 9F);
            txtCupos.Location = new Point(304, 192);
            txtCupos.MaxLength = 6;
            txtCupos.Name = "txtCupos";
            txtCupos.Size = new Size(168, 26);
            txtCupos.TabIndex = 10;
            txtCupos.KeyPress += txtCupos_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Century Gothic", 9F);
            txtPrecio.Location = new Point(560, 192);
            txtPrecio.MaxLength = 8;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(152, 26);
            txtPrecio.TabIndex = 12;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            PrecioLbl.Location = new Point(560, 160);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(129, 19);
            PrecioLbl.TabIndex = 11;
            PrecioLbl.Text = "Precio entrada";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 9F);
            txtDescripcion.Location = new Point(40, 280);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(448, 128);
            txtDescripcion.TabIndex = 14;
            // 
            // DescLbl
            // 
            DescLbl.AutoSize = true;
            DescLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            DescLbl.Location = new Point(40, 248);
            DescLbl.Name = "DescLbl";
            DescLbl.Size = new Size(107, 19);
            DescLbl.TabIndex = 13;
            DescLbl.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.Location = new Point(560, 248);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 16;
            label1.Text = "Tipo de evento";
            // 
            // comboTipoEvento
            // 
            comboTipoEvento.BackColor = Color.Honeydew;
            comboTipoEvento.Cursor = Cursors.Hand;
            comboTipoEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoEvento.FlatStyle = FlatStyle.Flat;
            comboTipoEvento.Font = new Font("Century Gothic", 9F);
            comboTipoEvento.FormattingEnabled = true;
            comboTipoEvento.Location = new Point(560, 280);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEventos.ColumnHeadersHeight = 48;
            dgvEventos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEventos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEventos.EnableHeadersVisualStyles = false;
            dgvEventos.GridColor = SystemColors.ControlDark;
            dgvEventos.Location = new Point(16, 432);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.RowHeadersVisible = false;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(776, 344);
            dgvEventos.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(624, 352);
            button1.Name = "button1";
            button1.Size = new Size(152, 53);
            button1.TabIndex = 30;
            button1.Text = "Crear evento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCrearEvento_Click;
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.PaleGreen;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(8, 8);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(293, 42);
            inv_tl_Bg.TabIndex = 31;
            // 
            // tituloLbl
            // 
            tituloLbl.BackColor = Color.PaleGreen;
            tituloLbl.Dock = DockStyle.Fill;
            tituloLbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloLbl.Location = new Point(0, 0);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(293, 42);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "  Eventos";
            tituloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 774);
            Controls.Add(inv_tl_Bg);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEventos";
            Text = "Eventos";
            Load += FormEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            inv_tl_Bg.ResumeLayout(false);
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
        private Panel inv_tl_Bg;
        private Label tituloLbl;
    }
}