using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tsslCurrentLine.Text = $"Línea {rtbText.GetLineFromCharIndex(rtbText.SelectionStart)}";
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

        private void tsmSearch_Click(object sender, EventArgs e)
        {
            rtbText.SelectAll();
            rtbText.SelectionBackColor = rtbText.BackColor;

            int index = rtbText.Text.IndexOf(tsmSearchBox.Text);

            while (index != -1)
            {
                rtbText.Select(index, tsmSearchBox.Text.Length);
                rtbText.SelectionBackColor = Color.Yellow;

                if (index < rtbText.Text.Length - 1)
                {
                    index = rtbText.Text.IndexOf(tsmSearchBox.Text, index + 1);
                }
                else
                {
                    index = -1;
                }
            }

            ActiveControl = null;
        }

        private void tsmFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                rtbText.SelectionFont = fontDialog.Font;
            }
        }

        private void tsmColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                rtbText.SelectionColor = colorDialog.Color;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            tsmNew_Click(sender, e);
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            tsmOpen_Click(sender, e);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            tsmSave_Click(sender, e);
        }

        private void tsbCut_Click(object sender, EventArgs e)
        {
            tsmCut_Click(sender, e);
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            tsmCopy_Click(sender, e);
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            tsmPaste_Click(sender, e);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            rtbText.SelectAll();
            rtbText.SelectionBackColor = rtbText.BackColor;

            int index = rtbText.Text.IndexOf(tsbSearchBox.Text);

            while (index != -1)
            {
                rtbText.Select(index, tsbSearchBox.Text.Length);
                rtbText.SelectionBackColor = Color.Yellow;

                if (index < rtbText.Text.Length - 1)
                {
                    index = rtbText.Text.IndexOf(tsbSearchBox.Text, index + 1);
                }
                else
                {
                    index = -1;
                }
            }

            ActiveControl = null;
        }

        private void tsbFont_Click(object sender, EventArgs e)
        {
            tsmFont_Click(sender, e);
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            tsmColor_Click(sender, e);
        }

        private void rtbText_SelectionChanged(object sender, EventArgs e)
        {
            tsslCurrentLine.Text = $"Línea {rtbText.GetLineFromCharIndex(rtbText.SelectionStart)}";
        }
    }
}