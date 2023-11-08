using AdminIES.DLL;
using AdminIES.forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Conexion conexion;
        EstudianteDLL estudianteDLL;
        CicloDLL cicloDLL;
        FormEstudiante formEstudiante;
        FormCiclo formCiclo;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            conexion = new Conexion();

            estudianteDLL = new EstudianteDLL(conexion);
            cicloDLL = new CicloDLL(conexion);

            formEstudiante = new FormEstudiante(cicloDLL);
            formCiclo = new FormCiclo(cicloDLL);
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            formEstudiante.ShowDialog();
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            formCiclo.ShowDialog();
        }
    }
}