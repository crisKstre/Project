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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            FechaInicioLbl = new Label();
            FechaFinLbl = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            comboTipoEvento = new ComboBox();
            dgvEventos = new DataGridView();
            button1 = new Button();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            panel2 = new Panel();
            txtNombre = new TextBox();
            panel3 = new Panel();
            txtCupos = new TextBox();
            panel4 = new Panel();
            txtPrecio = new TextBox();
            txtLugar = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            inv_tl_Bg.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarMonthBackground = Color.LightCyan;
            dtpFechaInicio.Cursor = Cursors.Hand;
            dtpFechaInicio.Font = new Font("Century Gothic", 13.2000008F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(1152, 136);
            dtpFechaInicio.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpFechaInicio.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 34);
            dtpFechaInicio.TabIndex = 2;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarMonthBackground = Color.PaleGreen;
            dtpFechaFin.Cursor = Cursors.Hand;
            dtpFechaFin.Font = new Font("Century Gothic", 13.2000008F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(1152, 232);
            dtpFechaFin.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpFechaFin.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 34);
            dtpFechaFin.TabIndex = 4;
            // 
            // FechaInicioLbl
            // 
            FechaInicioLbl.AutoSize = true;
            FechaInicioLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FechaInicioLbl.Location = new Point(1152, 104);
            FechaInicioLbl.Name = "FechaInicioLbl";
            FechaInicioLbl.Size = new Size(136, 19);
            FechaInicioLbl.TabIndex = 5;
            FechaInicioLbl.Text = "Fecha de inicio";
            FechaInicioLbl.Click += FechaInicioLbl_Click;
            // 
            // FechaFinLbl
            // 
            FechaFinLbl.AutoSize = true;
            FechaFinLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FechaFinLbl.Location = new Point(1152, 200);
            FechaFinLbl.Name = "FechaFinLbl";
            FechaFinLbl.Size = new Size(153, 19);
            FechaFinLbl.TabIndex = 6;
            FechaFinLbl.Text = "Fecha de termino";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.LightCyan;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Century Gothic", 13.2000008F);
            txtDescripcion.Location = new Point(200, 328);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = resources.GetString("txtDescripcion.PlaceholderText");
            txtDescripcion.Size = new Size(744, 128);
            txtDescripcion.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.Location = new Point(1152, 304);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 16;
            label1.Text = "Tipo de evento";
            // 
            // comboTipoEvento
            // 
            comboTipoEvento.BackColor = Color.LightCyan;
            comboTipoEvento.Cursor = Cursors.Hand;
            comboTipoEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoEvento.FlatStyle = FlatStyle.Flat;
            comboTipoEvento.Font = new Font("Century Gothic", 13.2000008F);
            comboTipoEvento.FormattingEnabled = true;
            comboTipoEvento.Location = new Point(1152, 336);
            comboTipoEvento.Name = "comboTipoEvento";
            comboTipoEvento.Size = new Size(248, 33);
            comboTipoEvento.TabIndex = 17;
            // 
            // dgvEventos
            // 
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.AllowUserToDeleteRows = false;
            dgvEventos.AllowUserToResizeColumns = false;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEventos.BackgroundColor = Color.LightCyan;
            dgvEventos.BorderStyle = BorderStyle.None;
            dgvEventos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEventos.ColumnHeadersHeight = 56;
            dgvEventos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCyan;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEventos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEventos.EnableHeadersVisualStyles = false;
            dgvEventos.GridColor = Color.Teal;
            dgvEventos.Location = new Point(64, 512);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.RowHeadersVisible = false;
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(1488, 432);
            dgvEventos.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(1272, 432);
            button1.Name = "button1";
            button1.Size = new Size(184, 56);
            button1.TabIndex = 30;
            button1.Text = "Crear evento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCrearEvento_Click;
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.MediumTurquoise;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(16, 16);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(392, 56);
            inv_tl_Bg.TabIndex = 31;
            // 
            // tituloLbl
            // 
            tituloLbl.BackColor = Color.MediumTurquoise;
            tituloLbl.Dock = DockStyle.Fill;
            tituloLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            tituloLbl.ForeColor = Color.Snow;
            tituloLbl.Location = new Point(0, 0);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(392, 56);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "  Eventos";
            tituloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(200, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 1);
            panel2.TabIndex = 45;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightCyan;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(208, 136);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del evento";
            txtNombre.Size = new Size(240, 32);
            txtNombre.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(200, 264);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 1);
            panel3.TabIndex = 49;
            // 
            // txtCupos
            // 
            txtCupos.BackColor = Color.LightCyan;
            txtCupos.BorderStyle = BorderStyle.None;
            txtCupos.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCupos.Location = new Point(208, 232);
            txtCupos.MaxLength = 4;
            txtCupos.Multiline = true;
            txtCupos.Name = "txtCupos";
            txtCupos.PlaceholderText = "Cupos";
            txtCupos.Size = new Size(240, 32);
            txtCupos.TabIndex = 48;
            txtCupos.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(648, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 1);
            panel4.TabIndex = 51;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.LightCyan;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(672, 232);
            txtPrecio.MaxLength = 8;
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio entrada";
            txtPrecio.Size = new Size(240, 32);
            txtPrecio.TabIndex = 50;
            txtPrecio.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtLugar
            // 
            txtLugar.BackColor = Color.LightCyan;
            txtLugar.Cursor = Cursors.Hand;
            txtLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            txtLugar.FlatStyle = FlatStyle.Flat;
            txtLugar.Font = new Font("Century Gothic", 13.2000008F);
            txtLugar.FormattingEnabled = true;
            txtLugar.Location = new Point(648, 136);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(288, 33);
            txtLugar.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.Location = new Point(656, 104);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 53;
            label2.Text = "Lugar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(192, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 1);
            panel1.TabIndex = 54;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Location = new Point(640, 176);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 1);
            panel5.TabIndex = 55;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Location = new Point(1152, 376);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 1);
            panel6.TabIndex = 56;
            // 
            // FormEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1619, 993);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtLugar);
            Controls.Add(panel4);
            Controls.Add(txtPrecio);
            Controls.Add(panel3);
            Controls.Add(txtCupos);
            Controls.Add(panel2);
            Controls.Add(txtNombre);
            Controls.Add(inv_tl_Bg);
            Controls.Add(button1);
            Controls.Add(dgvEventos);
            Controls.Add(comboTipoEvento);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(FechaFinLbl);
            Controls.Add(FechaInicioLbl);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
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
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label FechaInicioLbl;
        private Label FechaFinLbl;
        private TextBox txtDescripcion;
        private Label label1;
        private ComboBox comboTipoEvento;
        private DataGridView dgvEventos;
        private Button btnCrearEvento;
        private Button button1;
        private Panel inv_tl_Bg;
        private Label tituloLbl;
        private Panel panel2;
        private TextBox txtNombre;
        private Panel panel3;
        private TextBox txtCupos;
        private Panel panel4;
        private TextBox txtPrecio;
        private ComboBox txtLugar;
        private Label label2;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
    }
}