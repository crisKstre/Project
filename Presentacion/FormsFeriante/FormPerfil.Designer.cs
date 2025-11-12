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
            label1 = new Label();
            txtNombrePuesto = new TextBox();
            txtCategoria = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            dgvPuestos = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            reiniciarTablaToolStripMenuItem = new ToolStripMenuItem();
            eliminarPuestoToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            reiniciaToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            dgvPostulaciones = new DataGridView();
            btnRegistrarPuesto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            inv_tl_Bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre puesto";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePuesto.Location = new Point(40, 152);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(160, 26);
            txtNombrePuesto.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(240, 152);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(160, 26);
            txtCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(448, 152);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(160, 26);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(448, 120);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // dgvPuestos
            // 
            dgvPuestos.AllowUserToAddRows = false;
            dgvPuestos.AllowUserToDeleteRows = false;
            dgvPuestos.AllowUserToResizeColumns = false;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPuestos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPuestos.BackgroundColor = Color.White;
            dgvPuestos.BorderStyle = BorderStyle.None;
            dgvPuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuestos.ColumnHeadersHeight = 48;
            dgvPuestos.ContextMenuStrip = contextMenuStrip2;
            dgvPuestos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPuestos.EnableHeadersVisualStyles = false;
            dgvPuestos.GridColor = SystemColors.ControlDark;
            dgvPuestos.Location = new Point(48, 224);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersVisible = false;
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.Size = new Size(736, 192);
            dgvPuestos.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { reiniciarTablaToolStripMenuItem, eliminarPuestoToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(186, 52);
            // 
            // reiniciarTablaToolStripMenuItem
            // 
            reiniciarTablaToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reiniciarTablaToolStripMenuItem.Name = "reiniciarTablaToolStripMenuItem";
            reiniciarTablaToolStripMenuItem.Size = new Size(185, 24);
            reiniciarTablaToolStripMenuItem.Text = "Reiniciar Tabla";
            reiniciarTablaToolStripMenuItem.Click += reiniciarTablaToolStripMenuItem_Click;
            // 
            // eliminarPuestoToolStripMenuItem
            // 
            eliminarPuestoToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eliminarPuestoToolStripMenuItem.Name = "eliminarPuestoToolStripMenuItem";
            eliminarPuestoToolStripMenuItem.Size = new Size(185, 24);
            eliminarPuestoToolStripMenuItem.Text = "Eliminar Puesto";
            eliminarPuestoToolStripMenuItem.Click += eliminarPuestoToolStripMenuItem_Click;
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
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 448);
            label4.Name = "label4";
            label4.Size = new Size(191, 21);
            label4.TabIndex = 8;
            label4.Text = "Historial Postulaciones";
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.Salmon;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(8, 8);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(293, 42);
            inv_tl_Bg.TabIndex = 22;
            // 
            // tituloLbl
            // 
            tituloLbl.BackColor = Color.LightSalmon;
            tituloLbl.Dock = DockStyle.Fill;
            tituloLbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloLbl.Location = new Point(0, 0);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(293, 42);
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
            dgvPostulaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPostulaciones.ContextMenuStrip = contextMenuStrip1;
            dgvPostulaciones.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPostulaciones.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPostulaciones.EnableHeadersVisualStyles = false;
            dgvPostulaciones.GridColor = SystemColors.ControlDark;
            dgvPostulaciones.Location = new Point(48, 480);
            dgvPostulaciones.Name = "dgvPostulaciones";
            dgvPostulaciones.RowHeadersVisible = false;
            dgvPostulaciones.RowHeadersWidth = 51;
            dgvPostulaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPostulaciones.Size = new Size(728, 280);
            dgvPostulaciones.TabIndex = 7;
            // 
            // btnRegistrarPuesto
            // 
            btnRegistrarPuesto.BackColor = Color.Salmon;
            btnRegistrarPuesto.Cursor = Cursors.Hand;
            btnRegistrarPuesto.FlatAppearance.BorderSize = 0;
            btnRegistrarPuesto.FlatStyle = FlatStyle.Flat;
            btnRegistrarPuesto.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPuesto.ForeColor = Color.Black;
            btnRegistrarPuesto.Location = new Point(640, 136);
            btnRegistrarPuesto.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarPuesto.Name = "btnRegistrarPuesto";
            btnRegistrarPuesto.Size = new Size(170, 51);
            btnRegistrarPuesto.TabIndex = 23;
            btnRegistrarPuesto.Text = "Registrar Puesto";
            btnRegistrarPuesto.UseVisualStyleBackColor = false;
            btnRegistrarPuesto.Click += btnRegistrarPuesto_Click;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(833, 799);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnRegistrarPuesto);
            Controls.Add(dgvPostulaciones);
            Controls.Add(inv_tl_Bg);
            Controls.Add(label4);
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
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            inv_tl_Bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPostulaciones).EndInit();
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
    }
}