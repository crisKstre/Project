using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda;
using Tienda.Forms;
using Entidades.Cache;
using Presentacion.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {

        private Button currentButton;

        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.LightSalmon;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Leelawadee", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in sidePnl.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Salmon;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                    
                }
            }
        }

        private Form currentChildForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateButton(btnSender);
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.adminPnl.Controls.Add(childForm);
            this.adminPnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminWF_Load(object sender, EventArgs e)
        {
            CargarInfoUsuario();
        }

        private void CargarInfoUsuario()
        {
            NombreAgrupacionLbl.Text = UserLoginCache.LoginNombre;
            NombreLbl.Text = UserLoginCache.Nombre;
            PosicionLbl.Text = UserLoginCache.Posicion;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new invPnl(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           OpenChildForm(new FormHijo1(), sender);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }



}


