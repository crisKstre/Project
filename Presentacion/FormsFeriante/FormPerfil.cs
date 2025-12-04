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
            if (txtCategoria.Text == "" || txtDescripcion.Text == "" || txtNombrePuesto.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Atención");
                return;
            }
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
            btnEditar.Hide();
        }

        private void CargarPostulaciones()
        {
            ParticipacionService service = new ParticipacionService();
            int idUsuario = UserLoginCache.idUsuario;

            dgvPostulaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPostulaciones.DataSource = service.ObtenerPostulacionesPorUsuario(idUsuario);

            // Encabezados (si existen)
            if (dgvPostulaciones.Columns.Contains("Nombre"))
                dgvPostulaciones.Columns["Nombre"].HeaderText = "Nombre Evento";
            if (dgvPostulaciones.Columns.Contains("FechaInicio"))
                dgvPostulaciones.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
            if (dgvPostulaciones.Columns.Contains("FechaFin"))
                dgvPostulaciones.Columns["FechaFin"].HeaderText = "Fecha Fin";
            if (dgvPostulaciones.Columns.Contains("NombrePuesto"))
                dgvPostulaciones.Columns["NombrePuesto"].HeaderText = "Nombre Puesto";
            if (dgvPostulaciones.Columns.Contains("Lugar"))
                dgvPostulaciones.Columns["Lugar"].HeaderText = "Lugar";
            if (dgvPostulaciones.Columns.Contains("NombreAgrupacion"))
                dgvPostulaciones.Columns["NombreAgrupacion"].HeaderText = "Agrupación";

            // Suscribir el evento una sola vez
            dgvPostulaciones.DataBindingComplete -= DgvPostulaciones_DataBindingComplete;
            dgvPostulaciones.DataBindingComplete += DgvPostulaciones_DataBindingComplete;

            // actualizar sidepanel inmediatamente
            ActualizarSidePanelDesdeDgv();
        }

        private void DgvPostulaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ActualizarSidePanelDesdeDgv();
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

        // Llamar esto cada vez que el dgvPostulaciones cambie de datos
        private void ActualizarSidePanelDesdeDgv()
        {
            // Si no hay filas, limpiar
            if (dgvPostulaciones.Rows.Count == 0)
            {
                lblTotalPostulaciones.Text = "0";
                lblLugarMasPostulado.Text = "-";
                lblAgrupacionMasPostulada.Text = "-";
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
                    Agrupacion = GetCellString(r, "NombreAgrupacion", "Agrupacion", "Organizador"), // puede faltar
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

            // Agrupación más postulada
            string topAgrup = GetMostCommon(items.Select(i => i.Agrupacion));
            lblAgrupacionMasPostulada.Text = string.IsNullOrWhiteSpace(topAgrup) ? "-" : topAgrup;

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

        private void editarPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvPuestos.Rows[dgvPuestos.SelectedCells[0].RowIndex];
            txtNombrePuesto.Text = fila.Cells["NombrePuesto"].Value.ToString();
            txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            btnRegistrarPuesto.Hide();
            btnRegistrarPuesto.Enabled = false;
            btnEditar.Show();
            btnEditar.Enabled = true;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Puesto puesto = new Puesto()
            {
                IdPuesto = Convert.ToInt32(dgvPuestos.SelectedRows[0].Cells["IdPuesto"].Value),
                NombrePuesto = txtNombrePuesto.Text,
                Categoria = txtCategoria.Text,
                Descripcion = txtDescripcion.Text,
                Estado = "Activo", 
                Encargado = UserLoginCache.Nombre
            };

            PuestoService service = new PuestoService();

            if (service.ActualizarPuesto(puesto))
            {
                MessageBox.Show("Puesto actualizado correctamente.","Edición completada",MessageBoxButtons.OK);
                CargarPuestos();
                btnEditar.Hide();
                btnEditar.Enabled = false;
                btnRegistrarPuesto.Show();
                btnRegistrarPuesto.Enabled = true;
                txtNombrePuesto.Clear();
                txtCategoria.Clear();
                txtDescripcion.Clear();
            }
            else
            {
                MessageBox.Show("Error al actualizar el puesto.");
            }
        }
    }
}
