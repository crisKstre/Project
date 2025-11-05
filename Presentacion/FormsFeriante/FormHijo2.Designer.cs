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
            postularBg = new Panel();
            btnPostular = new Label();
            dgvEventos02 = new DataGridView();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            popmenu1 = new ContextMenuStrip(components);
            reiniciarToolStripMenuItem = new ToolStripMenuItem();
            reiniciarTextosToolStripMenuItem = new ToolStripMenuItem();
            postularBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).BeginInit();
            inv_tl_Bg.SuspendLayout();
            popmenu1.SuspendLayout();
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
            btnPostular.Font = new Font("Leelawadee", 10.2F, FontStyle.Bold);
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
            // dgvEventos02
            // 
            dgvEventos02.AllowUserToAddRows = false;
            dgvEventos02.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos02.Location = new Point(51, 176);
            dgvEventos02.Margin = new Padding(3, 4, 3, 4);
            dgvEventos02.Name = "dgvEventos02";
            dgvEventos02.RowHeadersWidth = 51;
            dgvEventos02.RowTemplate.Height = 24;
            dgvEventos02.Size = new Size(678, 602);
            dgvEventos02.TabIndex = 36;
            dgvEventos02.RowHeaderMouseClick += Tabla_RowHeaderMouseClick;
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
            tituloLbl.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            popmenu1.Items.AddRange(new ToolStripItem[] { reiniciarToolStripMenuItem, reiniciarTextosToolStripMenuItem });
            popmenu1.Name = "popmenu1";
            popmenu1.Size = new Size(182, 52);
            // 
            // reiniciarToolStripMenuItem
            // 
            reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            reiniciarToolStripMenuItem.Size = new Size(181, 24);
            reiniciarToolStripMenuItem.Text = "Reiniciar";
            reiniciarToolStripMenuItem.Click += reiniciarToolStripMenuItem_Click;
            // 
            // reiniciarTextosToolStripMenuItem
            // 
            reiniciarTextosToolStripMenuItem.Name = "reiniciarTextosToolStripMenuItem";
            reiniciarTextosToolStripMenuItem.Size = new Size(181, 24);
            reiniciarTextosToolStripMenuItem.Text = "Reiniciar Textos";
            reiniciarTextosToolStripMenuItem.Click += reiniciarTextosToolStripMenuItem_Click;
            // 
            // FormHijo2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 799);
            ContextMenuStrip = popmenu1;
            Controls.Add(postularBg);
            Controls.Add(dgvEventos02);
            Controls.Add(inv_tl_Bg);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHijo2";
            Text = "Eventos";
            Load += FormHijo2_Load;
            postularBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).EndInit();
            inv_tl_Bg.ResumeLayout(false);
            popmenu1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel postularBg;
        private System.Windows.Forms.Label btnPostular;
        private System.Windows.Forms.DataGridView dgvEventos02;
        private System.Windows.Forms.Panel inv_tl_Bg;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.ContextMenuStrip popmenu1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarTextosToolStripMenuItem;
    }
}