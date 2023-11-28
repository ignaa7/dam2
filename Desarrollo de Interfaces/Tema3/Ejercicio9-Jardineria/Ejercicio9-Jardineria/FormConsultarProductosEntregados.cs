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
    public partial class FormConsultarProductosEntregados : Form
    {
        private Servicio Servicio;
        public FormConsultarProductosEntregados()
        {
            InitializeComponent();

            Servicio = Servicio.GetInstance();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int mes = cbMeses.SelectedIndex;

            if (mes != -1)
            {
                DataSet pedidos = Servicio.ConsultarPedidosEntregados(mes + 1);

                dgvPedidosEntregados.DataSource = pedidos.Tables[0];
            }
        }
    }
}
