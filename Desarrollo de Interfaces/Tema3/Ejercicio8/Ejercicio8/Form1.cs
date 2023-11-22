namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FormAgregar().ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new FormModificar().ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            new FormEliminar().ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            new FormMostrar().ShowDialog();
        }
    }
}