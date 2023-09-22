using System.Collections;

ArrayList numeros = new ArrayList();

for (int i = 2; i <= 50; i+=2)
{
    if (i % 3 == 0) numeros.Add(i);
}

string cadenaNumeros = "";

foreach (int num in numeros)
{
    if (cadenaNumeros == "") cadenaNumeros += num;
    else cadenaNumeros += ", " + num;
}

Console.WriteLine(cadenaNumeros);