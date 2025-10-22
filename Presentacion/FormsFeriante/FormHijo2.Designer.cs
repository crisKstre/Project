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
            filtrarBg = new Panel();
            filtrarBtn = new Label();
            modificarBg = new Panel();
            modificarBtn = new Label();
            eliminarBg = new Panel();
            eliminarBtn = new Label();
            agregarBg = new Panel();
            agregarBtn = new Label();
            dgvEventos02 = new DataGridView();
            stockTxt = new TextBox();
            precioTxt = new TextBox();
            matCbx = new ComboBox();
            tallaCbx = new ComboBox();
            stockLbl = new Label();
            precioLbl = new Label();
            materialLbl = new Label();
            tallaLbl = new Label();
            marcaTxt = new TextBox();
            nombreTxt = new TextBox();
            codigoTxt = new TextBox();
            marcaLbl = new Label();
            nombreLbl = new Label();
            codigoLbl = new Label();
            inv_tl_Bg = new Panel();
            tituloLbl = new Label();
            popmenu1 = new ContextMenuStrip(components);
            reiniciarToolStripMenuItem = new ToolStripMenuItem();
            reiniciarTextosToolStripMenuItem = new ToolStripMenuItem();
            verBDBg = new Panel();
            verBDBtn = new Label();
            filtrarBg.SuspendLayout();
            modificarBg.SuspendLayout();
            eliminarBg.SuspendLayout();
            agregarBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).BeginInit();
            inv_tl_Bg.SuspendLayout();
            popmenu1.SuspendLayout();
            verBDBg.SuspendLayout();
            SuspendLayout();
            // 
            // filtrarBg
            // 
            filtrarBg.BackColor = Color.LightSalmon;
            filtrarBg.Controls.Add(filtrarBtn);
            filtrarBg.Location = new Point(309, 412);
            filtrarBg.Margin = new Padding(3, 4, 3, 4);
            filtrarBg.Name = "filtrarBg";
            filtrarBg.Size = new Size(172, 48);
            filtrarBg.TabIndex = 40;
            // 
            // filtrarBtn
            // 
            filtrarBtn.Cursor = Cursors.Hand;
            filtrarBtn.Dock = DockStyle.Fill;
            filtrarBtn.Font = new Font("Leelawadee", 10.2F, FontStyle.Bold);
            filtrarBtn.Location = new Point(0, 0);
            filtrarBtn.Name = "filtrarBtn";
            filtrarBtn.Size = new Size(172, 48);
            filtrarBtn.TabIndex = 0;
            filtrarBtn.Text = "Filtrar";
            filtrarBtn.TextAlign = ContentAlignment.MiddleCenter;
            filtrarBtn.MouseClick += filtrarBtn_MouseClick;
            filtrarBtn.MouseEnter += filtrarBtn_MouseEnter;
            filtrarBtn.MouseLeave += filtrarBtn_MouseLeave;
            // 
            // modificarBg
            // 
            modificarBg.BackColor = Color.LightSalmon;
            modificarBg.Controls.Add(modificarBtn);
            modificarBg.Location = new Point(530, 328);
            modificarBg.Margin = new Padding(3, 4, 3, 4);
            modificarBg.Name = "modificarBg";
            modificarBg.Size = new Size(172, 48);
            modificarBg.TabIndex = 39;
            // 
            // modificarBtn
            // 
            modificarBtn.Cursor = Cursors.Hand;
            modificarBtn.Dock = DockStyle.Fill;
            modificarBtn.Font = new Font("Leelawadee", 10.2F, FontStyle.Bold);
            modificarBtn.Location = new Point(0, 0);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(172, 48);
            modificarBtn.TabIndex = 0;
            modificarBtn.Text = "Modificar";
            modificarBtn.TextAlign = ContentAlignment.MiddleCenter;
            modificarBtn.MouseClick += modificarBtn_MouseClick;
            modificarBtn.MouseEnter += modificarBtn_MouseEnter;
            modificarBtn.MouseLeave += modificarBtn_MouseLeave;
            // 
            // eliminarBg
            // 
            eliminarBg.BackColor = Color.LightSalmon;
            eliminarBg.Controls.Add(eliminarBtn);
            eliminarBg.Location = new Point(309, 328);
            eliminarBg.Margin = new Padding(3, 4, 3, 4);
            eliminarBg.Name = "eliminarBg";
            eliminarBg.Size = new Size(172, 48);
            eliminarBg.TabIndex = 38;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Cursor = Cursors.Hand;
            eliminarBtn.Dock = DockStyle.Fill;
            eliminarBtn.Font = new Font("Leelawadee", 10.2F, FontStyle.Bold);
            eliminarBtn.Location = new Point(0, 0);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(172, 48);
            eliminarBtn.TabIndex = 0;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.TextAlign = ContentAlignment.MiddleCenter;
            eliminarBtn.MouseClick += eliminarBtn_MouseClick;
            eliminarBtn.MouseEnter += eliminarBtn_MouseEnter;
            eliminarBtn.MouseLeave += eliminarBtn_MouseLeave;
            // 
            // agregarBg
            // 
            agregarBg.BackColor = Color.LightSalmon;
            agregarBg.Controls.Add(agregarBtn);
            agregarBg.Location = new Point(84, 328);
            agregarBg.Margin = new Padding(3, 4, 3, 4);
            agregarBg.Name = "agregarBg";
            agregarBg.Size = new Size(172, 48);
            agregarBg.TabIndex = 37;
            // 
            // agregarBtn
            // 
            agregarBtn.Cursor = Cursors.Hand;
            agregarBtn.Dock = DockStyle.Fill;
            agregarBtn.Font = new Font("Leelawadee", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarBtn.Location = new Point(0, 0);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(172, 48);
            agregarBtn.TabIndex = 0;
            agregarBtn.Text = "Añadir";
            agregarBtn.TextAlign = ContentAlignment.MiddleCenter;
            agregarBtn.MouseClick += agregarBtn_MouseClick;
            agregarBtn.MouseEnter += agregarBtn_MouseEnter;
            agregarBtn.MouseLeave += agregarBtn_MouseLeave;
            // 
            // dgvEventos02
            // 
            dgvEventos02.AllowUserToAddRows = false;
            dgvEventos02.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos02.Location = new Point(51, 494);
            dgvEventos02.Margin = new Padding(3, 4, 3, 4);
            dgvEventos02.Name = "dgvEventos02";
            dgvEventos02.RowHeadersWidth = 51;
            dgvEventos02.RowTemplate.Height = 24;
            dgvEventos02.Size = new Size(678, 284);
            dgvEventos02.TabIndex = 36;
            dgvEventos02.RowHeaderMouseClick += Tabla_RowHeaderMouseClick;
            // 
            // stockTxt
            // 
            stockTxt.Location = new Point(602, 240);
            stockTxt.Margin = new Padding(3, 4, 3, 4);
            stockTxt.Name = "stockTxt";
            stockTxt.Size = new Size(100, 27);
            stockTxt.TabIndex = 35;
            stockTxt.KeyPress += stockTxt_KeyPress;
            // 
            // precioTxt
            // 
            precioTxt.Location = new Point(428, 240);
            precioTxt.Margin = new Padding(3, 4, 3, 4);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(115, 27);
            precioTxt.TabIndex = 34;
            precioTxt.KeyPress += precioTxt_KeyPress;
            // 
            // matCbx
            // 
            matCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            matCbx.FormattingEnabled = true;
            matCbx.Items.AddRange(new object[] { "Poliester", "Algodon", "Lino", "Seda", "Lana" });
            matCbx.Location = new Point(243, 238);
            matCbx.Margin = new Padding(3, 4, 3, 4);
            matCbx.Name = "matCbx";
            matCbx.Size = new Size(94, 28);
            matCbx.TabIndex = 33;
            // 
            // tallaCbx
            // 
            tallaCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            tallaCbx.FormattingEnabled = true;
            tallaCbx.Items.AddRange(new object[] { "XXL", "XL", "L", "M", "S", "XS", "XXS" });
            tallaCbx.Location = new Point(84, 238);
            tallaCbx.Margin = new Padding(3, 4, 3, 4);
            tallaCbx.Name = "tallaCbx";
            tallaCbx.Size = new Size(61, 28);
            tallaCbx.TabIndex = 32;
            // 
            // stockLbl
            // 
            stockLbl.AutoSize = true;
            stockLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold);
            stockLbl.Location = new Point(599, 202);
            stockLbl.Name = "stockLbl";
            stockLbl.Size = new Size(46, 18);
            stockLbl.TabIndex = 31;
            stockLbl.Text = "Stock";
            // 
            // precioLbl
            // 
            precioLbl.AutoSize = true;
            precioLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold);
            precioLbl.Location = new Point(425, 202);
            precioLbl.Name = "precioLbl";
            precioLbl.Size = new Size(52, 18);
            precioLbl.TabIndex = 30;
            precioLbl.Text = "Precio";
            // 
            // materialLbl
            // 
            materialLbl.AutoSize = true;
            materialLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold);
            materialLbl.Location = new Point(240, 202);
            materialLbl.Name = "materialLbl";
            materialLbl.Size = new Size(67, 18);
            materialLbl.TabIndex = 29;
            materialLbl.Text = "Material";
            // 
            // tallaLbl
            // 
            tallaLbl.AutoSize = true;
            tallaLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold);
            tallaLbl.Location = new Point(81, 202);
            tallaLbl.Name = "tallaLbl";
            tallaLbl.Size = new Size(43, 18);
            tallaLbl.TabIndex = 28;
            tallaLbl.Text = "Talla";
            // 
            // marcaTxt
            // 
            marcaTxt.Location = new Point(555, 134);
            marcaTxt.Margin = new Padding(3, 4, 3, 4);
            marcaTxt.Name = "marcaTxt";
            marcaTxt.Size = new Size(147, 27);
            marcaTxt.TabIndex = 27;
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(318, 134);
            nombreTxt.Margin = new Padding(3, 4, 3, 4);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(145, 27);
            nombreTxt.TabIndex = 26;
            // 
            // codigoTxt
            // 
            codigoTxt.Location = new Point(84, 134);
            codigoTxt.Margin = new Padding(3, 4, 3, 4);
            codigoTxt.Name = "codigoTxt";
            codigoTxt.Size = new Size(134, 27);
            codigoTxt.TabIndex = 25;
            codigoTxt.KeyPress += codigoTxt_KeyPress;
            // 
            // marcaLbl
            // 
            marcaLbl.AutoSize = true;
            marcaLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold);
            marcaLbl.Location = new Point(552, 98);
            marcaLbl.Name = "marcaLbl";
            marcaLbl.Size = new Size(50, 18);
            marcaLbl.TabIndex = 24;
            marcaLbl.Text = "Marca";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold);
            nombreLbl.Location = new Point(315, 98);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(66, 18);
            nombreLbl.TabIndex = 23;
            nombreLbl.Text = "Nombre";
            // 
            // codigoLbl
            // 
            codigoLbl.AutoSize = true;
            codigoLbl.Font = new Font("Leelawadee", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codigoLbl.Location = new Point(81, 98);
            codigoLbl.Name = "codigoLbl";
            codigoLbl.Size = new Size(58, 18);
            codigoLbl.TabIndex = 22;
            codigoLbl.Text = "Codigo";
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
            tituloLbl.Text = "  Inventario";
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
            // verBDBg
            // 
            verBDBg.BackColor = Color.LightSalmon;
            verBDBg.Controls.Add(verBDBtn);
            verBDBg.Location = new Point(657, 454);
            verBDBg.Margin = new Padding(3, 4, 3, 4);
            verBDBg.Name = "verBDBg";
            verBDBg.Size = new Size(72, 32);
            verBDBg.TabIndex = 42;
            // 
            // verBDBtn
            // 
            verBDBtn.Cursor = Cursors.Hand;
            verBDBtn.Dock = DockStyle.Fill;
            verBDBtn.Font = new Font("Leelawadee", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verBDBtn.Location = new Point(0, 0);
            verBDBtn.Name = "verBDBtn";
            verBDBtn.Size = new Size(72, 32);
            verBDBtn.TabIndex = 0;
            verBDBtn.Text = "ver";
            verBDBtn.TextAlign = ContentAlignment.MiddleCenter;
            verBDBtn.MouseClick += verBDBtn_MouseClick;
            verBDBtn.MouseEnter += verBDBtn_MouseEnter;
            verBDBtn.MouseLeave += verBDBtn_MouseLeave;
            // 
            // FormHijo2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 799);
            ContextMenuStrip = popmenu1;
            Controls.Add(verBDBg);
            Controls.Add(filtrarBg);
            Controls.Add(modificarBg);
            Controls.Add(eliminarBg);
            Controls.Add(agregarBg);
            Controls.Add(dgvEventos02);
            Controls.Add(stockTxt);
            Controls.Add(precioTxt);
            Controls.Add(matCbx);
            Controls.Add(tallaCbx);
            Controls.Add(stockLbl);
            Controls.Add(precioLbl);
            Controls.Add(materialLbl);
            Controls.Add(tallaLbl);
            Controls.Add(marcaTxt);
            Controls.Add(nombreTxt);
            Controls.Add(codigoTxt);
            Controls.Add(marcaLbl);
            Controls.Add(nombreLbl);
            Controls.Add(codigoLbl);
            Controls.Add(inv_tl_Bg);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHijo2";
            Text = "invPnl";
            Load += FormHijo2_Load;
            filtrarBg.ResumeLayout(false);
            modificarBg.ResumeLayout(false);
            eliminarBg.ResumeLayout(false);
            agregarBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos02).EndInit();
            inv_tl_Bg.ResumeLayout(false);
            popmenu1.ResumeLayout(false);
            verBDBg.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel filtrarBg;
        private System.Windows.Forms.Label filtrarBtn;
        private System.Windows.Forms.Panel modificarBg;
        private System.Windows.Forms.Label modificarBtn;
        private System.Windows.Forms.Panel eliminarBg;
        private System.Windows.Forms.Label eliminarBtn;
        private System.Windows.Forms.Panel agregarBg;
        private System.Windows.Forms.Label agregarBtn;
        private System.Windows.Forms.DataGridView dgvEventos02;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.ComboBox matCbx;
        private System.Windows.Forms.ComboBox tallaCbx;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.Label materialLbl;
        private System.Windows.Forms.Label tallaLbl;
        private System.Windows.Forms.TextBox marcaTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.Label marcaLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label codigoLbl;
        private System.Windows.Forms.Panel inv_tl_Bg;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.ContextMenuStrip popmenu1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarTextosToolStripMenuItem;
        private System.Windows.Forms.Panel verBDBg;
        private System.Windows.Forms.Label verBDBtn;
    }
}