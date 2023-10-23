Dictionary<int, string> miDiccionario = new Dictionary<int, string>();

miDiccionario.Add(0, "cero");
miDiccionario.Add(1, "uno");
miDiccionario.Add(2, "dos");
miDiccionario.Add(3, "tres");

var enumerator = miDiccionario.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}