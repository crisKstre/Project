using Domain;
using Entidades.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class LoginUI : Form
    {

        public LoginUI()
        {
            InitializeComponent();
        }


        // Declara las variables como nullable con ?
        private LinkLabel? currentLinkLabel = null;
        private Form? currentChildForm = null;

        private void ActivateLinkLabel(object lblSender)
        {
            if (lblSender != null)
            {
                // Solo guardamos la referencia, sin cambios visuales
                currentLinkLabel = (LinkLabel)lblSender;
            }
        }

        private void OpenChildForm(Form childForm, object lblSender)
        {
            // Cerrar formulario actual si existe
            currentChildForm?.Close();

            // Activar el LinkLabel (sin cambios visuales)
            ActivateLinkLabel(lblSender);

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Verificar que adminPnl no es null antes de usarlo
            if (LoginPnl != null)
            {
                LoginPnl.Controls.Add(childForm);
                LoginPnl.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                MessageBox.Show("Error: Panel adminPnl no encontrado");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new Registrar(), sender);
            Debug.WriteLine("Funciono");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Funciona el boton");

            if (txtUsuario.Text != " Nombre de Usuario" && txtUsuario.Text != "")
            {
                if (txtPass.Text != " Contraseña" && txtPass.Text != "")
                {
                    ModeloUsuario Usuario = new ModeloUsuario();
                    var loginValido = Usuario.LoginUser(txtUsuario.Text, txtPass.Text);

                    if (loginValido == true)
                    {
                        this.Hide();

                        if (UserLoginCache.Posicion == TipoUsuario.Agrupacion)
                        {
                            var mainmenu = new FormsAgrupacion.FormPrincipalAgrupacion();
                            this.ParentForm.Hide();
                            mainmenu.FormClosed += (s, args) => this.ParentForm.Close();
                            mainmenu.Show();
                        }
                        else if (UserLoginCache.Posicion == TipoUsuario.Feriante)
                        {
                            var mainmenu = new FormPrincipal();
                            this.ParentForm.Hide();
                            mainmenu.FormClosed += (s, args) => this.ParentForm.Hide();
                            mainmenu.Show();
                        }
                        else
                        {
                            this.ParentForm.Show();
                            msgError("Tipo de usuario no reconocido.");
                        }
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña incorrecta \n     Inténtalo de nuevo");
                        txtPass.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Debe ingresar contraseña");
                }
            }
            else
            {
                msgError("Debe ingresar nombre de usuario");
            }
        }


        private void msgError(string msg)
        {
            errorLbl.Text = "     " + msg;
            errorLbl.Visible = true;
            Debug.WriteLine(msg);
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtPass.Clear();
            errorLbl.Visible = false;
            this.ParentForm.Show();
            txtUsuario.Focus();
        }

        private void LoginUI_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void CentrarPanel()
        {
            LoginPnl.Left = (this.ClientSize.Width - LoginPnl.Width) / 2;
            LoginPnl.Top = (this.ClientSize.Height - LoginPnl.Height) / 2;
        }

        private void LoginPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
