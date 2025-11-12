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
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvMisEventos = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            reiniciarTablaToolStripMenuItem = new ToolStripMenuItem();
            eliminarEventoToolStripMenuItem = new ToolStripMenuItem();
            dgvPostulaciones = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            reiniciarTablasToolStripMenuItem = new ToolStripMenuItem();
            inv_tl_Bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMisEventos).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.PaleGreen;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(8, 8);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(293, 42);
            inv_tl_Bg.TabIndex = 23;
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
            tituloLbl.Text = "  Perfil";
            tituloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 440);
            label1.Name = "label1";
            label1.Size = new Size(284, 23);
            label1.TabIndex = 24;
            label1.Text = "Postulaciones a mis eventos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 26;
            label2.Text = "Mis eventos";
            // 
            // dgvMisEventos
            // 
            dgvMisEventos.AllowUserToAddRows = false;
            dgvMisEventos.AllowUserToDeleteRows = false;
            dgvMisEventos.AllowUserToResizeColumns = false;
            dgvMisEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMisEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMisEventos.BackgroundColor = Color.White;
            dgvMisEventos.BorderStyle = BorderStyle.None;
            dgvMisEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMisEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMisEventos.ColumnHeadersHeight = 48;
            dgvMisEventos.ContextMenuStrip = contextMenuStrip2;
            dgvMisEventos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMisEventos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMisEventos.EnableHeadersVisualStyles = false;
            dgvMisEventos.GridColor = SystemColors.ControlDark;
            dgvMisEventos.Location = new Point(32, 120);
            dgvMisEventos.Name = "dgvMisEventos";
            dgvMisEventos.RowHeadersVisible = false;
            dgvMisEventos.RowHeadersWidth = 51;
            dgvMisEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMisEventos.Size = new Size(768, 296);
            dgvMisEventos.TabIndex = 27;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { reiniciarTablaToolStripMenuItem, eliminarEventoToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(211, 80);
            // 
            // reiniciarTablaToolStripMenuItem
            // 
            reiniciarTablaToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reiniciarTablaToolStripMenuItem.Name = "reiniciarTablaToolStripMenuItem";
            reiniciarTablaToolStripMenuItem.Size = new Size(210, 24);
            reiniciarTablaToolStripMenuItem.Text = "Reiniciar tabla";
            reiniciarTablaToolStripMenuItem.Click += reiniciarTablaToolStripMenuItem_Click;
            // 
            // eliminarEventoToolStripMenuItem
            // 
            eliminarEventoToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eliminarEventoToolStripMenuItem.Name = "eliminarEventoToolStripMenuItem";
            eliminarEventoToolStripMenuItem.Size = new Size(210, 24);
            eliminarEventoToolStripMenuItem.Text = "Eliminar evento";
            eliminarEventoToolStripMenuItem.Click += eliminarEventoToolStripMenuItem_Click;
            // 
            // dgvPostulaciones
            // 
            dgvPostulaciones.AllowUserToAddRows = false;
            dgvPostulaciones.AllowUserToDeleteRows = false;
            dgvPostulaciones.AllowUserToResizeColumns = false;
            dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPostulaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPostulaciones.BackgroundColor = Color.White;
            dgvPostulaciones.BorderStyle = BorderStyle.None;
            dgvPostulaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPostulaciones.ColumnHeadersHeight = 48;
            dgvPostulaciones.ContextMenuStrip = contextMenuStrip1;
            dgvPostulaciones.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPostulaciones.EnableHeadersVisualStyles = false;
            dgvPostulaciones.GridColor = SystemColors.ControlDark;
            dgvPostulaciones.Location = new Point(32, 472);
            dgvPostulaciones.Name = "dgvPostulaciones";
            dgvPostulaciones.RowHeadersVisible = false;
            dgvPostulaciones.RowHeadersWidth = 51;
            dgvPostulaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPostulaciones.Size = new Size(768, 280);
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
            // FormPerfilAgrupacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(833, 799);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(dgvPostulaciones);
            Controls.Add(dgvMisEventos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inv_tl_Bg);
            Name = "FormPerfilAgrupacion";
            Text = "Perfil";
            Load += FormPerfilAgrupacion_Load;
            inv_tl_Bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMisEventos).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel inv_tl_Bg;
        private Label tituloLbl;
        private Label label1;
        private Label label2;
        private DataGridView dgvMisEventos;
        private DataGridView dgvPostulaciones;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem reiniciarTablasToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem reiniciarTablaToolStripMenuItem;
        private ToolStripMenuItem eliminarEventoToolStripMenuItem;
    }
}