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
    public partial class FormCrearProyecto : Form
    {
        public FormCrearProyecto()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string fechaInicio = txtFechaInicio.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion) && !string.IsNullOrEmpty(fechaInicio))
            {
                string currentDirectory = Environment.CurrentDirectory;
                string directoryPath = Path.Combine(currentDirectory, nombre);

                Directory.CreateDirectory(directoryPath);

                string filePath = Path.Combine(directoryPath, $"{nombre}Info.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(Proyecto));

                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, new Proyecto(nombre, descripcion, fechaInicio));
                }

                MessageBox.Show("Proyecto creado");
                Close();
            }
        }
    }
}
