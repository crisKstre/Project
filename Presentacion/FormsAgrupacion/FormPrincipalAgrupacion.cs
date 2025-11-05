using Entidades.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Forms;

namespace Presentacion.FormsAgrupacion
{
    public partial class FormPrincipalAgrupacion : Form
    {
        public FormPrincipalAgrupacion()
        {
            InitializeComponent();
        }

        private Button currentButton;


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
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.PaleGreen;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private Form currentChildForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateButton(btnSender);
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.AgrupacionPnl.Controls.Add(childForm);
            this.AgrupacionPnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private LinkLabel? currentLinkLabel = null;
        private void ActivateLinkLabel(object lblSender)
        {
            if (lblSender != null)
            {
                // guardamos la referencia, sin cambios visuales
                currentLinkLabel = (LinkLabel)lblSender;
                DisableButton();
            }
        }
        private void OpenChildFormLink(Form childForm, object lblSender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateLinkLabel(lblSender);
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.AgrupacionPnl.Controls.Add(childForm);
            this.AgrupacionPnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void FormPrincipalAgrupacion_Load(object sender, EventArgs e)
        {
            CargarInfoUsuario();
        }

        private void CargarInfoUsuario()
        {
            NombreAgrupacionLbl.Text = UserLoginCache.LoginNombre;
            NombreLbl.Text = UserLoginCache.Nombre;
            PosicionLbl.Text = UserLoginCache.Posicion;
        }

        private void EventosBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEventos(), sender);
        }

        private void PerfilLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildFormLink(new FormPerfilAgrupacion(), sender);
        }
    }
}
