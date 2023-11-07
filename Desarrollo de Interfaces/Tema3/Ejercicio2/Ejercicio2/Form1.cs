using System.Text.RegularExpressions;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNif_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNif.Text, @"^\d{8}[A-Z]$"))
            {
                errNif.SetError(txtNif, "NIF inválido");
                e.Cancel = true;
            }
            else
            {
                errNif.SetError(txtNif, "");
                e.Cancel = false;
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errName.SetError(txtName, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errName.SetError(txtName, "");
                e.Cancel = false;
            }
        }

        private void txtSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errSurname.SetError(txtSurname, "Campo obligatorio");
                e.Cancel = true;
            }
            else
            {
                errSurname.SetError(txtSurname, "");
                e.Cancel = false;
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^\w+@\w+.\w+$"))
            {
                errEmail.SetError(txtEmail, "Email inválido");
                e.Cancel = true;
            }
            else
            {
                errEmail.SetError(txtEmail, "");
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                lstStudents.Items.Add(txtName.Text);
                MessageBox.Show("Alumno añadido correctamente");
            }
            else
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes|*.jpg;*.gif;*png";
            openFileDialog.Title = "Seleccione una imagen";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNif.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}