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
        EstudianteDLL estudianteDLL;
        public FormEstudiante(EstudianteDLL estudianteDLL)
        {
            this.estudianteDLL = estudianteDLL;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            foreach (DataRow fila in estudianteDLL.GetCiclos().Tables[0].Rows)
            {
                cmbCiclo.Items.Add(fila[0].ToString());
            }
        }

        private void GetEstudiantes()
        {
            dgvEstudiante.DataSource = estudianteDLL.MostrarEstudiantes().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (estudianteDLL.Agregar(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreo.Text, cmbCiclo.SelectedItem.ToString()!))
                {
                    MessageBox.Show("Estudiante añadido correctamente");
                    GetEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al añadir el estudiante");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClave.Text) && this.ValidateChildren())
            {
                if (estudianteDLL.Modificar(Convert.ToInt32(txtClave.Text), txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreo.Text, cmbCiclo.SelectedItem.ToString()!))
                {
                    MessageBox.Show("Estudiante modificado correctamente");
                    GetEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al modificar el estudiante");
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClave.Text))
            {
                if (estudianteDLL.Borrar(Convert.ToInt32(txtClave.Text)))
                {
                    MessageBox.Show("Estudiante borrado correctamente");
                    GetEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al borrar el estudiante");
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