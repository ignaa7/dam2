Console.WriteLine("Introduzca una extensión de fichero");
string extension = Console.ReadLine();

string currentDirectoryPath = Environment.CurrentDirectory;

if (Directory.GetFiles(currentDirectoryPath).Length > 0)
{
    foreach (string file in Directory.GetFiles(currentDirectoryPath))
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