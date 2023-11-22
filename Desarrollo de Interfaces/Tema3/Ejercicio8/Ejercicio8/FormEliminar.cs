using Ejercicio8.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class FormEliminar : Form
    {
        private Banco BancoObjeto { get; set; }
        public FormEliminar()
        {
            InitializeComponent();

            BancoObjeto = Banco.getInstance();

            List<string> dnisClientes = BancoObjeto.GetDnis();

            cmbClientes.Items.AddRange(dnisClientes.ToArray());
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
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                BancoObjeto.EliminarCliente(cmbClientes.SelectedItem as string);

                MessageBox.Show("Cliente eliminado correctamente");
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
