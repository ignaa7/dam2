Console.WriteLine("Introduzca el nombre del fichero");
string file = Console.ReadLine();

Console.WriteLine("Introduzca la nueva extensión de fichero");
string extension = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string filePath = Path.Combine(currentDirectory, file);

if (File.Exists(filePath))
{
    string newFilePath = Path.ChangeExtension(filePath, extension);

    File.Move(filePath, newFilePath);
}