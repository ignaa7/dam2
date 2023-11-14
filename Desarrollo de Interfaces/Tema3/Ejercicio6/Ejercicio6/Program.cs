Console.WriteLine("Introduzca el nombre del directorio");
string directory = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string directoryPath = Path.Combine(currentDirectory, directory);

if (Directory.Exists(directoryPath))
{
    if (Directory.GetFiles(directoryPath).Length > 0)
    {
        DateTime lastAccessTime;

        foreach (string file in Directory.GetFiles(directoryPath))
        {
            File.GetLastAccessTime(file);
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