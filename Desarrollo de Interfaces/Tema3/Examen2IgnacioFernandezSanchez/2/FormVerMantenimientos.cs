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
    public partial class FormVerMantenimientos : Form
    {
        public FormVerMantenimientos()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string consulta = "select codigo, cod_descripcion, codigo_vehiculo, fecha_inicio, fecha_fin, descripcion from mantenimiento";

            dgvMantenimientos.DataSource = conexion.EjecutarComandoRetornarDatos(consulta);
        }
    }
}
