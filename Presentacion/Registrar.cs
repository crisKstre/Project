using AccesoData.DAO;
using Presentacion;

namespace Presentacion
{
    public partial class Registrar : Form
    {
        public Registrar()
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
            if (RegistrarPnl != null)
            {
                RegistrarPnl.Controls.Add(childForm);
                RegistrarPnl.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                MessageBox.Show("Error: Panel adminPnl no encontrado");
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new LoginUI(), sender);
        }

        private void RegistrarPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();

            // Validar que no exista el usuario
            if (userDao.UserExists(txtUsuario.Text, txtEmail.Text))
            {
                MessageBox.Show("El usuario o email ya existen","Error");
                return;
            }

            // Convertir teléfono a int (con validación)
            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El teléfono debe ser un número válido","Error");
                return;
            }

            string posicion = FoA.Checked ? "Feriante" : "Agrupacion";

            bool success = userDao.Register(
                txtNombre.Text,    // Nombre
                txtUsuario.Text,   // LoginNombre
                txtEmail.Text,     // Email
                txtPass.Text,      // Pass
                telefono,          // Telefono
                posicion           // Nuevo parámetro
            );

            if (success)
            {
                MessageBox.Show("Usuario registrado exitosamente","Proceso completado!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario","Error al completar el proceso!");
            }
        }
    }
}
