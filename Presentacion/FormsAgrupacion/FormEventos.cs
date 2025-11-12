using AccesoData.DAO;
using Dominio.PatronFactory;
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
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {

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
                    txtLugar.Text,
                    dtpFechaInicio.Value,
                    dtpFechaFin.Value,
                    txtDescripcion.Text,
                    int.Parse(txtCupos.Text),
                    decimal.Parse(txtPrecio.Text)
                );

                if (idGenerado > 0)
                {
                    MessageBox.Show($"Evento creado con éxito. ID generado: {idGenerado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        }

        private void CargarEventosAgrupacion()
        {
            EventoService eventoService = new EventoService();
            dgvEventos.DataSource = eventoService.ObtenerEventosConAgrupacion();
            dgvEventos.Columns["IdEvento"].Visible= false;
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
            comboTipoEvento.Items.AddRange(new string[] { "Regional", "Comunal", "Nacional" });
            comboTipoEvento.SelectedIndex = 0; // Por defecto
            CargarEventosAgrupacion();
        }
    }
}
