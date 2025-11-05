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

        private void FormPerfilAgrupacion_Load(object sender, EventArgs e)
        {
            CargarPostulaciones();
            ConfigurarBotones();
        }
        private void CargarPostulaciones()
        {
            int idUsuario = UserLoginCache.idUsuario;
            dgvPostulaciones.DataSource = participacionService.ObtenerPostulacionesDeAgrupacionPorUsuario(idUsuario);
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

        private void dgvPostulaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


    }
}
