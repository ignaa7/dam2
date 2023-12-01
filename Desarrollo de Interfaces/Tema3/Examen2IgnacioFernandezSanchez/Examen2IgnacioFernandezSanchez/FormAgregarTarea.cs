using Examen2IgnacioFernandezSanchez.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Examen2IgnacioFernandezSanchez
{
    public partial class FormAgregarTarea : Form
    {
        public FormAgregarTarea()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreProyecto = txtNombreProyecto.Text;
            string nombreTarea = txtNombreTarea.Text;
            string descripcion = txtDescripcion.Text;
            string fechaVencimiento = txtFechaVencimiento.Text;
            string estado = txtEstado.Text;

            if (!string.IsNullOrEmpty(nombreProyecto) && !string.IsNullOrEmpty(nombreTarea) && !string.IsNullOrEmpty(descripcion) && !string.IsNullOrEmpty(fechaVencimiento) && !string.IsNullOrEmpty(estado))
            {
                string currentDirectory = Environment.CurrentDirectory;
                string directoryPath = Path.Combine(currentDirectory, nombreProyecto);
                string filePath = Path.Combine(directoryPath, $"{nombreProyecto}.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(Tarea));

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, new Tarea(nombreTarea, descripcion, fechaVencimiento, estado));
                }

                MessageBox.Show("Tarea añadida");
                Close();
            }
        }
    }
}
