using Dominio.Servicios;
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

namespace Presentacion.FormsFeriante
{
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void btnRegistrarPuesto_Click(object sender, EventArgs e)
        {
            PuestoService service = new PuestoService();
            Puesto nuevoPuesto = new Puesto
            {
                IdFeriante = UserLoginCache.idUsuario, // este valor lo tienes al logearte
                NombrePuesto = txtNombrePuesto.Text,
                Categoria = txtCategoria.Text,
                Descripcion = txtDescripcion.Text,
                Estado = "Activo",
                Encargado = UserLoginCache.Nombre
            };

            int idGenerado = service.RegistrarPuesto(nuevoPuesto);
            if (idGenerado > 0)
            {
                MessageBox.Show("Puesto registrado correctamente.", "Éxito");
                CargarPuestos(); // actualiza el DataGridView
            }
            else
            {
                MessageBox.Show("Error al registrar el puesto.", "Error");
            }
        }

        private void CargarPuestos()
        {
            PuestoService service = new PuestoService();
            DataTable tabla = service.ObtenerPuestosPorFeriante(UserLoginCache.idUsuario);
            dgvPuestos.DataSource = tabla;
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            CargarPuestos();
        }
    }
}
