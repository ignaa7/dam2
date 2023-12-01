using _2.conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class FormModificarEstadoVehiculo : Form
    {
        public FormModificarEstadoVehiculo()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string consulta = $"update vehiculo estado={txtEstado.Text})";

                Conexion conexion = new Conexion();

                if (conexion.EjecutarComandoSinRetornarDatos(consulta))
                {
                    MessageBox.Show("Vehículo modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el vehículo");
                }
            }
        }

        private void txtEstado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                errEstado.SetError(txtEstado, "Formato inválido");
                e.Cancel = true;
            }
            else
            {
                errEstado.SetError(txtEstado, "");
                e.Cancel = false;
            }
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtId.Text, @"^\d+$"))
            {
                errId.SetError(txtId, "Formato inválido");
                e.Cancel = true;
            }
            else
            {
                errId.SetError(txtId, "");
                e.Cancel = false;
            }
        }
    }
}
