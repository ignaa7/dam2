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

        private void btnEliminarGama_Click(object sender, EventArgs e)
        {
            new FormEliminarGama().ShowDialog();
        }

        private void btnConsultarPedidosEntregados_Click(object sender, EventArgs e)
        {
            new FormConsultarProductosEntregados().ShowDialog();
        }

        private void btnConsultarEmpleadosJefe_Click(object sender, EventArgs e)
        {
            new FormConsultarEmpleados().ShowDialog();
        }
    }
}