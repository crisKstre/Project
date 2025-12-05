using AccesoData.DAO;
using Dominio.Servicios;
using Entidades.Cache;
using Microsoft.Data.SqlClient;
using Presentacion.FormsFeriante;
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
using Timer = System.Windows.Forms.Timer;

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
            btnPostular.BackColor = Color.CadetBlue;
        }

        private void filtrarBtn_MouseLeave(object sender, EventArgs e)
        {
            btnPostular.BackColor = Color.MediumTurquoise;
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
            dgvEventos02.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


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
            CargarPlazas();
            txtLugar.SelectedIndexChanged += txtLugar_SelectedIndexChanged;
            txtLugar.Validating += txtLugar_Validating;
            txtLugar.SelectedIndex = -1;

        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            if (dgvEventos02.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un evento para postular.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int idEvento = Convert.ToInt32(dgvEventos02.SelectedRows[0].Cells["IdEvento"].Value);
            int idUsuario = UserLoginCache.idUsuario;

            DateTime fechaFin = Convert.ToDateTime(dgvEventos02.SelectedRows[0].Cells["FechaFin"].Value);

            if (fechaFin < DateTime.Now.Date)
            {
                MessageBox.Show("No puedes postularte a un evento que ya ha finalizado o esta en curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ParticipacionDao participacionDao = new ParticipacionDao();

            if (participacionDao.ExistePostulacion(idEvento, idUsuario))
            {
                MessageBox.Show("Ya estás postulando a este evento.", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            PuestoService puestoService = new PuestoService();
            List<Puesto> puestos = puestoService.ObtenerPuestosPorUsuario(idUsuario);

            if (puestos.Count == 0)
            {
                MessageBox.Show("No tienes puestos registrados. Crea uno antes de postular.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Postulación enviada correctamente.", "Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Ocurrió un error al registrar la postulación.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreEvento = txtNombreEvento.Text.Trim();
            string nombreAgrupacion = txtNombreAgrupacion.Text.Trim();
            string Lugar = txtLugar.SelectedIndex != -1 && txtLugar.SelectedItem != null
                ? txtLugar.SelectedItem.ToString().Trim()
                : string.Empty;

            if (string.IsNullOrEmpty(nombreEvento) && string.IsNullOrEmpty(nombreAgrupacion) && txtLugar.SelectedIndex == -1)
            {
                MostrarMensajeTemporal("Ingresa al menos un campo para buscar: Nombre de evento, Nombre de agrupacion o Lugar.",6000);
                return;
            }

            EventoService service = new EventoService();
            DataTable tablaEventos = null;

            if (!string.IsNullOrEmpty(nombreEvento) && !string.IsNullOrEmpty(nombreAgrupacion))
            {
                tablaEventos = service.BuscarEventos(nombreAgrupacion, nombreEvento, Lugar);
            }
            else if (!string.IsNullOrEmpty(nombreEvento))
            {
                tablaEventos = service.BuscarEventosConNombre(nombreEvento);
            }
            else if (!string.IsNullOrEmpty(nombreAgrupacion))
            {
                tablaEventos = service.BuscarEventoConAgrupacion(nombreAgrupacion);
            }
            else if (txtLugar.SelectedIndex != -1)
            {
                tablaEventos = service.BuscarEventoLugar(Lugar);
            }

            dgvEventos02.DataSource = tablaEventos ?? new DataTable();

            txtNombreEvento.Clear();
            txtNombreAgrupacion.Clear();
        }

        private string ultimoValorValido = string.Empty;


        private void CargarPlazas()
        {
            List<string> plazas = new List<string>()
            {
                "Plaza de Armas de Talca",
                "Plaza La Victoria",
                "Plaza Cienfuegos",
                "Plaza Abate Molina",
                "Plaza Arturo Prat",
                "Plaza Las Rastras",
                "Plaza Manuel Rodríguez",
                "Plaza Las Heras",
                "Plaza Maule",
                "Plaza La Obra",
                "Plaza San Agustín",
                "Plaza Carlos Trupp",
                "Plaza Valle del Maule",
                "Plaza Doña Florencia",
                "Plaza Don Sebastián",
                "Plaza Jardín del Este",
                "Plaza Los Escritores",
                "Plaza Las Américas",
                "Plaza Villa Ilusión",
                "Plaza Villa La Paz",
                "Plaza Brisas del Maule",
                "Plaza Brilla El Sol",
                "Plaza San Miguel",
                "Plaza Bicentenario Villa Río Claro",
                "Plaza Villa Huertos de Talca",
                "Plaza Villa Los Paltos",
                "Plaza Villa Los Conquistadores",
                "Plaza Villa Don Pablo",
                "Plaza Los Parques",
                "Plaza Villa El Bosque",
                "Plaza Altos del Parque",
                "Plaza Villa Don Andrés",
                "Plaza Lomas de Talca",
                "Plaza Valle del Country",
                "Plaza Los Maitenes",
                "Plaza del Encuentro",
                "Plaza Las Colines",
                "Plaza Don Gerardo",
                "Plaza El Aromo",
                "Plaza Esperanza Talquina",
                "Plaza Los Almendros",
                "Plaza Las Rosas",
                "Plaza Villa Alameda",
                "Plaza Mirador del Valle",
                "Plaza Santa Marta",
                "Plaza Villa Las Araucarias",
                "Parque Costanera Río Claro",
                "Parque Río Claro",
                "Parque Las Colines",
                "Parque Estero Piduco",
                "Parque La Florida",
                "Parque Villa El Parque",
                "Parque Bicentenario",
                "Parque del Maule",
                "Bandejón Central Av. 2 Sur",
                "Bandejón Av. Colín",
                "Bandejón Av. San Miguel",
                "Bandejón 30 Oriente",
                "Bandejón 11 Oriente",
                "Bandejón 4 Norte"
            };

            txtLugar.DataSource = plazas;

            // Permitir escribir y activar autocompletado
            txtLugar.DropDownStyle = ComboBoxStyle.DropDown;
            txtLugar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLugar.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Inicializar ultimoValorValido con el SelectedItem actual si existe
            if (txtLugar.SelectedItem != null)
                ultimoValorValido = txtLugar.SelectedItem.ToString();
            else if (txtLugar.Items.Count > 0)
                ultimoValorValido = txtLugar.Items[0].ToString();
        }

        // Cuando el usuario selecciona un item válido con mouse/teclado
        private void txtLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtLugar.SelectedItem != null)
                ultimoValorValido = txtLugar.SelectedItem.ToString();
        }

        private void txtLugar_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string texto = txtLugar.Text.Trim();
            bool existe = txtLugar.Items.Cast<object>()
                            .Any(it => string.Equals(it.ToString(), texto, StringComparison.OrdinalIgnoreCase));

            if (!existe)
            {
                txtLugar.Text = ultimoValorValido;
            }
        }

        private void MostrarMensajeTemporal(string mensaje, int milisegundos)
        {
            errorLbl.Text = "     " + mensaje;
            errorLbl.Visible = true;

            Timer timer = new Timer();
            timer.Interval = milisegundos;
            timer.Tick += (s, e) =>
            {
                errorLbl.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }



    }
}
