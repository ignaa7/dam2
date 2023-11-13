Console.WriteLine("Introduzca el nombre del archivo");
string file = Console.ReadLine();
Console.WriteLine("Introduzca la frase a buscar");
string phrase = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string filePath = Path.Combine(currentDirectory, file);

if (File.Exists(filePath))
{
    string[] lines = File.ReadAllLines(filePath);

    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Contains(phrase))
        {
            Console.WriteLine($"{i + 1} ");
        }
    }

}