using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filePath;

        private void tsmNew_Click(object sender, EventArgs e)
        {
            if (!rtbText.Text.Equals(""))
            {
                DialogResult response = MessageBox.Show("¿Desea guardar el contenido?", "Guardar contenido", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (response)
                {
                    case DialogResult.Yes:
                        SaveFileDialog saveFileDialog = new SaveFileDialog();

                        saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de texto enriquecido (*.rtf)|*.rtf";
                        saveFileDialog.Title = "Guardar archivo";

                        DialogResult result = saveFileDialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            filePath = saveFileDialog.FileName;

                            File.WriteAllText(filePath, rtbText.Text);
                        }

                        rtbText.Text = "";

                        break;
                    case DialogResult.No:
                        rtbText.Text = "";
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de texto enriquecido (*.rtf)|*.rtf";
            openFileDialog.Title = "Abrir archivo";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                string content = File.ReadAllText(filePath);
                rtbText.Text = content;
            }
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de texto enriquecido (*.rtf)|*.rtf";
                saveFileDialog.Title = "Guardar archivo";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    File.WriteAllText(filePath, rtbText.Text);
                }
            }
            else
            {
                File.WriteAllText(filePath, rtbText.Text);
            }
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmCut_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void tsmCopy_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void tsmPaste_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }
    }
}