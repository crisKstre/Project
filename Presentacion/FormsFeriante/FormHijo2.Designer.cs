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
            postularBg.SuspendLayout();
            inv_tl_Bg.SuspendLayout();
            popmenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).BeginInit();
            SuspendLayout();
            // 
            // postularBg
            // 
            postularBg.BackColor = Color.LightSalmon;
            postularBg.Controls.Add(btnPostular);
            postularBg.Location = new Point(560, 88);
            postularBg.Margin = new Padding(3, 4, 3, 4);
            postularBg.Name = "postularBg";
            postularBg.Size = new Size(172, 48);
            postularBg.TabIndex = 40;
            // 
            // btnPostular
            // 
            btnPostular.Cursor = Cursors.Hand;
            btnPostular.Dock = DockStyle.Fill;
            btnPostular.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostular.Location = new Point(0, 0);
            btnPostular.Name = "btnPostular";
            btnPostular.Size = new Size(172, 48);
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
            inv_tl_Bg.BackColor = Color.Salmon;
            inv_tl_Bg.Controls.Add(tituloLbl);
            inv_tl_Bg.Location = new Point(12, 15);
            inv_tl_Bg.Margin = new Padding(3, 4, 3, 4);
            inv_tl_Bg.Name = "inv_tl_Bg";
            inv_tl_Bg.Size = new Size(293, 42);
            inv_tl_Bg.TabIndex = 21;
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
            dgvEventos02.AllowUserToResizeColumns = false;
            dgvEventos02.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEventos02.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEventos02.BackgroundColor = Color.White;
            dgvEventos02.BorderStyle = BorderStyle.None;
            dgvEventos02.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEventos02.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEventos02.ColumnHeadersHeight = 48;
            dgvEventos02.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEventos02.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEventos02.EnableHeadersVisualStyles = false;
            dgvEventos02.GridColor = SystemColors.ControlDark;
            dgvEventos02.Location = new Point(17, 176);
            dgvEventos02.Name = "dgvEventos02";
            dgvEventos02.RowHeadersVisible = false;
            dgvEventos02.RowHeadersWidth = 51;
            dgvEventos02.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos02.Size = new Size(736, 520);
            dgvEventos02.TabIndex = 41;
            dgvEventos02.RowHeaderMouseClick += Tabla_RowHeaderMouseClick;
            // 
            // FormHijo2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 799);
            ContextMenuStrip = popmenu1;
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

        }

        #endregion

        private System.Windows.Forms.Panel postularBg;
        private System.Windows.Forms.Label btnPostular;
        private System.Windows.Forms.Panel inv_tl_Bg;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.ContextMenuStrip popmenu1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private DataGridView dgvEventos02;
    }
}