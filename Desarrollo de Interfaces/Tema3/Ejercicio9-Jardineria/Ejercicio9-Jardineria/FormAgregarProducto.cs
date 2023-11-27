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

namespace Ejercicio9_Jardineria
{
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                errCodigo.SetError(txtCodigo, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errCodigo.SetError(txtCodigo, "");
                e.Cancel = false;
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
            }
        }

        private void cmbGama_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGama.SelectedIndex == -1)
            {
                errGama.SetError(txtNombre, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errGama.SetError(txtNombre, "");
                e.Cancel = false;
            }
        }

        private void txtCantidadStock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidadStock.Text))
            {
                errCantidadStock.SetError(txtCantidadStock, "Campo obligatorio");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtCantidadStock.Text, @"^\d*$"))
            {
                errCantidadStock.SetError(txtCantidadStock, "Debe introducir un número");
                e.Cancel = true;
            }
            else
            {
                errCantidadStock.SetError(txtCantidadStock, "");
                e.Cancel = false;
            }
        }

        private void txtPrecioVenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                errPrecioVenta.SetError(txtPrecioVenta, "Campo obligatorio");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrecioVenta.Text, @"^\d*.?\d*$"))
            {
                errPrecioVenta.SetError(txtPrecioVenta, "Debe introducir un número");
                e.Cancel = true;
            }
            else
            {
                errPrecioVenta.SetError(txtPrecioVenta, "");
                e.Cancel = false;
            }
        }

        private void txtPrecioProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtPrecioProveedor.Text, @"^\d*.?\d*$") && !txtPrecioProveedor.Equals(""))
            {
                errPrecioProveedor.SetError(txtPrecioProveedor, "Solo puede introducir un número");
                e.Cancel = true;
            }
            else
            {
                errPrecioProveedor.SetError(txtPrecioProveedor, "");
                e.Cancel = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                //Servicio
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
