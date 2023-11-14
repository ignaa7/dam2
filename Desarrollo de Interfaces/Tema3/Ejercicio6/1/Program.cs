Console.WriteLine("Introduzca el nombre del directorio");
string directory = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string directoryPath = Path.Combine(currentDirectory, directory);

if (Directory.Exists(directoryPath))
{
    if (Directory.GetFiles(directoryPath).Length > 0)
    {
        DateTime lastAccessTime = DateTime.MinValue;
        string lastFileName = "";

        foreach (string file in Directory.GetFiles(directoryPath))
        {
            DateTime accessTime = File.GetLastAccessTime(file);

            if (accessTime > lastAccessTime)
            {
                lastAccessTime = accessTime;
                lastFileName = Path.GetFileName(file);
            }
        }

        Console.WriteLine($"Último fichero accedido: {lastFileName}\nFecha último acceso: {lastAccessTime}");
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