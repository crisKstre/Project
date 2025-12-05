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
        private bool isLoggingOut = false;



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.MediumTurquoise;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in sidePnl.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkSlateGray;
                    previousBtn.ForeColor = Color.Snow;
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
        private void FormPrincipalAgrupacion_Load(object sender, EventArgs e)
        {
            CargarInfoUsuario();
            AjustarAEscritorioDisponible();
            label3.Text = "Bienvenido, " + UserLoginCache.LoginNombre;
        }

        private void CargarInfoUsuario()
        {
            NombreAgrupacionLbl.Text = UserLoginCache.LoginNombre;
            NombreLbl.Text = UserLoginCache.Nombre;
            PosicionLbl.Text = UserLoginCache.Posicion;
        }


        private void AjustarAEscritorioDisponible()
        {
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(areaTrabajo.Left, areaTrabajo.Top);
            this.Size = new Size(areaTrabajo.Width, areaTrabajo.Height);
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            isLoggingOut = true;
            Form mainmenu = new Login();
            mainmenu.Show();
            this.Close();
        }

        private void FormPrincipalAgrupacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPerfilAgrupacion(), sender);
        }

        private void eventosBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEventos(), sender);
        }
    }
}
