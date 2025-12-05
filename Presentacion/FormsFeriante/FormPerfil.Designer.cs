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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfil));
            txtNombrePuesto = new TextBox();
            txtCategoria = new TextBox();
            txtDescripcion = new TextBox();
            dgvPuestos = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            editarPuestoToolStripMenuItem = new ToolStripMenuItem();
            eliminarPuestoToolStripMenuItem = new ToolStripMenuItem();
            reiniciarTablaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            reiniciaToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            dgvPostulaciones = new DataGridView();
            btnRegistrarPuesto = new Button();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblTotalPostulaciones = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            lblLugarMasPostulado = new Label();
            panel5 = new Panel();
            label6 = new Label();
            lblAgrupacionMasPostulada = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            lblDenegadas = new Label();
            lblAceptadas = new Label();
            label9 = new Label();
            lblPendientes = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            inv_tl_Bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.BackColor = Color.LightCyan;
            txtNombrePuesto.BorderStyle = BorderStyle.None;
            txtNombrePuesto.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePuesto.Location = new Point(72, 176);
            txtNombrePuesto.Multiline = true;
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.PlaceholderText = "Nombre de puesto";
            txtNombrePuesto.Size = new Size(224, 32);
            txtNombrePuesto.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.LightCyan;
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(344, 176);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(224, 32);
            txtCategoria.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.LightCyan;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(608, 176);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(224, 32);
            txtDescripcion.TabIndex = 5;
            // 
            // dgvPuestos
            // 
            dgvPuestos.AllowUserToAddRows = false;
            dgvPuestos.AllowUserToDeleteRows = false;
            dgvPuestos.AllowUserToResizeColumns = false;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPuestos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPuestos.BackgroundColor = Color.LightCyan;
            dgvPuestos.BorderStyle = BorderStyle.None;
            dgvPuestos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuestos.ColumnHeadersHeight = 52;
            dgvPuestos.ContextMenuStrip = contextMenuStrip2;
            dgvPuestos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCyan;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPuestos.EnableHeadersVisualStyles = false;
            dgvPuestos.GridColor = Color.MediumTurquoise;
            dgvPuestos.Location = new Point(72, 288);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.ReadOnly = true;
            dgvPuestos.RowHeadersVisible = false;
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.Size = new Size(896, 160);
            dgvPuestos.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { editarPuestoToolStripMenuItem, eliminarPuestoToolStripMenuItem, reiniciarTablaToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(186, 76);
            // 
            // editarPuestoToolStripMenuItem
            // 
            editarPuestoToolStripMenuItem.Name = "editarPuestoToolStripMenuItem";
            editarPuestoToolStripMenuItem.Size = new Size(185, 24);
            editarPuestoToolStripMenuItem.Text = "Editar Puesto";
            editarPuestoToolStripMenuItem.Click += editarPuestoToolStripMenuItem_Click;
            // 
            // eliminarPuestoToolStripMenuItem
            // 
            eliminarPuestoToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eliminarPuestoToolStripMenuItem.Name = "eliminarPuestoToolStripMenuItem";
            eliminarPuestoToolStripMenuItem.Size = new Size(185, 24);
            eliminarPuestoToolStripMenuItem.Text = "Eliminar Puesto";
            eliminarPuestoToolStripMenuItem.Click += eliminarPuestoToolStripMenuItem_Click;
            // 
            // reiniciarTablaToolStripMenuItem
            // 
            reiniciarTablaToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reiniciarTablaToolStripMenuItem.Name = "reiniciarTablaToolStripMenuItem";
            reiniciarTablaToolStripMenuItem.Size = new Size(185, 24);
            reiniciarTablaToolStripMenuItem.Text = "Reiniciar Tabla";
            reiniciarTablaToolStripMenuItem.Click += reiniciarTablaToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { reiniciaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(189, 28);
            // 
            // reiniciaToolStripMenuItem
            // 
            reiniciaToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reiniciaToolStripMenuItem.Name = "reiniciaToolStripMenuItem";
            reiniciaToolStripMenuItem.Size = new Size(188, 24);
            reiniciaToolStripMenuItem.Text = "Reiniciar Tablas";
            reiniciaToolStripMenuItem.Click += reiniciaToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 480);
            label4.Name = "label4";
            label4.Size = new Size(261, 27);
            label4.TabIndex = 8;
            label4.Text = "Historial Postulaciones";
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.MediumTurquoise;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(16, 16);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(392, 56);
            inv_tl_Bg.TabIndex = 22;
            // 
            // tituloLbl
            // 
            tituloLbl.BackColor = Color.MediumTurquoise;
            tituloLbl.Dock = DockStyle.Fill;
            tituloLbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLbl.ForeColor = Color.Snow;
            tituloLbl.Location = new Point(0, 0);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(392, 56);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "  Perfil";
            tituloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvPostulaciones
            // 
            dgvPostulaciones.AllowUserToAddRows = false;
            dgvPostulaciones.AllowUserToDeleteRows = false;
            dgvPostulaciones.AllowUserToResizeColumns = false;
            dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPostulaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPostulaciones.BackgroundColor = Color.LightCyan;
            dgvPostulaciones.BorderStyle = BorderStyle.None;
            dgvPostulaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPostulaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPostulaciones.ColumnHeadersHeight = 52;
            dgvPostulaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPostulaciones.ContextMenuStrip = contextMenuStrip1;
            dgvPostulaciones.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightCyan;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPostulaciones.EnableHeadersVisualStyles = false;
            dgvPostulaciones.GridColor = Color.CadetBlue;
            dgvPostulaciones.Location = new Point(72, 512);
            dgvPostulaciones.Name = "dgvPostulaciones";
            dgvPostulaciones.ReadOnly = true;
            dgvPostulaciones.RowHeadersVisible = false;
            dgvPostulaciones.RowHeadersWidth = 51;
            dgvPostulaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPostulaciones.Size = new Size(896, 424);
            dgvPostulaciones.TabIndex = 7;
            // 
            // btnRegistrarPuesto
            // 
            btnRegistrarPuesto.BackColor = Color.MediumTurquoise;
            btnRegistrarPuesto.Cursor = Cursors.Hand;
            btnRegistrarPuesto.FlatAppearance.BorderSize = 0;
            btnRegistrarPuesto.FlatStyle = FlatStyle.Flat;
            btnRegistrarPuesto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPuesto.ForeColor = Color.Snow;
            btnRegistrarPuesto.Location = new Point(864, 160);
            btnRegistrarPuesto.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarPuesto.Name = "btnRegistrarPuesto";
            btnRegistrarPuesto.Size = new Size(184, 59);
            btnRegistrarPuesto.TabIndex = 23;
            btnRegistrarPuesto.Text = "Registrar Puesto";
            btnRegistrarPuesto.UseVisualStyleBackColor = false;
            btnRegistrarPuesto.Click += btnRegistrarPuesto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 256);
            label5.Name = "label5";
            label5.Size = new Size(141, 27);
            label5.TabIndex = 24;
            label5.Text = "Mis puestos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTotalPostulaciones);
            panel1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Snow;
            panel1.Location = new Point(1088, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 128);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(96, 32);
            label2.Name = "label2";
            label2.Size = new Size(303, 27);
            label2.TabIndex = 6;
            label2.Text = "Número de postulaciones";
            // 
            // lblTotalPostulaciones
            // 
            lblTotalPostulaciones.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPostulaciones.ForeColor = Color.Snow;
            lblTotalPostulaciones.Location = new Point(64, 72);
            lblTotalPostulaciones.Name = "lblTotalPostulaciones";
            lblTotalPostulaciones.Size = new Size(352, 29);
            lblTotalPostulaciones.TabIndex = 0;
            lblTotalPostulaciones.Text = "0";
            lblTotalPostulaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 120);
            label1.Name = "label1";
            label1.Size = new Size(189, 27);
            label1.TabIndex = 26;
            label1.Text = "Registrar puesto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(64, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 1);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(336, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 1);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(608, 208);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 1);
            panel4.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(112, 32);
            label3.Name = "label3";
            label3.Size = new Size(249, 27);
            label3.TabIndex = 35;
            label3.Text = "Lugar mas postulado";
            // 
            // lblLugarMasPostulado
            // 
            lblLugarMasPostulado.Anchor = AnchorStyles.None;
            lblLugarMasPostulado.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblLugarMasPostulado.ForeColor = Color.Snow;
            lblLugarMasPostulado.Location = new Point(64, 72);
            lblLugarMasPostulado.Name = "lblLugarMasPostulado";
            lblLugarMasPostulado.Size = new Size(352, 29);
            lblLugarMasPostulado.TabIndex = 30;
            lblLugarMasPostulado.Text = "-";
            lblLugarMasPostulado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblLugarMasPostulado);
            panel5.Location = new Point(1088, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(488, 128);
            panel5.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(96, 32);
            label6.Name = "label6";
            label6.Size = new Size(322, 27);
            label6.TabIndex = 44;
            label6.Text = "Agrupación mas postulada";
            // 
            // lblAgrupacionMasPostulada
            // 
            lblAgrupacionMasPostulada.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblAgrupacionMasPostulada.ForeColor = Color.Snow;
            lblAgrupacionMasPostulada.Location = new Point(64, 72);
            lblAgrupacionMasPostulada.Name = "lblAgrupacionMasPostulada";
            lblAgrupacionMasPostulada.Size = new Size(352, 29);
            lblAgrupacionMasPostulada.TabIndex = 41;
            lblAgrupacionMasPostulada.Text = "-";
            lblAgrupacionMasPostulada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSeaGreen;
            panel6.Controls.Add(lblAgrupacionMasPostulada);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(1088, 344);
            panel6.Name = "panel6";
            panel6.Size = new Size(488, 128);
            panel6.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14F);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(96, 32);
            label8.Name = "label8";
            label8.Size = new Size(321, 30);
            label8.TabIndex = 52;
            label8.Text = "Postulaciones denegadas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(96, 32);
            label7.Name = "label7";
            label7.Size = new Size(314, 30);
            label7.TabIndex = 51;
            label7.Text = "Postulaciones aceptadas";
            // 
            // lblDenegadas
            // 
            lblDenegadas.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblDenegadas.ForeColor = Color.Snow;
            lblDenegadas.Location = new Point(64, 72);
            lblDenegadas.Name = "lblDenegadas";
            lblDenegadas.Size = new Size(352, 29);
            lblDenegadas.TabIndex = 50;
            lblDenegadas.Text = "0";
            lblDenegadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAceptadas
            // 
            lblAceptadas.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblAceptadas.ForeColor = Color.Snow;
            lblAceptadas.Location = new Point(64, 72);
            lblAceptadas.Name = "lblAceptadas";
            lblAceptadas.Size = new Size(352, 29);
            lblAceptadas.TabIndex = 49;
            lblAceptadas.Text = "0";
            lblAceptadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14F);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(96, 32);
            label9.Name = "label9";
            label9.Size = new Size(318, 30);
            label9.TabIndex = 48;
            label9.Text = "Postulaciones pendientes";
            // 
            // lblPendientes
            // 
            lblPendientes.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            lblPendientes.ForeColor = Color.Snow;
            lblPendientes.Location = new Point(64, 72);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(352, 29);
            lblPendientes.TabIndex = 47;
            lblPendientes.Text = "0";
            lblPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkCyan;
            panel7.Controls.Add(label7);
            panel7.Controls.Add(lblAceptadas);
            panel7.Location = new Point(1088, 496);
            panel7.Name = "panel7";
            panel7.Size = new Size(488, 128);
            panel7.TabIndex = 53;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Teal;
            panel8.Controls.Add(label8);
            panel8.Controls.Add(lblDenegadas);
            panel8.Location = new Point(1088, 648);
            panel8.Name = "panel8";
            panel8.Size = new Size(488, 128);
            panel8.TabIndex = 54;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkSlateGray;
            panel9.Controls.Add(label9);
            panel9.Controls.Add(lblPendientes);
            panel9.Location = new Point(1088, 800);
            panel9.Name = "panel9";
            panel9.Size = new Size(488, 128);
            panel9.TabIndex = 55;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.MediumTurquoise;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Snow;
            btnEditar.Location = new Point(864, 160);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(184, 56);
            btnEditar.TabIndex = 56;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1619, 993);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(dgvPostulaciones);
            Controls.Add(inv_tl_Bg);
            Controls.Add(label4);
            Controls.Add(dgvPuestos);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombrePuesto);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrarPuesto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPerfil";
            Text = "Perfil";
            Load += FormPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            inv_tl_Bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombrePuesto;
        private TextBox txtCategoria;
        private TextBox txtDescripcion;
        private DataGridView dgvPuestos;
        private Label label4;
        private Panel inv_tl_Bg;
        private Label tituloLbl;
        private DataGridView dgvPostulaciones;
        private Button btnRegistrarPuesto;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem reiniciaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem reiniciarTablaToolStripMenuItem;
        private ToolStripMenuItem eliminarPuestoToolStripMenuItem;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private Label lblTotalPostulaciones;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label lblLugarMasPostulado;
        private Panel panel5;
        private Label label6;
        private Label lblAgrupacionMasPostulada;
        private Panel panel6;
        private Label label8;
        private Label label7;
        private Label lblDenegadas;
        private Label lblAceptadas;
        private Label label9;
        private Label lblPendientes;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private ToolStripMenuItem editarPuestoToolStripMenuItem;
        private Button btnEditar;
    }
}