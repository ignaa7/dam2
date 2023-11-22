using Ejercicio8.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class FormModificar : Form
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumeroCuentaCorriente { get; set; }

        private Banco BancoObjeto { get; set; }

        public FormModificar()
        {
            InitializeComponent();

            BancoObjeto = Banco.getInstance();

            List<string> dnisClientes = BancoObjeto.GetDnis();

            cmbClientes.Items.AddRange(dnisClientes.ToArray());
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            if (cmbClientes.SelectedItem != null)
            {
                cliente = BancoObjeto.GetCliente(cmbClientes.SelectedItem as string);

                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtEdad.Text = cliente.Edad.ToString();
                txtTelefono.Text = cliente.Telefono;
                txtNumeroCuentaCorriente.Text = cliente.NumeroCuentaCorriente;
            }
        }

        private void cmbClientes_Validating(object sender, CancelEventArgs e)
        {
            if (cmbClientes.SelectedItem == null)
            {
                errDni.SetError(cmbClientes, "Formato de DNI incorrecto");
                e.Cancel = true;
            }
            else
            {
                errDni.SetError(cmbClientes, "");
                e.Cancel = false;

                Dni = cmbClientes.SelectedItem as string;
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
                BancoObjeto.ModificarCliente(Dni, Nombre, Direccion, Edad, Telefono, NumeroCuentaCorriente);

                MessageBox.Show("Cliente modificado correctamente");
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
