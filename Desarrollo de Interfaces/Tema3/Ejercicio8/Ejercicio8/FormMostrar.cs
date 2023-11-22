using Ejercicio8.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class FormMostrar : Form
    {
        private Banco BancoObjeto { get; set; }

        public FormMostrar()
        {
            InitializeComponent();

            BancoObjeto = Banco.getInstance();

            List<string> dnisClientes = BancoObjeto.GetDnis();

            cmbClientes.Items.AddRange(dnisClientes.ToArray());

            txtNombre.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtNumeroCuentaCorriente.ReadOnly = true;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
