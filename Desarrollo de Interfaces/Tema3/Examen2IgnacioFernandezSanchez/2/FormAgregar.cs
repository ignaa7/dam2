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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string consulta = $"insert into vehiculo(codigo, matricula, modelo, marca, año_fabricacion, estado) values ({txtId.Text}, {txtMatricula.Text}, {txtModelo.Text}, {txtMarca.Text}, {txtAnoFabricacion.Text}, {txtEstado.Text})";

                Conexion conexion = new Conexion();

                if (conexion.EjecutarComandoSinRetornarDatos(consulta))
                {
                    MessageBox.Show("Vehículo añadido correctamente");
                }
                else
                {
                    MessageBox.Show("Error al añadir el vehículo");
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

        private void txtMatricula_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtMatricula.Text, @"^\d{4}[A-Z]{3}$"))
            {
                errMatricula.SetError(txtMatricula, "Formato inválido");
                e.Cancel = true;
            }
            else
            {
                errMatricula.SetError(txtMatricula, "");
                e.Cancel = false;
            }
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                errModelo.SetError(txtModelo, "Formato inválido");
                e.Cancel = true;
            }
            else
            {
                errModelo.SetError(txtModelo, "");
                e.Cancel = false;
            }
        }
    }
}
