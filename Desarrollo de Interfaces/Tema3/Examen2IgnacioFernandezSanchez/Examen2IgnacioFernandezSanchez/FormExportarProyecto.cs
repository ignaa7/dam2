using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2IgnacioFernandezSanchez
{
    public partial class FormExportarProyecto : Form
    {
        public FormExportarProyecto()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProyecto.Text;

            if (!string.IsNullOrEmpty(nombre) )
            {
                string currentDirectory = Environment.CurrentDirectory;
                string directoryPath = Path.Combine(currentDirectory, nombre);

                string fileInfoPath = Path.Combine(directoryPath, $"{nombre}Info.xml");
                string fileInfoText = File.ReadAllText(fileInfoPath);

                string filePath = Path.Combine(directoryPath, $"{nombre}.xml");
                string fileText = File.ReadAllText(filePath);


                string exportadosDirectoryPath = Path.Combine(currentDirectory, "ProyectosExportados");
                string newDirectoryPath = Path.Combine(exportadosDirectoryPath, nombre);

                Directory.CreateDirectory(newDirectoryPath);

                string newFileInfoPath = Path.Combine(newDirectoryPath, $"{nombre}Info.xml");
                File.WriteAllText(newFileInfoPath, fileInfoText);

                string newFilePath = Path.Combine(newDirectoryPath, $"{nombre}.xml");
                File.WriteAllText(newFilePath, fileText);

                MessageBox.Show("Proyecto exportado");
                Close();
            }
        }
    }
}
