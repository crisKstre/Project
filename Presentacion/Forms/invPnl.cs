using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Forms
{
    public partial class invPnl : Form
    {
        public invPnl()
        {
            InitializeComponent();
            ConfigurarPlaceholders();
        }



        private void limpiarTxt()
        {
            ConfigurarPlaceholders();
        }

        private void SetComboBoxValue(ComboBox comboBox, string value)
        {
            if (value != null)
            {
                int index = comboBox.FindStringExact(value);
                if (index >= 0)
                {
                    comboBox.SelectedIndex = index;
                }
                else
                {
                    index = comboBox.FindString(value);
                    if (index >= 0)
                    {
                        comboBox.SelectedIndex = index;
                    }
                    else
                    {
                        comboBox.Text = value;
                    }
                }
            }
        }

        private void ConfigurarPlaceholders()
        {
            SetPlaceholder(codigoTxt, "Ingresar código...");
            SetPlaceholder(nombreTxt, "Ingresar nombre...");
            SetPlaceholder(marcaTxt, "Ingresar marca...");
            SetPlaceholder(precioTxt, "Ingresar precio...");
            SetPlaceholder(stockTxt, "Ingresar stock...");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void colorFuente()
        {
            nombreTxt.ForeColor = Color.Black;
            marcaTxt.ForeColor = Color.Black;
            precioTxt.ForeColor = Color.Black;
            stockTxt.ForeColor = Color.Black;
        }

        private void agregarBtn_MouseEnter(object sender, EventArgs e)
        {
            agregarBtn.BackColor = Color.DarkSalmon;
        }

        private void agregarBtn_MouseLeave(object sender, EventArgs e)
        {
            agregarBtn.BackColor = Color.LightSalmon;
        }

        private void eliminarBtn_MouseEnter(object sender, EventArgs e)
        {
            eliminarBtn.BackColor = Color.DarkSalmon;
        }

        private void eliminarBtn_MouseLeave(object sender, EventArgs e)
        {
            eliminarBtn.BackColor = Color.LightSalmon;
        }

        private void modificarBtn_MouseEnter(object sender, EventArgs e)
        {
            modificarBtn.BackColor = Color.DarkSalmon;
        }

        private void modificarBtn_MouseLeave(object sender, EventArgs e)
        {
            modificarBtn.BackColor = Color.LightSalmon;
        }

        private void filtrarBtn_MouseEnter(object sender, EventArgs e)
        {
            filtrarBtn.BackColor = Color.DarkSalmon;
        }

        private void filtrarBtn_MouseLeave(object sender, EventArgs e)
        {
            filtrarBtn.BackColor = Color.LightSalmon;
        }

        private void agregarBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void codigoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void precioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stockTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void eliminarBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Tabla_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            codigoTxt.Enabled = false;
            DataGridViewRow Fila = TablaProd.Rows[e.RowIndex];
            codigoTxt.Text = Fila.Cells[0].Value.ToString();
            nombreTxt.Text = Fila.Cells[1].Value.ToString();
            marcaTxt.Text = Fila.Cells[2].Value.ToString();
            SetComboBoxValue(tallaCbx, Fila.Cells[3].Value?.ToString());
            SetComboBoxValue(matCbx, Fila.Cells[4].Value?.ToString());
            precioTxt.Text = Fila.Cells[5].Value.ToString();
            stockTxt.Text = Fila.Cells[6].Value.ToString();
            colorFuente();
        }      

        private void filtrarBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarTextosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarPlaceholders();
            codigoTxt.Enabled = true;
        }

        private void modificarBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void verBDBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void verBDBtn_MouseEnter(object sender, EventArgs e)
        {
            verBDBtn.BackColor = Color.DarkSalmon;
        }

        private void verBDBtn_MouseLeave(object sender, EventArgs e)
        {
            verBDBtn.BackColor = Color.LightSalmon;
        }
    }
}
