using AccesoData.DAO;
using Dominio.Servicios;
using Entidades.Cache;
using Presentacion.FormsFeriante;
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
    public partial class FormHijo2 : Form
    {
        public FormHijo2()
        {
            InitializeComponent();
        }

        private void filtrarBtn_MouseEnter(object sender, EventArgs e)
        {
            btnPostular.BackColor = Color.DarkSalmon;
        }

        private void filtrarBtn_MouseLeave(object sender, EventArgs e)
        {
            btnPostular.BackColor = Color.LightSalmon;
        }

        private void Tabla_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow Fila = dgvEventos02.Rows[e.RowIndex];
        }

        private void filtrarBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarEventos();
        }

        private void reiniciarTextosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CargarEventos()
        {
            EventoService service = new EventoService();
            DataTable tablaEventos = service.ObtenerEventosConAgrupacion();

            dgvEventos02.DataSource = tablaEventos;

            // {Opcional} personalizar columnas
            dgvEventos02.Columns["IdEvento"].Visible = false;
            dgvEventos02.Columns["Nombre"].HeaderText = "Nombre del Evento";
            dgvEventos02.Columns["Tipo"].HeaderText = "Tipo";
            dgvEventos02.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvEventos02.Columns["FechaFin"].HeaderText = "Término";
            dgvEventos02.Columns["Lugar"].HeaderText = "Lugar";
            dgvEventos02.Columns["Cupos"].HeaderText = "Cupos";
            dgvEventos02.Columns["PrecioEntrada"].HeaderText = "Precio";
            dgvEventos02.Columns["Descripcion"].HeaderText = "Descripción";
            dgvEventos02.Columns["NombreAgrupacion"].HeaderText = "Agrupación Organizadora";
        }

        private void FormHijo2_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            if (dgvEventos02.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un evento para postular.");
                return;
            }

            int idEvento = Convert.ToInt32(dgvEventos02.SelectedRows[0].Cells["IdEvento"].Value);
            int idUsuario = UserLoginCache.idUsuario;

            // Obtener la fecha de fin del evento desde el DataGridView
            DateTime fechaFin = Convert.ToDateTime(dgvEventos02.SelectedRows[0].Cells["FechaFin"].Value);

            // Verificar si el evento ya terminó
            if (fechaFin < DateTime.Now.Date)
            {
                MessageBox.Show("No puedes postularte a un evento que ya ha finalizado o esta en curso.", "Aviso", MessageBoxButtons.OK);
                return;
            }


            ParticipacionDao participacionDao = new ParticipacionDao();

            if (participacionDao.ExistePostulacion(idEvento, idUsuario))
            {
                MessageBox.Show("Ya estás postulando a este evento.", "Aviso");
                return;
            }

            PuestoService puestoService = new PuestoService();
            List<Puesto> puestos = puestoService.ObtenerPuestosPorUsuario(idUsuario);

            if (puestos.Count == 0)
            {
                MessageBox.Show("No tienes puestos registrados. Crea uno antes de postular.");
                return;
            }

            FormSeleccionarPuesto frm = new FormSeleccionarPuesto(puestos);
            if (frm.ShowDialog() != DialogResult.OK)
                return;

            Puesto puestoSeleccionado = frm.PuestoSeleccionado;

            ParticipacionCache nueva = new ParticipacionCache
            {
                IdEvento = idEvento,
                IdUsuario = idUsuario,
                IdPuesto = puestoSeleccionado.IdPuesto,
                NombrePuesto = puestoSeleccionado.NombrePuesto,
                CategoriaPuesto = puestoSeleccionado.Categoria,
                Rol = "Feriante",
                Estado = "Pendiente"
            };

            bool exito = participacionDao.RegistrarPostulacion(nueva);
            if (exito)
                MessageBox.Show("Postulación enviada correctamente.", "Éxito");
            else
                MessageBox.Show("Ocurrió un error al registrar la postulación.", "Error");
        }

    }
}
