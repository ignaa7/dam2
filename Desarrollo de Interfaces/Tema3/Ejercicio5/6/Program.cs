using System.Collections;

string currentDirectory = Environment.CurrentDirectory;
string filePath = Path.Combine(currentDirectory, "enteros.txt");

if (File.Exists(filePath))
{
    string[] lines = File.ReadAllLines(filePath);

    ArrayList numbers = new ArrayList();
    int contNumbers = 0;
    int numbersAddition = 0;

    foreach (string line in lines)
    {
        string[] parts = line.Split(new char[] { ' ', ',' });

        foreach (string part in parts)
        {
            if (int.TryParse(part, out int number))
            {
                numbers.Add(number);
                contNumbers++;
                numbersAddition += number;
            }
        }
    }

    string content = $"Números: ";

    foreach (int number in numbers)
    {
        content += $"{number} ";
    }

    content += $"\nCantidad de números: {contNumbers}\nSuma: {numbersAddition}";

    string newFilePath = Path.Combine(currentDirectory, "data.txt");
    File.WriteAllText(newFilePath, content);
}