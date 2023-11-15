namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmNew_Click(object sender, EventArgs e)
        {
            if (!rtbText.Text.Equals(""))
            {
                DialogResult response = MessageBox.Show("¿Desea guardar el contenido?", "Guardar contenido", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (response)
                {
                    case DialogResult.Yes:
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                        saveFileDialog1.Title = "Save a Text File";
                        saveFileDialog1.FileName = "example.txt"; // Default file name (optional)

                        // Show the SaveFileDialog and get the result
                        DialogResult result = saveFileDialog1.ShowDialog();

                        // Process the result
                        if (result == DialogResult.OK)
                        {
                            // Get the selected file name and display it
                            string fileName = saveFileDialog1.FileName;
                            Console.WriteLine("File saved as: " + fileName);

                            // You can now write your data to the selected file, for example:
                            // File.WriteAllText(fileName, "Hello, world!");
                        }
                        else
                        {
                            Console.WriteLine("File saving canceled");
                        }
                        break;
                    case DialogResult.No:
                        Console.WriteLine("User clicked No");
                        // Perform actions for No
                        break;
                    case DialogResult.Cancel:
                        Console.WriteLine("User clicked Cancel");
                        // Perform actions for Cancel
                        break;
                }
            }
        }
    }
}