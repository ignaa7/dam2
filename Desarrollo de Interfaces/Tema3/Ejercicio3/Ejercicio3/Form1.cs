using AdminIES.forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FormEstudiante formEstudiante = new FormEstudiante();
            formEstudiante.ShowDialog();
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            FormCiclo formCiclo = new FormCiclo();
            formCiclo.ShowDialog();
        }
    }
}