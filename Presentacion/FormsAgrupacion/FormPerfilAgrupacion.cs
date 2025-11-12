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

namespace Presentacion.FormsAgrupacion
{
    public partial class FormPerfilAgrupacion : Form
    {
        public FormPerfilAgrupacion()
        {
            InitializeComponent();

        }

        private ParticipacionService participacionService = new ParticipacionService();
        private EventoService EventoService = new EventoService();

        private void FormPerfilAgrupacion_Load(object sender, EventArgs e)
        {
            CargarPostulaciones();
            ConfigurarBotones();
            CargarEventosPorAgrupacion();
        }
        private void CargarPostulaciones()
        {
            int idUsuario = UserLoginCache.idUsuario;
            dgvPostulaciones.DataSource = participacionService.ObtenerPostulacionesDeAgrupacionPorUsuario(idUsuario);
            // dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPostulaciones.Columns["IdParticipacion"].Visible = false;
            dgvPostulaciones.Columns["NombrePuesto"].HeaderText = "Nombre del Puesto";
            dgvPostulaciones.Columns["CategoriaPuesto"].HeaderText = "Categoria del Puesto";
            dgvPostulaciones.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvPostulaciones.Columns["FechaFin"].HeaderText = "Término";

        }

        private void CargarEventosPorAgrupacion()
        {
            dgvMisEventos.DataSource = EventoService.ObtenerEventosPorAgrupacion();
            // dgvMisEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMisEventos.Columns["IdEvento"].Visible = false;
            dgvMisEventos.Columns["Nombre"].HeaderText = "Nombre del Evento";
            dgvMisEventos.Columns["Tipo"].HeaderText = "Tipo";
            dgvMisEventos.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvMisEventos.Columns["FechaFin"].HeaderText = "Término";
            dgvMisEventos.Columns["Lugar"].HeaderText = "Lugar";
            dgvMisEventos.Columns["Cupos"].HeaderText = "Cupos";
            dgvMisEventos.Columns["PrecioEntrada"].HeaderText = "Precio";
            dgvMisEventos.Columns["Descripcion"].HeaderText = "Descripción";
        }


        private void ConfigurarBotones()
        {
            if (!dgvPostulaciones.Columns.Contains("Aceptar"))
            {
                DataGridViewButtonColumn btnAceptar = new DataGridViewButtonColumn();
                btnAceptar.Name = "Aceptar";
                btnAceptar.HeaderText = "";
                btnAceptar.Text = "Aceptar";
                btnAceptar.UseColumnTextForButtonValue = true;
                dgvPostulaciones.Columns.Add(btnAceptar);
            }

            if (!dgvPostulaciones.Columns.Contains("Denegar"))
            {
                DataGridViewButtonColumn btnDenegar = new DataGridViewButtonColumn();
                btnDenegar.Name = "Denegar";
                btnDenegar.HeaderText = "";
                btnDenegar.Text = "Denegar";
                btnDenegar.UseColumnTextForButtonValue = true;
                dgvPostulaciones.Columns.Add(btnDenegar);
            }
        }

        private void dgvPostulaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idParticipacion = Convert.ToInt32(dgvPostulaciones.Rows[e.RowIndex].Cells["IdParticipacion"].Value);

                if (dgvPostulaciones.Columns[e.ColumnIndex].Name == "Aceptar")
                {
                    if (participacionService.CambiarEstadoPostulacion(idParticipacion, "Aceptada"))
                    {
                        MessageBox.Show("Postulación aceptada correctamente.");
                        CargarPostulaciones();
                    }
                }
                else if (dgvPostulaciones.Columns[e.ColumnIndex].Name == "Denegar")
                {
                    if (participacionService.CambiarEstadoPostulacion(idParticipacion, "Denegada"))
                    {
                        MessageBox.Show("Postulación denegada correctamente.");
                        CargarPostulaciones();
                    }
                }
            }
        }

        private void reiniciarTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarPostulaciones();
            CargarEventosPorAgrupacion();
        }

        private void reiniciarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarEventosPorAgrupacion();
        }

        private void eliminarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMisEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un evento para eliminar.");
                return;
            }

            int idEvento = Convert.ToInt32(dgvMisEventos.SelectedRows[0].Cells["IdEvento"].Value);
            string nombreEvento = dgvMisEventos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"¿Estás seguro de eliminar el evento \"{nombreEvento}\"?\n" +
                $"Esto también eliminará todas las postulaciones asociadas.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                EventoService service = new EventoService();
                bool eliminado = service.EliminarEvento(idEvento);

                if (eliminado)
                {
                    MessageBox.Show("Evento y postulaciones eliminados correctamente.", "Éxito");
                    CargarEventosPorAgrupacion(); // Método que actualiza el DataGridView
                    CargarPostulaciones(); // Actualiza las postulaciones también
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el evento.", "Error");
                }
            }
        }
    }
}
