using AdminIES.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminIES.forms
{
    public partial class FormEstudiante : Form
    {
        CicloDLL cicloDLL;
        public FormEstudiante(CicloDLL ciclo)
        {
            cicloDLL = ciclo;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (cicloDLL.Agregar(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreo.Text, ))
                {
                    MessageBox.Show("Ciclo añadido correctamente");
                    GetCiclos();
                }
                else
                {
                    MessageBox.Show("Error al añadir el ciclo");
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos");
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

        private void txtPrimerApellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                errPrimerApellido.SetError(txtPrimerApellido, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errPrimerApellido.SetError(txtPrimerApellido, "");
                e.Cancel = false;
            }
        }

        private void txtSegundoApellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                errSegundoApellido.SetError(txtSegundoApellido, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errSegundoApellido.SetError(txtSegundoApellido, "");
                e.Cancel = false;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errCorreo.SetError(txtCorreo, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errCorreo.SetError(txtCorreo, "");
                e.Cancel = false;
            }
        }

        private void cmbCiclo_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCiclo.SelectedItem == null)
            {
                errCiclo.SetError(cmbCiclo, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errCiclo.SetError(cmbCiclo, "");
                e.Cancel = false;
            }
        }
    }
}