namespace Examen2IgnacioFernandezSanchez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new FormCrearProyecto().ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FormAgregarTarea().ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            new FormVerProyecto().ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            new FormExportarProyecto().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}