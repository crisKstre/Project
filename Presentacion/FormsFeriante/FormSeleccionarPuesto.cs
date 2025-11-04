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
    public partial class FormSeleccionarPuesto : Form
    {
        public Puesto PuestoSeleccionado { get; private set; }

        public FormSeleccionarPuesto(List<Puesto> puestos)
        {
            InitializeComponent();
            CargarPuestos(puestos);

        }

        private void CargarPuestos(List<Puesto> puestos)
        {
            cmbPuestos.DataSource = puestos;
            cmbPuestos.DisplayMember = "NombrePuesto";
            cmbPuestos.ValueMember = "IdPuesto";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PuestoSeleccionado = cmbPuestos.SelectedItem as Puesto;
            if (PuestoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un puesto para continuar.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}


