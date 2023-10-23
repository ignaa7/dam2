using System.Collections;

ArrayList numerosPrimos = new ArrayList();

int numero = 1;

while (numerosPrimos.Count < 5)
{
    int numDivisores = 0;

    for (int i = 2; i <= numero / 2; i++)
    {
        if (numero % i == 0) numDivisores++;
    }

    if (numDivisores == 0) numerosPrimos.Add(numero);

    numero++;
}

string cadenaNumerosPrimos = "";

foreach (int num in numerosPrimos)
{
    if (cadenaNumerosPrimos == "") cadenaNumerosPrimos += num;
    else cadenaNumerosPrimos += ", " + num;
}

Console.WriteLine(cadenaNumerosPrimos);