Console.WriteLine("Introduzca el nombre del directorio");
string directory = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string directoryPath = Path.Combine(currentDirectory, directory);

if (Directory.Exists(directoryPath))
{
    Console.WriteLine("Introduzca el nombre del subdirectorio");
    string subdirectory = Console.ReadLine();
    string subdirectoryPath = Path.Combine(directoryPath, subdirectory);

    Directory.CreateDirectory(subdirectoryPath);

    if (Directory.GetFiles(directoryPath).Length > 0)
    {
        Console.WriteLine("Introduzca una extensión de fichero");
        string extension = Console.ReadLine();

        foreach (string file in Directory.GetFiles(directoryPath))
        {
            if (file.EndsWith(extension))
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(subdirectoryPath, fileName);
                File.Copy(file, destinationFilePath, true);
            }
        }
    }
    else
    {
        Console.WriteLine("El directorio no contiene ningún archivo");
    }
}
else
{
    Console.WriteLine("No existe el directorio");
}