using _2.conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class FormVerVehiculos : Form
    {
        public FormVerVehiculos()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string consulta = "select codigo, matricula, modelo, marca, año_fabricacion, estado from vehiculo";

            dgvVehiculos.DataSource = conexion.EjecutarComandoRetornarDatos(consulta);
        }
    }
}
