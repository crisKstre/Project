namespace Tienda.Forms
{
    partial class invPnl
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
            this.components = new System.ComponentModel.Container();
            this.filtrarBg = new System.Windows.Forms.Panel();
            this.filtrarBtn = new System.Windows.Forms.Label();
            this.modificarBg = new System.Windows.Forms.Panel();
            this.modificarBtn = new System.Windows.Forms.Label();
            this.eliminarBg = new System.Windows.Forms.Panel();
            this.eliminarBtn = new System.Windows.Forms.Label();
            this.agregarBg = new System.Windows.Forms.Panel();
            this.agregarBtn = new System.Windows.Forms.Label();
            this.TablaProd = new System.Windows.Forms.DataGridView();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.matCbx = new System.Windows.Forms.ComboBox();
            this.tallaCbx = new System.Windows.Forms.ComboBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.precioLbl = new System.Windows.Forms.Label();
            this.materialLbl = new System.Windows.Forms.Label();
            this.tallaLbl = new System.Windows.Forms.Label();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.marcaLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.codigoLbl = new System.Windows.Forms.Label();
            this.inv_tl_Bg = new System.Windows.Forms.Panel();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.popmenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarTextosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verBDBg = new System.Windows.Forms.Panel();
            this.verBDBtn = new System.Windows.Forms.Label();
            this.filtrarBg.SuspendLayout();
            this.modificarBg.SuspendLayout();
            this.eliminarBg.SuspendLayout();
            this.agregarBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProd)).BeginInit();
            this.inv_tl_Bg.SuspendLayout();
            this.popmenu1.SuspendLayout();
            this.verBDBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtrarBg
            // 
            this.filtrarBg.BackColor = System.Drawing.Color.LightSalmon;
            this.filtrarBg.Controls.Add(this.filtrarBtn);
            this.filtrarBg.Location = new System.Drawing.Point(309, 330);
            this.filtrarBg.Name = "filtrarBg";
            this.filtrarBg.Size = new System.Drawing.Size(172, 38);
            this.filtrarBg.TabIndex = 40;
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtrarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtrarBtn.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold);
            this.filtrarBtn.Location = new System.Drawing.Point(0, 0);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(172, 38);
            this.filtrarBtn.TabIndex = 0;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filtrarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filtrarBtn_MouseClick);
            this.filtrarBtn.MouseEnter += new System.EventHandler(this.filtrarBtn_MouseEnter);
            this.filtrarBtn.MouseLeave += new System.EventHandler(this.filtrarBtn_MouseLeave);
            // 
            // modificarBg
            // 
            this.modificarBg.BackColor = System.Drawing.Color.LightSalmon;
            this.modificarBg.Controls.Add(this.modificarBtn);
            this.modificarBg.Location = new System.Drawing.Point(530, 262);
            this.modificarBg.Name = "modificarBg";
            this.modificarBg.Size = new System.Drawing.Size(172, 38);
            this.modificarBg.TabIndex = 39;
            // 
            // modificarBtn
            // 
            this.modificarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificarBtn.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold);
            this.modificarBtn.Location = new System.Drawing.Point(0, 0);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(172, 38);
            this.modificarBtn.TabIndex = 0;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modificarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modificarBtn_MouseClick);
            this.modificarBtn.MouseEnter += new System.EventHandler(this.modificarBtn_MouseEnter);
            this.modificarBtn.MouseLeave += new System.EventHandler(this.modificarBtn_MouseLeave);
            // 
            // eliminarBg
            // 
            this.eliminarBg.BackColor = System.Drawing.Color.LightSalmon;
            this.eliminarBg.Controls.Add(this.eliminarBtn);
            this.eliminarBg.Location = new System.Drawing.Point(309, 262);
            this.eliminarBg.Name = "eliminarBg";
            this.eliminarBg.Size = new System.Drawing.Size(172, 38);
            this.eliminarBg.TabIndex = 38;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eliminarBtn.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold);
            this.eliminarBtn.Location = new System.Drawing.Point(0, 0);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(172, 38);
            this.eliminarBtn.TabIndex = 0;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eliminarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eliminarBtn_MouseClick);
            this.eliminarBtn.MouseEnter += new System.EventHandler(this.eliminarBtn_MouseEnter);
            this.eliminarBtn.MouseLeave += new System.EventHandler(this.eliminarBtn_MouseLeave);
            // 
            // agregarBg
            // 
            this.agregarBg.BackColor = System.Drawing.Color.LightSalmon;
            this.agregarBg.Controls.Add(this.agregarBtn);
            this.agregarBg.Location = new System.Drawing.Point(84, 262);
            this.agregarBg.Name = "agregarBg";
            this.agregarBg.Size = new System.Drawing.Size(172, 38);
            this.agregarBg.TabIndex = 37;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarBtn.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.Location = new System.Drawing.Point(0, 0);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(172, 38);
            this.agregarBtn.TabIndex = 0;
            this.agregarBtn.Text = "Añadir";
            this.agregarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.agregarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.agregarBtn_MouseClick);
            this.agregarBtn.MouseEnter += new System.EventHandler(this.agregarBtn_MouseEnter);
            this.agregarBtn.MouseLeave += new System.EventHandler(this.agregarBtn_MouseLeave);
            // 
            // TablaProd
            // 
            this.TablaProd.AllowUserToAddRows = false;
            this.TablaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProd.Location = new System.Drawing.Point(51, 395);
            this.TablaProd.Name = "TablaProd";
            this.TablaProd.RowHeadersWidth = 51;
            this.TablaProd.RowTemplate.Height = 24;
            this.TablaProd.Size = new System.Drawing.Size(678, 227);
            this.TablaProd.TabIndex = 36;
            this.TablaProd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tabla_RowHeaderMouseClick);
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(602, 192);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(100, 22);
            this.stockTxt.TabIndex = 35;
            this.stockTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockTxt_KeyPress);
            // 
            // precioTxt
            // 
            this.precioTxt.Location = new System.Drawing.Point(428, 192);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(115, 22);
            this.precioTxt.TabIndex = 34;
            this.precioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTxt_KeyPress);
            // 
            // matCbx
            // 
            this.matCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matCbx.FormattingEnabled = true;
            this.matCbx.Items.AddRange(new object[] {
            "Poliester",
            "Algodon",
            "Lino",
            "Seda",
            "Lana"});
            this.matCbx.Location = new System.Drawing.Point(243, 190);
            this.matCbx.Name = "matCbx";
            this.matCbx.Size = new System.Drawing.Size(94, 24);
            this.matCbx.TabIndex = 33;
            // 
            // tallaCbx
            // 
            this.tallaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tallaCbx.FormattingEnabled = true;
            this.tallaCbx.Items.AddRange(new object[] {
            "XXL",
            "XL",
            "L",
            "M",
            "S",
            "XS",
            "XXS"});
            this.tallaCbx.Location = new System.Drawing.Point(84, 190);
            this.tallaCbx.Name = "tallaCbx";
            this.tallaCbx.Size = new System.Drawing.Size(61, 24);
            this.tallaCbx.TabIndex = 32;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold);
            this.stockLbl.Location = new System.Drawing.Point(599, 162);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(46, 18);
            this.stockLbl.TabIndex = 31;
            this.stockLbl.Text = "Stock";
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold);
            this.precioLbl.Location = new System.Drawing.Point(425, 162);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(52, 18);
            this.precioLbl.TabIndex = 30;
            this.precioLbl.Text = "Precio";
            // 
            // materialLbl
            // 
            this.materialLbl.AutoSize = true;
            this.materialLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold);
            this.materialLbl.Location = new System.Drawing.Point(240, 162);
            this.materialLbl.Name = "materialLbl";
            this.materialLbl.Size = new System.Drawing.Size(67, 18);
            this.materialLbl.TabIndex = 29;
            this.materialLbl.Text = "Material";
            // 
            // tallaLbl
            // 
            this.tallaLbl.AutoSize = true;
            this.tallaLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold);
            this.tallaLbl.Location = new System.Drawing.Point(81, 162);
            this.tallaLbl.Name = "tallaLbl";
            this.tallaLbl.Size = new System.Drawing.Size(43, 18);
            this.tallaLbl.TabIndex = 28;
            this.tallaLbl.Text = "Talla";
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(555, 107);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(147, 22);
            this.marcaTxt.TabIndex = 27;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(318, 107);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(145, 22);
            this.nombreTxt.TabIndex = 26;
            // 
            // codigoTxt
            // 
            this.codigoTxt.Location = new System.Drawing.Point(84, 107);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(134, 22);
            this.codigoTxt.TabIndex = 25;
            this.codigoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoTxt_KeyPress);
            // 
            // marcaLbl
            // 
            this.marcaLbl.AutoSize = true;
            this.marcaLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold);
            this.marcaLbl.Location = new System.Drawing.Point(552, 78);
            this.marcaLbl.Name = "marcaLbl";
            this.marcaLbl.Size = new System.Drawing.Size(50, 18);
            this.marcaLbl.TabIndex = 24;
            this.marcaLbl.Text = "Marca";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold);
            this.nombreLbl.Location = new System.Drawing.Point(315, 78);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(66, 18);
            this.nombreLbl.TabIndex = 23;
            this.nombreLbl.Text = "Nombre";
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLbl.Location = new System.Drawing.Point(81, 78);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(58, 18);
            this.codigoLbl.TabIndex = 22;
            this.codigoLbl.Text = "Codigo";
            // 
            // inv_tl_Bg
            // 
            this.inv_tl_Bg.BackColor = System.Drawing.Color.Salmon;
            this.inv_tl_Bg.Controls.Add(this.tituloLbl);
            this.inv_tl_Bg.Location = new System.Drawing.Point(12, 12);
            this.inv_tl_Bg.Name = "inv_tl_Bg";
            this.inv_tl_Bg.Size = new System.Drawing.Size(293, 34);
            this.inv_tl_Bg.TabIndex = 21;
            // 
            // tituloLbl
            // 
            this.tituloLbl.BackColor = System.Drawing.Color.LightSalmon;
            this.tituloLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloLbl.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(0, 0);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(293, 34);
            this.tituloLbl.TabIndex = 0;
            this.tituloLbl.Text = "  Inventario";
            this.tituloLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // popmenu1
            // 
            this.popmenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popmenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.reiniciarTextosToolStripMenuItem});
            this.popmenu1.Name = "popmenu1";
            this.popmenu1.Size = new System.Drawing.Size(182, 52);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // reiniciarTextosToolStripMenuItem
            // 
            this.reiniciarTextosToolStripMenuItem.Name = "reiniciarTextosToolStripMenuItem";
            this.reiniciarTextosToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.reiniciarTextosToolStripMenuItem.Text = "Reiniciar Textos";
            this.reiniciarTextosToolStripMenuItem.Click += new System.EventHandler(this.reiniciarTextosToolStripMenuItem_Click);
            // 
            // verBDBg
            // 
            this.verBDBg.BackColor = System.Drawing.Color.LightSalmon;
            this.verBDBg.Controls.Add(this.verBDBtn);
            this.verBDBg.Location = new System.Drawing.Point(657, 363);
            this.verBDBg.Name = "verBDBg";
            this.verBDBg.Size = new System.Drawing.Size(72, 26);
            this.verBDBg.TabIndex = 42;
            // 
            // verBDBtn
            // 
            this.verBDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verBDBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verBDBtn.Font = new System.Drawing.Font("Leelawadee", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verBDBtn.Location = new System.Drawing.Point(0, 0);
            this.verBDBtn.Name = "verBDBtn";
            this.verBDBtn.Size = new System.Drawing.Size(72, 26);
            this.verBDBtn.TabIndex = 0;
            this.verBDBtn.Text = "ver";
            this.verBDBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.verBDBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.verBDBtn_MouseClick);
            this.verBDBtn.MouseEnter += new System.EventHandler(this.verBDBtn_MouseEnter);
            this.verBDBtn.MouseLeave += new System.EventHandler(this.verBDBtn_MouseLeave);
            // 
            // invPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 639);
            this.ContextMenuStrip = this.popmenu1;
            this.Controls.Add(this.verBDBg);
            this.Controls.Add(this.filtrarBg);
            this.Controls.Add(this.modificarBg);
            this.Controls.Add(this.eliminarBg);
            this.Controls.Add(this.agregarBg);
            this.Controls.Add(this.TablaProd);
            this.Controls.Add(this.stockTxt);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.matCbx);
            this.Controls.Add(this.tallaCbx);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.materialLbl);
            this.Controls.Add(this.tallaLbl);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.codigoTxt);
            this.Controls.Add(this.marcaLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.codigoLbl);
            this.Controls.Add(this.inv_tl_Bg);
            this.Name = "invPnl";
            this.Text = "invPnl";
            this.filtrarBg.ResumeLayout(false);
            this.modificarBg.ResumeLayout(false);
            this.eliminarBg.ResumeLayout(false);
            this.agregarBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProd)).EndInit();
            this.inv_tl_Bg.ResumeLayout(false);
            this.popmenu1.ResumeLayout(false);
            this.verBDBg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView TablaProd;
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