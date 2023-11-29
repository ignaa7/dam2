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
    public partial class FormConsultarPrecio : Form
    {
        private Servicio Servicio;
        public FormConsultarPrecio()
        {
            InitializeComponent();

            Servicio = Servicio.GetInstance();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPrecios.DataSource = Servicio.ConsultarPrecioMasCaroYMasBarato().Tables[0];
        }
    }
}
