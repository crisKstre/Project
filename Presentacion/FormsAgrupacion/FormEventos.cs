using Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.PatronFactory;

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

                // Crear el evento usando la fábrica
                int idGenerado = service.CrearEvento(
                    factory,
                    txtNombre.Text,
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

        }

        private void CargarEventos()
        {
            EventoService service = new EventoService();
            DataTable tablaEventos = service.ObtenerEventos();

            dgvEventos.DataSource = tablaEventos;

            // Opcional: personalizar columnas
            dgvEventos.Columns["IdEvento"].HeaderText = "ID";
            dgvEventos.Columns["Nombre"].HeaderText = "Nombre del Evento";
            dgvEventos.Columns["Tipo"].HeaderText = "Tipo";
            dgvEventos.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvEventos.Columns["FechaFin"].HeaderText = "Término";
            dgvEventos.Columns["Lugar"].HeaderText = "Lugar";
            dgvEventos.Columns["Cupos"].HeaderText = "Cupos";
            dgvEventos.Columns["PrecioEntrada"].HeaderText = "Precio";
            dgvEventos.Columns["Descripcion"].HeaderText = "Descripción";
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            comboTipoEvento.Items.AddRange(new string[] { "Regional", "Comunal", "Nacional" });
            comboTipoEvento.SelectedIndex = 0; // Por defecto
            CargarEventos();
        }
    }
}
