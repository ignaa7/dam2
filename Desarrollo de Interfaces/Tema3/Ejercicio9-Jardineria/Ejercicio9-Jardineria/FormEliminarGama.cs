using Ejercicio9_Jardineria.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9_Jardineria
{
    public partial class FormEliminarGama : Form
    {
        private Servicio Servicio;

        public FormEliminarGama()
        {
            InitializeComponent();

            Servicio = Servicio.GetInstance();

            foreach (string gama in Servicio.GetGamas())
            {
                cbGamas.Items.Add(gama);
            }
        }

        private void cbGamas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic datosGama = Servicio.GetGama(cbGamas.SelectedItem.ToString()!);

            if (datosGama != null)
            {
                lblGamaDato.Text = datosGama.gama;
                lblDescripcionTextoDato.Text = datosGama.descripcionTexto;
                lblDescripcionHtmlDato.Text = datosGama.descripcionHtml;
                lblImagenDato.Text = datosGama.imagen;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string? gama = cbGamas.SelectedItem.ToString();

            if (gama != null)
            {
                if (Servicio.EliminarGama(gama))
                {
                    MessageBox.Show("Gama eliminada correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la gama");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
