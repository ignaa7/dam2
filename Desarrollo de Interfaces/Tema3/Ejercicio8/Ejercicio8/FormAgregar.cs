using Ejercicio8.Modelo;
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

namespace Ejercicio8
{
    public partial class FormAgregar : Form
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumeroCuentaCorriente { get; set; }

        private Banco BancoObjeto { get; set; }

        public FormAgregar()
        {
            InitializeComponent();

            BancoObjeto = Banco.getInstance();
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDni.Text, @"^\d{8}[A-Z]$"))
            {
                errDni.SetError(txtDni, "Formato de DNI incorrecto");
                e.Cancel = true;
            }
            else
            {
                errDni.SetError(txtDni, "");
                e.Cancel = false;

                Dni = txtDni.Text;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errNombre.SetError(txtNombre, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errNombre.SetError(txtNombre, "");
                e.Cancel = false;

                Nombre = txtNombre.Text;
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errNombre.SetError(txtDireccion, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errNombre.SetError(txtDireccion, "");
                e.Cancel = false;

                Direccion = txtDireccion.Text;
            }
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(txtEdad.Text, out int edad))
            {
                errNombre.SetError(txtEdad, "Debe introducir un número entero");
                e.Cancel = true;
            }
            else
            {
                errNombre.SetError(txtEdad, "");
                e.Cancel = false;

                Edad = edad;
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtTelefono.Text, @"^\d{9}$"))
            {
                errDni.SetError(txtTelefono, "Debe introducir 9 dígitos");
                e.Cancel = true;
            }
            else
            {
                errDni.SetError(txtTelefono, "");
                e.Cancel = false;

                Telefono = txtTelefono.Text;
            }
        }

        private void txtNumeroCuentaCorriente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroCuentaCorriente.Text))
            {
                errNombre.SetError(txtNumeroCuentaCorriente, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errNombre.SetError(txtNumeroCuentaCorriente, "");
                e.Cancel = false;

                NumeroCuentaCorriente = txtNumeroCuentaCorriente.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                BancoObjeto.AgregarCliente(Dni, Nombre, Direccion, Edad, Telefono, NumeroCuentaCorriente);

                MessageBox.Show("Cliente añadido correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
