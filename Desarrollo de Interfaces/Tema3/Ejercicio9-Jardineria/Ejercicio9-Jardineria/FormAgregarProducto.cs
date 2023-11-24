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
                errCodigo.SetError(txtNombre, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errCodigo.SetError(txtNombre, "");
                e.Cancel = false;
            }
        }

        private void cmbGama_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGama)
            {
                errCodigo.SetError(txtNombre, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errCodigo.SetError(txtNombre, "");
                e.Cancel = false;
            }
        }
    }
}
