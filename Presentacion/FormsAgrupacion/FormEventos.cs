using AccesoData.DAO;
using Dominio.PatronFactory;
using Dominio.Servicios;
using Entidades.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace Presentacion.FormsAgrupacion
{
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtLugar.Text == "Lugar" || txtDescripcion.Text == "" || txtCupos.Text == "" || txtPrecio.Text == "")
            {
                MostrarMensajeTemporal("Por favor, complete todos los campos.",6000);
                return;
            }

            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaTermino = dtpFechaFin.Value.Date;

            if (fechaInicio > fechaTermino)
            {
                MostrarMensajeTemporal("La fecha de inicio debe ser anterior a la fecha de término.",6000);
                return;
            }
            try
            {
                string tipoSeleccionado = comboTipoEvento.SelectedItem.ToString();
                EventoFactory factory;

                // Seleccionar la fábrica adecuada según el tipo de evento
                switch (tipoSeleccionado)
                {
                    case "Regional":
                        factory = new EventoRegionalFactory();
                        break;
                    case "Comunal":
                        factory = new EventoComunalFactory();
                        break;
                    case "Nacional":
                        factory = new EventoNacionalFactory();
                        break;
                    default:
                        throw new Exception("Tipo de evento no válido");
                }

                // Crear el servicio que usa la capa de datos
                EventoService service = new EventoService();

                int idAgrupacion = service.ObtenerIdAgrupacionPorEncargado(UserLoginCache.idUsuario);
                if (idAgrupacion == 0)
                {
                    MessageBox.Show("No tienes una agrupación asignada. Crea o asigna una agrupación antes de crear eventos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el evento usando la fábrica
                int idGenerado = service.CrearEvento(
                    factory,
                    txtNombre.Text,
                    idAgrupacion,
                    txtLugar.SelectedItem.ToString(),
                    dtpFechaInicio.Value,
                    dtpFechaFin.Value,
                    txtDescripcion.Text,
                    int.Parse(txtCupos.Text),
                    decimal.Parse(txtPrecio.Text)
                );

                if (idGenerado > 0)
                {
                    MessageBox.Show("Evento creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCupos.Clear();
                    txtDescripcion.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtPrecio.Clear();
                }
                else
                {
                    MessageBox.Show("Error al crear el evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarEventosAgrupacion();
            errorLbl.Hide();


        }

        private void CargarEventosAgrupacion()
        {
            EventoService eventoService = new EventoService();
            dgvEventos.DataSource = eventoService.ObtenerEventosConAgrupacion();
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEventos.Columns["IdEvento"].Visible = false;
            dgvEventos.Columns["Nombre"].HeaderText = "Nombre del Evento";
            dgvEventos.Columns["Tipo"].HeaderText = "Tipo";
            dgvEventos.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvEventos.Columns["FechaFin"].HeaderText = "Término";
            dgvEventos.Columns["Lugar"].HeaderText = "Lugar";
            dgvEventos.Columns["Cupos"].HeaderText = "Cupos";
            dgvEventos.Columns["PrecioEntrada"].HeaderText = "Precio";
            dgvEventos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvEventos.Columns["NombreAgrupacion"].HeaderText = "Agrupación Organizadora";
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            llenarCboTipoEvento();
            CargarEventosAgrupacion();
            CargarPlazas();
            txtLugar.SelectedIndexChanged += txtLugar_SelectedIndexChanged;
            txtLugar.Validating += txtLugar_Validating;
            txtLugar.SelectedIndex = -1;

        }

        private void FechaInicioLbl_Click(object svender, EventArgs e)
        {

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
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

        private void llenarCboTipoEvento()
        {
            comboTipoEvento.Items.Add("Regional");
            comboTipoEvento.Items.Add("Comunal");
            comboTipoEvento.Items.Add("Nacional");
            comboTipoEvento.SelectedIndex = 0; 

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
