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
            dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPostulaciones.DataSource = participacionService.ObtenerPostulacionesDeAgrupacionPorUsuario(idUsuario);
            dgvPostulaciones.Columns["IdParticipacion"].Visible = false;
            dgvPostulaciones.Columns["NombrePuesto"].HeaderText = "Nombre Puesto";
            dgvPostulaciones.Columns["CategoriaPuesto"].HeaderText = "Categoria Puesto";
            dgvPostulaciones.Columns["Lugar"].Visible = true;
            dgvPostulaciones.Columns["FechaInicio"].Visible = false;
            dgvPostulaciones.Columns["FechaFin"].Visible = false;

            dgvPostulaciones.DataBindingComplete -= DgvPostulaciones_DataBindingComplete;
            dgvPostulaciones.DataBindingComplete += DgvPostulaciones_DataBindingComplete;

            // actualizar sidepanel inmediatamente
            ActualizarSidePanelDesdeDgv();

        }

        private void CargarEventosPorAgrupacion()
        {
            dgvMisEventos.DataSource = EventoService.ObtenerEventosPorAgrupacion();
            dgvMisEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMisEventos.Columns["IdEvento"].Visible = false;
            dgvMisEventos.Columns["Nombre"].HeaderText = "Nombre Evento";
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

        private void ActualizarSidePanelDesdeDgv()
        {
            // Si no hay filas, limpiar
            if (dgvPostulaciones.Rows.Count == 0)
            {
                lblTotalPostulaciones.Text = "0";
                lblLugarMasPostulado.Text = "-";
                lblPendientes.Text = "0";
                lblAceptadas.Text = "0";
                lblDenegadas.Text = "0";
                return;
            }

            // Extraer valores de cada fila
            var items = dgvPostulaciones.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new
                {
                    NombreEvento = GetCellString(r, "Nombre", "Evento", "NombreEvento"),
                    Lugar = GetCellString(r, "Lugar", "Ubicacion", "Location"), // puede faltar
                    NombrePuesto = GetCellString(r, "NombrePuesto", "Puesto"),
                    Estado = GetCellString(r, "Estado", "EstadoPostulacion")
                })
                .ToList();

            // Total postulaciones
            int total = items.Count;
            lblTotalPostulaciones.Text = total.ToString();

            // Lugar más postulado (si no hay columna, quedará "-")
            string topLugar = GetMostCommon(items.Select(i => i.Lugar));
            lblLugarMasPostulado.Text = string.IsNullOrWhiteSpace(topLugar) ? "-" : topLugar;

            // Conteo por estado
            var estados = items
                .GroupBy(i => string.IsNullOrWhiteSpace(i.Estado) ? "SinEstado" : i.Estado.Trim())
                .ToDictionary(g => g.Key, g => g.Count());

            lblPendientes.Text = estados.ContainsKey("Pendiente") ? estados["Pendiente"].ToString() : "0";
            lblAceptadas.Text = estados.ContainsKey("Aceptada") ? estados["Aceptada"].ToString() : "0";
            // admite alternativas como "Aceptado"
            if (lblAceptadas.Text == "0" && estados.ContainsKey("Aceptado"))
                lblAceptadas.Text = estados["Aceptado"].ToString();

            lblDenegadas.Text = estados.ContainsKey("Denegada") ? estados["Denegada"].ToString() : "0";
            // admite "Rechazada" o "Rechazado"
            if (lblDenegadas.Text == "0")
            {
                if (estados.ContainsKey("Rechazada")) lblDenegadas.Text = estados["Rechazada"].ToString();
                else if (estados.ContainsKey("Rechazado")) lblDenegadas.Text = estados["Rechazado"].ToString();
            }
        }

        // Helper: obtiene el primer valor no vacío entre los posibles nombres de columna
        private string GetCellString(DataGridViewRow row, params string[] possibleNames)
        {
            foreach (var name in possibleNames)
            {
                if (string.IsNullOrEmpty(name)) continue;
                if (row.DataGridView.Columns.Contains(name) && row.Cells[name].Value != null)
                {
                    var v = row.Cells[name].Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(v)) return v;
                }
            }
            // fallback: devolver la primera celda no nula
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell?.Value != null)
                {
                    var s = cell.Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(s)) return s;
                }
            }
            return string.Empty;
        }

        // Helper: devuelve el elemento más frecuente de la secuencia (o null si no hay)
        private string GetMostCommon(IEnumerable<string> source)
        {
            var ordered = source
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .GroupBy(s => s.Trim())
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.Value)
                .ToList();

            return ordered.Count > 0 ? ordered.First().Value : null;
        }

        private void DgvPostulaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ActualizarSidePanelDesdeDgv();
        }

        private void revisarPostulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvMisEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un evento para eliminar.");
                return;
            }

            int idEvento = Convert.ToInt32(dgvMisEventos.SelectedRows[0].Cells["IdEvento"].Value);
            string nombreEvento = dgvMisEventos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPostulaciones.DataSource = participacionService.ObtenerParticipacionEvento(idEvento);
            dgvPostulaciones.Columns["IdParticipacion"].Visible = false;
            dgvPostulaciones.Columns["NombrePuesto"].HeaderText = "Nombre Puesto";
            dgvPostulaciones.Columns["CategoriaPuesto"].HeaderText = "Categoria Puesto";
            dgvPostulaciones.Columns["Lugar"].Visible = true;
            dgvPostulaciones.Columns["FechaInicio"].Visible = false;
            dgvPostulaciones.Columns["FechaFin"].Visible = false;

        }
    }
}
