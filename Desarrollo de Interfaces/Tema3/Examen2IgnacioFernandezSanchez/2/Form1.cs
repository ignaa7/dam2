namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            new FormAgregar().ShowDialog();
        }

        private void btnModificarEstadoVehiculo_Click(object sender, EventArgs e)
        {
            new FormModificarEstadoVehiculo().ShowDialog();
        }

        private void btnVisualizarInventarioVehiculos_Click(object sender, EventArgs e)
        {
            new FormVerVehiculos().ShowDialog();
        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            new FormAgregarMantenimiento().ShowDialog();
        }

        private void btnVisualizarMantenimientos_Click(object sender, EventArgs e)
        {
            new FormVerMantenimientos().ShowDialog();
        }
    }
}