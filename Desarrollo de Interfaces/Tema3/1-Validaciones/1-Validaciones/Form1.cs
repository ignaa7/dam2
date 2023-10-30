using System.ComponentModel;
using System.Text.RegularExpressions;

namespace _1_Validaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Tecla inválida");
                e.Handled = true;
            }
        }

        private void textBox2_Validating_1(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch())
            {
                errorDNI.setError(textBox3, "Formato incorrecto");
                e.Cancel = true;
            }
            else
            {
                errorDNI.setError(textBox3, "");
                e.Cancel = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox("OK");
            }
            else
            {
                MessageBox("NO");
            }
        }
    }
}