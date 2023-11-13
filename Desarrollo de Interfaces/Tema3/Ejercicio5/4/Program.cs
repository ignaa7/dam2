string currentDirectory = Environment.CurrentDirectory;
string filePath = Path.Combine(currentDirectory, "marks.txt");

if (File.Exists(filePath))
{
    string[] lines = File.ReadAllLines(filePath);

    double mathematicsMarksAmount = 0;
    double bestComputingMark = 0;
    string bestComputingStudent = "";

    for (int i = 0; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] parts = line.Split(' ');

        string studentName = parts[0];
        double mathematicsMark = Convert.ToDouble(parts[2]);
        double computingMark = Convert.ToDouble(parts[4]);

        mathematicsMarksAmount += mathematicsMark;

        if (i == 0 || computingMark > bestComputingMark)
        {
            bestComputingMark = computingMark;
            bestComputingStudent = studentName;
        }
    }

    string content = $"Nota media en matemáticas: {mathematicsMarksAmount/lines.Length}\nMejor nota en informática: {bestComputingMark}\nAlumno: {bestComputingStudent}";

    string newFilePath = Path.Combine(currentDirectory, "data.txt");
    File.WriteAllText(newFilePath, content);
}