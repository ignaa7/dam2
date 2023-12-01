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
    public partial class FormAgregarMantenimiento : Form
    {
        public FormAgregarMantenimiento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string consulta = $"insert into mantenimiento(codigo, cod_descripcion, codigo_vehiculo, fecha_inicio, fecha_fin, descripcion) values ({txtId.Text}, {txtCodigoDescripcion.Text}, {txtIdVehiculo.Text}, {txtFechaInicio.Text}, {txtFechaFin.Text}, {txtDescripcion.Text})";

                Conexion conexion = new Conexion();

                if (conexion.EjecutarComandoSinRetornarDatos(consulta))
                {
                    MessageBox.Show("Mantenimiento añadido correctamente");
                }
                else
                {
                    MessageBox.Show("Error al añadir el mantenimiento");
                }
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

        private void txtCodigoDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCodigoDescripcion.Text, @"^[A-Z]\d$"))
            {
                errId.SetError(txtCodigoDescripcion, "Formato inválido");
                e.Cancel = true;
            }
            else
            {
                errId.SetError(txtCodigoDescripcion, "");
                e.Cancel = false;
            }
        }

        private void txtIdVehiculo_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtIdVehiculo.Text, @"^\d+$"))
            {
                errId.SetError(txtIdVehiculo, "Formato inválido");
                e.Cancel = true;
            }
            else
            {
                errId.SetError(txtIdVehiculo, "");
                e.Cancel = false;
            }
        }
    }
}
