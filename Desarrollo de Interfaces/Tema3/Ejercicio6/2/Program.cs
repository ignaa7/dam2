Console.WriteLine("Introduzca el nombre del directorio");
string directory = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string directoryPath = Path.Combine(currentDirectory, directory);

if (Directory.Exists(directoryPath))
{
    if (Directory.GetFiles(directoryPath).Length > 0)
    {
        Console.WriteLine("Introduzca una extensión de fichero");
        string extension = Console.ReadLine();

        foreach (string file in Directory.GetFiles(directoryPath))
        {
            if (file.EndsWith(extension))
            {
                Console.WriteLine(Path.GetFileName(file));
            }
            if (Path.GetExtension(file).Equals($".{extension}"))
            {
                Console.WriteLine(Path.GetFileName(file));
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