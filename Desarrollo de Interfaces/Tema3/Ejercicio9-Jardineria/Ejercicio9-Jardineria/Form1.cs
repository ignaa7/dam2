namespace Ejercicio9_Jardineria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FormAgregarProducto().ShowDialog();
        }
    }
}