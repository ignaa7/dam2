using System.Collections;

Dictionary<string, ArrayList> paresImpares = new Dictionary<string, ArrayList>();

ArrayList pares = new ArrayList();

for (int i = 0; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        pares.Add(i);
    }
}

paresImpares.Add("par", pares);

ArrayList impares = new ArrayList();

for (int i = 0; i <= 50; i++)
{
    if (i % 2 != 0)
    {
        impares.Add(i);
    }
}

paresImpares.Add("impar", impares);

foreach (var i in paresImpares)
{
    Console.WriteLine("\n" + i.Key);

    foreach (var item in i.Value)
    {
        Console.Write(item + " ");
    }
}