using AdminIES.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminIES.forms
{
    public partial class FormCiclo : Form
    {
        public FormCiclo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Agregar(txtNombreCiclo.Text);
        }
    }
}
