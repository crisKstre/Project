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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilAgrupacion));
            label1 = new Label();
            label2 = new Label();
            dgvMisEventos = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            editarEventoToolStripMenuItem = new ToolStripMenuItem();
            eliminarEventoToolStripMenuItem = new ToolStripMenuItem();
            reiniciarTablaToolStripMenuItem = new ToolStripMenuItem();
            dgvPostulaciones = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            reiniciarTablasToolStripMenuItem = new ToolStripMenuItem();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            panel9 = new Panel();
            label9 = new Label();
            lblPendientes = new Label();
            panel8 = new Panel();
            label8 = new Label();
            lblDenegadas = new Label();
            panel7 = new Panel();
            label7 = new Label();
            lblAceptadas = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblLugarMasPostulado = new Label();
            panel1 = new Panel();
            label4 = new Label();
            lblTotalPostulaciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMisEventos).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).BeginInit();
            contextMenuStrip1.SuspendLayout();
            inv_tl_Bg.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(64, 112);
            label1.Name = "label1";
            label1.Size = new Size(327, 27);
            label1.TabIndex = 24;
            label1.Text = "Postulaciones a mis eventos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label2.Location = new Point(64, 464);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 26;
            label2.Text = "Mis eventos";
            // 
            // dgvMisEventos
            // 
            dgvMisEventos.AllowUserToAddRows = false;
            dgvMisEventos.AllowUserToDeleteRows = false;
            dgvMisEventos.AllowUserToOrderColumns = true;
            dgvMisEventos.AllowUserToResizeColumns = false;
            dgvMisEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMisEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMisEventos.BackgroundColor = Color.LightCyan;
            dgvMisEventos.BorderStyle = BorderStyle.None;
            dgvMisEventos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMisEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMisEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMisEventos.ColumnHeadersHeight = 51;
            dgvMisEventos.ContextMenuStrip = contextMenuStrip2;
            dgvMisEventos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCyan;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMisEventos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMisEventos.EnableHeadersVisualStyles = false;
            dgvMisEventos.GridColor = Color.CadetBlue;
            dgvMisEventos.Location = new Point(56, 496);
            dgvMisEventos.Name = "dgvMisEventos";
            dgvMisEventos.ReadOnly = true;
            dgvMisEventos.RowHeadersVisible = false;
            dgvMisEventos.RowHeadersWidth = 51;
            dgvMisEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMisEventos.Size = new Size(920, 440);
            dgvMisEventos.TabIndex = 27;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { editarEventoToolStripMenuItem, eliminarEventoToolStripMenuItem, reiniciarTablaToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(191, 76);
            // 
            // editarEventoToolStripMenuItem
            // 
            editarEventoToolStripMenuItem.Name = "editarEventoToolStripMenuItem";
            editarEventoToolStripMenuItem.Size = new Size(190, 24);
            editarEventoToolStripMenuItem.Text = "Editar evento";
            editarEventoToolStripMenuItem.Click += editarEventoToolStripMenuItem_Click;
            // 
            // eliminarEventoToolStripMenuItem
            // 
            eliminarEventoToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eliminarEventoToolStripMenuItem.Name = "eliminarEventoToolStripMenuItem";
            eliminarEventoToolStripMenuItem.Size = new Size(190, 24);
            eliminarEventoToolStripMenuItem.Text = "Eliminar evento";
            eliminarEventoToolStripMenuItem.Click += eliminarEventoToolStripMenuItem_Click;
            // 
            // reiniciarTablaToolStripMenuItem
            // 
            reiniciarTablaToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reiniciarTablaToolStripMenuItem.Name = "reiniciarTablaToolStripMenuItem";
            reiniciarTablaToolStripMenuItem.Size = new Size(190, 24);
            reiniciarTablaToolStripMenuItem.Text = "Reiniciar tabla";
            reiniciarTablaToolStripMenuItem.Click += reiniciarTablaToolStripMenuItem_Click;
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
            dataGridViewCellStyle3.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPostulaciones.ColumnHeadersHeight = 51;
            dgvPostulaciones.ContextMenuStrip = contextMenuStrip1;
            dgvPostulaciones.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightCyan;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPostulaciones.EnableHeadersVisualStyles = false;
            dgvPostulaciones.GridColor = Color.MediumTurquoise;
            dgvPostulaciones.Location = new Point(56, 144);
            dgvPostulaciones.Name = "dgvPostulaciones";
            dgvPostulaciones.ReadOnly = true;
            dgvPostulaciones.RowHeadersVisible = false;
            dgvPostulaciones.RowHeadersWidth = 51;
            dgvPostulaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPostulaciones.Size = new Size(920, 280);
            dgvPostulaciones.TabIndex = 28;
            dgvPostulaciones.CellContentClick += dgvPostulaciones_CellContentClick_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { reiniciarTablasToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(189, 28);
            // 
            // reiniciarTablasToolStripMenuItem
            // 
            reiniciarTablasToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reiniciarTablasToolStripMenuItem.Name = "reiniciarTablasToolStripMenuItem";
            reiniciarTablasToolStripMenuItem.Size = new Size(188, 24);
            reiniciarTablasToolStripMenuItem.Text = "Reiniciar Tablas";
            reiniciarTablasToolStripMenuItem.Click += reiniciarTablasToolStripMenuItem_Click;
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.MediumTurquoise;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(16, 16);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(392, 56);
            inv_tl_Bg.TabIndex = 29;
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
            // panel9
            // 
            panel9.BackColor = Color.DarkSlateGray;
            panel9.Controls.Add(label9);
            panel9.Controls.Add(lblPendientes);
            panel9.Location = new Point(1048, 728);
            panel9.Name = "panel9";
            panel9.Size = new Size(488, 128);
            panel9.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(96, 32);
            label9.Name = "label9";
            label9.Size = new Size(302, 27);
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
            // panel8
            // 
            panel8.BackColor = Color.DarkCyan;
            panel8.Controls.Add(label8);
            panel8.Controls.Add(lblDenegadas);
            panel8.Location = new Point(1048, 576);
            panel8.Name = "panel8";
            panel8.Size = new Size(488, 128);
            panel8.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(96, 32);
            label8.Name = "label8";
            label8.Size = new Size(306, 27);
            label8.TabIndex = 52;
            label8.Text = "Postulaciones denegadas";
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
            // panel7
            // 
            panel7.BackColor = Color.LightSeaGreen;
            panel7.Controls.Add(label7);
            panel7.Controls.Add(lblAceptadas);
            panel7.Location = new Point(1048, 424);
            panel7.Name = "panel7";
            panel7.Size = new Size(488, 128);
            panel7.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(96, 32);
            label7.Name = "label7";
            label7.Size = new Size(301, 27);
            label7.TabIndex = 51;
            label7.Text = "Postulaciones aceptadas";
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
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblLugarMasPostulado);
            panel5.Location = new Point(1048, 272);
            panel5.Name = "panel5";
            panel5.Size = new Size(488, 128);
            panel5.TabIndex = 57;
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
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblTotalPostulaciones);
            panel1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Snow;
            panel1.Location = new Point(1048, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 128);
            panel1.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(96, 32);
            label4.Name = "label4";
            label4.Size = new Size(303, 27);
            label4.TabIndex = 6;
            label4.Text = "Número de postulaciones";
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
            // FormPerfilAgrupacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1619, 993);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(inv_tl_Bg);
            Controls.Add(dgvPostulaciones);
            Controls.Add(dgvMisEventos);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPerfilAgrupacion";
            Text = "Perfil";
            Load += FormPerfilAgrupacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMisEventos).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            inv_tl_Bg.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView dgvMisEventos;
        private DataGridView dgvPostulaciones;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem reiniciarTablasToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem reiniciarTablaToolStripMenuItem;
        private ToolStripMenuItem eliminarEventoToolStripMenuItem;
        private Panel inv_tl_Bg;
        private Label tituloLbl;
        private Panel panel9;
        private Label label9;
        private Label lblPendientes;
        private Panel panel8;
        private Label label8;
        private Label lblDenegadas;
        private Panel panel7;
        private Label label7;
        private Label lblAceptadas;
        private Panel panel5;
        private Label label3;
        private Label lblLugarMasPostulado;
        private Panel panel1;
        private Label label4;
        private Label lblTotalPostulaciones;
        private ToolStripMenuItem editarEventoToolStripMenuItem;
    }
}