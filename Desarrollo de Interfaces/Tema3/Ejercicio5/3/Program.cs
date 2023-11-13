Console.WriteLine("Introduzca el nombre del archivo que quiere leer");
string fileToRead = Console.ReadLine();
Console.WriteLine("Introduzca el nombre del archivo que quiere escribir");
string fileToWrite = Console.ReadLine();

string currentDirectory = Environment.CurrentDirectory;
string fileToReadPath = Path.Combine(currentDirectory, fileToRead);
string fileToWritePath = Path.Combine(currentDirectory, fileToWrite);

if (File.Exists(fileToReadPath) && File.Exists(fileToWritePath))
{
    File.Copy(fileToReadPath, fileToWrite, true);
}
