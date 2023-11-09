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
        byte[] imagenByte;

        public FormEstudiante(EstudianteDLL estudianteDLL)
        {
            this.estudianteDLL = estudianteDLL;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            foreach (DataRow fila in estudianteDLL.GetCiclos().Tables[0].Rows)
            {
                cmbCiclo.Items.Add(fila[0].ToString());
            }

            GetEstudiantes();
        }

        private void GetEstudiantes()
        {
            dgvEstudiante.DataSource = estudianteDLL.MostrarEstudiantes().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string imagen = ImageToBase64(pbImagen.Image, pbImagen.Image.RawFormat);

                if (estudianteDLL.Agregar(txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreo.Text, cmbCiclo.SelectedItem.ToString()!, imagen))
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoryStream = new MemoryStream();
                pbImagen.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte = memoryStream.ToArray();
            }
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using MemoryStream ms = new MemoryStream();
            // Convert Image to byte[]
            image.Save(ms, format);
            byte[] imageBytes = ms.ToArray();
            // Convert byte[] to base 64 string
            string base64String = Convert.ToBase64String(imageBytes).ToString();
            return base64String;
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

    }
}