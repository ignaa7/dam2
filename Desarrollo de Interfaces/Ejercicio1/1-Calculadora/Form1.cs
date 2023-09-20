namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBasicas.Enabled = false;
            lstAvanzadas.Enabled = false;
        }

        private void rbtnBasicas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBasicas.Checked == true)
            {
                cmbBasicas.Enabled = true;
                lstAvanzadas.Enabled = false;
                lstAvanzadas.SelectedIndex = -1;
            }
        }

        private void rbtnAvanzadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAvanzadas.Checked == true)
            {
                cmbBasicas.Enabled = false;
                lstAvanzadas.Enabled = true;
                cmbBasicas.SelectedIndex = -1;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double? resultado = null;

            if (!string.IsNullOrEmpty(txtNum1.Text) && !string.IsNullOrEmpty(txtNum2.Text))
            {
                String operacion = "";
                double num1, num2;
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);

                if (rbtnBasicas.Checked == true)
                {
                    if (cmbBasicas.SelectedIndex == 0)
                    {
                        resultado = num1 + num2;
                        operacion = "+";
                    }
                    else if (cmbBasicas.SelectedIndex == 1)
                    {
                        resultado = num1 - num2;
                        operacion = "-";
                    }
                }
                else if (rbtnAvanzadas.Checked == true) 
                {
                    if (lstAvanzadas.SelectedIndex == 0)
                    {
                        resultado = num1 * num2;
                        operacion = "*";
                    }
                    else if (lstAvanzadas.SelectedIndex == 1)
                    {
                        resultado = num1 / num2;
                        operacion = "/";
                    }
                }

                if (resultado != null) MessageBox.Show(num1.ToString() + " " + operacion + " " + num2.ToString() + " = " + resultado.ToString(), "Respuesta");
            }
        }
    }
}