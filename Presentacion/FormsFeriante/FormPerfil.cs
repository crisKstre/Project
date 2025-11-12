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
                txtNombrePuesto.Clear();
                txtCategoria.Clear();
                txtDescripcion.Clear();
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
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuestos.DataSource = tabla;
            dgvPuestos.Columns["IdPuesto"].Visible = false;
            dgvPuestos.Columns["NombrePuesto"].HeaderText = "Nombre del puesto";
            dgvPuestos.Columns["Categoria"].HeaderText = "Categoria";
            dgvPuestos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvPuestos.Columns["Estado"].HeaderText = "Estado";
            dgvPuestos.Columns["Encargado"].HeaderText = "Encargado";

        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            CargarPuestos();
            CargarPostulaciones();
        }

        private void CargarPostulaciones()
        {
            ParticipacionService service = new ParticipacionService();
            int idUsuario = UserLoginCache.idUsuario;

            dgvPostulaciones.DataSource = service.ObtenerPostulacionesPorUsuario(idUsuario);
            dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPostulaciones.Columns["Nombre"].HeaderText = "Nombre Evento";
            dgvPostulaciones.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
            dgvPostulaciones.Columns["FechaFin"].HeaderText = "Fecha Fin";
            dgvPostulaciones.Columns["NombrePuesto"].HeaderText = "Nombre Puesto";
        }

        private void reiniciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarPostulaciones();
            CargarPuestos();
        }

        private void reiniciarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        private void eliminarPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un puesto para eliminar.", "Atención");
                return;
            }

            // Obtener el ID del puesto seleccionado
            int idPuesto = Convert.ToInt32(dgvPuestos.SelectedRows[0].Cells["IdPuesto"].Value);
            string nombrePuesto = dgvPuestos.SelectedRows[0].Cells["NombrePuesto"].Value.ToString();

            // Confirmación antes de eliminar
            DialogResult confirm = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el puesto '{nombrePuesto}'?\n" +
                $"Si tiene postulaciones asociadas, también serán eliminadas.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                PuestoService service = new PuestoService();
                bool exito = service.EliminarPuesto(idPuesto);

                if (exito)
                {
                    MessageBox.Show("Puesto eliminado correctamente.", "Éxito");
                    CargarPuestos(); // refresca el grid
                    CargarPostulaciones(); // refresca las postulaciones
                }
                else
                {
                    MessageBox.Show("Error al eliminar el puesto.", "Error");
                }
            }
        }
    }
}
