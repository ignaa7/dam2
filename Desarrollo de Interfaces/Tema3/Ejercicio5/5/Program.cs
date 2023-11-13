Console.WriteLine("Introduzca el nombre del primer archivo");
string file1 = Console.ReadLine();
Console.WriteLine("Introduzca el nombre del segundo archivo");
string file2 = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string file1Path = Path.Combine(currentDirectory, file1);
string file2Path = Path.Combine(currentDirectory, file2);

if (File.Exists(file1Path) && File.Exists(file2Path))
{
    string[] file1Lines = File.ReadAllLines(file1Path);
    string[] file2Lines = File.ReadAllLines(file2Path);
    string unionFilePath = Path.Combine(currentDirectory, "union.txt");

    int cont = 0;
    int cont1 = 0;
    int cont2 = 0;

    while (cont1 < file1Lines.Length && cont2 < file2Lines.Length)
    {
        if (cont % 2 == 0)
        {
            if (cont1 < file1Lines.Length)
            {
                using StreamWriter writer = File.AppendText(unionFilePath);
                writer.WriteLine(file1Lines[cont1]);
                cont1++;
            }
        }
        else
        {
            if (cont2 < file2Lines.Length)
            {
                using StreamWriter writer = File.AppendText(unionFilePath);
                writer.WriteLine(file2Lines[cont2]);
                cont2++;
            }
        }

        cont++;
    }
}