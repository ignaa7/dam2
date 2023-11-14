Console.WriteLine("Introduzca una extensión de fichero");
string extension = Console.ReadLine();

string currentDirectoryPath = Environment.CurrentDirectory;

if (Directory.GetFiles(currentDirectoryPath).Length > 0)
{
    foreach (string file in Directory.GetFiles(currentDirectoryPath))
    {
        Console.WriteLine(Path.GetFileName(file));
    }

    char borrar;

    do
    {
        Console.WriteLine($"¿Desea borrar todos los ficheros con la extensión {extension}?\ns / n");
        borrar = Console.ReadLine()[0];
    } while (borrar != 'n' && borrar != 's');

    if ( borrar == 's' )
    {
        foreach (string file in Directory.GetFiles(currentDirectoryPath))
        {
            if (Path.GetExtension(file).Equals($".{extension}"))
            {
                File.Delete(file);
            }
        }

        foreach (string file in Directory.GetFiles(currentDirectoryPath))
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}