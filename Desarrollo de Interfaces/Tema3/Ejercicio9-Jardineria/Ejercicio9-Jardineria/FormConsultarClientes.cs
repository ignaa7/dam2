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
    public partial class FormConsultarClientes : Form
    {
        private Servicio Servicio;

        public FormConsultarClientes()
        {
            InitializeComponent();

            Servicio = Servicio.GetInstance();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet clientesNoPagan = Servicio.ConsultarClientesNoPagan();

            if (clientesNoPagan.Tables.Count > 0)
            {
                dgvClientes.DataSource = clientesNoPagan.Tables[0];
            }
        }
    }
}
