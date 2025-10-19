

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            OpenChildForm2(new LoginUI());
        }

        private Form? currentChildForm = null;


        private void OpenChildForm2(Form childForm)
        {
            // Cerrar formulario actual si existe
            currentChildForm?.Close();

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

    }
}
