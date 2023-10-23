namespace _2_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtSalario.Text))
            {
                double? salarioLiquido = null;
                double salario = Convert.ToDouble(txtSalario.Text);

                if (rbtnGerente.Checked) salarioLiquido = salario - 0.2 * salario;
                if (rbtnSubGerente.Checked) salarioLiquido = salario - 0.15 * salario;
                if (rbtnSecretaria.Checked) salarioLiquido = salario - 0.05 * salario;

                if (salarioLiquido != null) MessageBox.Show("El sueldo líquido de " + txtNombre.Text + " es " + salarioLiquido.ToString() + "€");
            }
        }
    }
}