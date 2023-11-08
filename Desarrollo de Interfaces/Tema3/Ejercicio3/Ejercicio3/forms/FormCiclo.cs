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
using System.Xml.Linq;

namespace AdminIES.forms
{
    public partial class FormCiclo : Form
    {
        CicloDLL cicloDLL;

        public FormCiclo(CicloDLL ciclo)
        {
            cicloDLL = ciclo;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            GetCiclos();
        }

        private void GetCiclos()
        {
            dgvCiclos.DataSource = cicloDLL.MostrarCiclos().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (cicloDLL.Agregar(txtNombreCiclo.Text))
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

        private void txtNombreCiclo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCiclo.Text))
            {
                errNombreCiclo.SetError(txtNombreCiclo, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errNombreCiclo.SetError(txtNombreCiclo, "");
                e.Cancel = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && this.ValidateChildren())
            {
                if (cicloDLL.Modificar(Convert.ToInt32(txtId.Text), txtNombreCiclo.Text))
                {
                    MessageBox.Show("Ciclo modificado correctamente");
                    GetCiclos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el ciclo");
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                if (cicloDLL.Borrar(Convert.ToInt32(txtId.Text)))
                {
                    MessageBox.Show("Ciclo borrado correctamente");
                    GetCiclos();
                }
                else
                {
                    MessageBox.Show("Error al borrar el ciclo");
                }
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
