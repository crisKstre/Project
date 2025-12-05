namespace Tienda.Forms
{
    partial class FormHijo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHijo2));
            postularBg = new Panel();
            btnPostular = new Label();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            popmenu1 = new ContextMenuStrip(components);
            reiniciarToolStripMenuItem = new ToolStripMenuItem();
            dgvEventos02 = new DataGridView();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            txtNombreEvento = new TextBox();
            panel1 = new Panel();
            txtNombreAgrupacion = new TextBox();
            btnBuscar = new Button();
            postularBg.SuspendLayout();
            inv_tl_Bg.SuspendLayout();
            popmenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).BeginInit();
            SuspendLayout();
            // 
            // postularBg
            // 
            postularBg.BackColor = Color.MediumTurquoise;
            postularBg.Controls.Add(btnPostular);
            postularBg.Location = new Point(1328, 120);
            postularBg.Margin = new Padding(3, 4, 3, 4);
            postularBg.Name = "postularBg";
            postularBg.Size = new Size(196, 64);
            postularBg.TabIndex = 40;
            // 
            // btnPostular
            // 
            btnPostular.BackColor = Color.DarkTurquoise;
            btnPostular.Cursor = Cursors.Hand;
            btnPostular.Dock = DockStyle.Fill;
            btnPostular.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostular.ForeColor = Color.Snow;
            btnPostular.Location = new Point(0, 0);
            btnPostular.Name = "btnPostular";
            btnPostular.Size = new Size(196, 64);
            btnPostular.TabIndex = 0;
            btnPostular.Text = "Postular";
            btnPostular.TextAlign = ContentAlignment.MiddleCenter;
            btnPostular.Click += btnPostular_Click;
            btnPostular.MouseClick += filtrarBtn_MouseClick;
            btnPostular.MouseEnter += filtrarBtn_MouseEnter;
            btnPostular.MouseLeave += filtrarBtn_MouseLeave;
            // 
            // inv_tl_Bg
            // 
            inv_tl_Bg.BackColor = Color.MediumTurquoise;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(16, 16);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(392, 56);
            inv_tl_Bg.TabIndex = 21;
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
            // popmenu1
            // 
            popmenu1.ImageScalingSize = new Size(20, 20);
            popmenu1.Items.AddRange(new ToolStripItem[] { reiniciarToolStripMenuItem });
            popmenu1.Name = "popmenu1";
            popmenu1.Size = new Size(136, 28);
            // 
            // reiniciarToolStripMenuItem
            // 
            reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            reiniciarToolStripMenuItem.Size = new Size(135, 24);
            reiniciarToolStripMenuItem.Text = "Reiniciar";
            reiniciarToolStripMenuItem.Click += reiniciarToolStripMenuItem_Click;
            // 
            // dgvEventos02
            // 
            dgvEventos02.AllowUserToAddRows = false;
            dgvEventos02.AllowUserToDeleteRows = false;
            dgvEventos02.AllowUserToOrderColumns = true;
            dgvEventos02.AllowUserToResizeColumns = false;
            dgvEventos02.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEventos02.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEventos02.BackgroundColor = Color.LightCyan;
            dgvEventos02.BorderStyle = BorderStyle.None;
            dgvEventos02.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEventos02.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEventos02.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEventos02.ColumnHeadersHeight = 56;
            dgvEventos02.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCyan;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEventos02.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEventos02.EnableHeadersVisualStyles = false;
            dgvEventos02.GridColor = Color.Teal;
            dgvEventos02.Location = new Point(48, 224);
            dgvEventos02.Name = "dgvEventos02";
            dgvEventos02.ReadOnly = true;
            dgvEventos02.RowHeadersVisible = false;
            dgvEventos02.RowHeadersWidth = 51;
            dgvEventos02.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos02.Size = new Size(1488, 704);
            dgvEventos02.TabIndex = 41;
            dgvEventos02.RowHeaderMouseClick += Tabla_RowHeaderMouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(56, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 1);
            panel2.TabIndex = 43;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.BackColor = Color.LightCyan;
            txtNombreEvento.BorderStyle = BorderStyle.None;
            txtNombreEvento.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEvento.Location = new Point(64, 136);
            txtNombreEvento.Multiline = true;
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.PlaceholderText = "Nombre del evento";
            txtNombreEvento.Size = new Size(240, 32);
            txtNombreEvento.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(352, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 1);
            panel1.TabIndex = 45;
            // 
            // txtNombreAgrupacion
            // 
            txtNombreAgrupacion.BackColor = Color.LightCyan;
            txtNombreAgrupacion.BorderStyle = BorderStyle.None;
            txtNombreAgrupacion.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreAgrupacion.Location = new Point(360, 136);
            txtNombreAgrupacion.Multiline = true;
            txtNombreAgrupacion.Name = "txtNombreAgrupacion";
            txtNombreAgrupacion.PlaceholderText = "Nombre agrupación";
            txtNombreAgrupacion.Size = new Size(248, 32);
            txtNombreAgrupacion.TabIndex = 44;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkTurquoise;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(648, 120);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(196, 64);
            btnBuscar.TabIndex = 57;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormHijo2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1619, 993);
            ContextMenuStrip = popmenu1;
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(txtNombreAgrupacion);
            Controls.Add(panel2);
            Controls.Add(txtNombreEvento);
            Controls.Add(dgvEventos02);
            Controls.Add(postularBg);
            Controls.Add(inv_tl_Bg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHijo2";
            Text = "Eventos";
            Load += FormHijo2_Load;
            postularBg.ResumeLayout(false);
            inv_tl_Bg.ResumeLayout(false);
            popmenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel postularBg;
        private System.Windows.Forms.Label btnPostular;
        private System.Windows.Forms.Panel inv_tl_Bg;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.ContextMenuStrip popmenu1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private DataGridView dgvEventos02;
        private ToolTip toolTip1;
        private Panel panel2;
        private TextBox txtNombreEvento;
        private Panel panel1;
        private TextBox txtNombreAgrupacion;
        private Button btnBuscar;
    }
}