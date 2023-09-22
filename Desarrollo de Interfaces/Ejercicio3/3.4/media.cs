using System.Collections;

ArrayList numeros = new ArrayList();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Introduzca un número");
    numeros.Add(Convert.ToDouble(Console.ReadLine()));
}

double suma = 0;

foreach (double numero in numeros)
{
    suma += numero;
}

Console.WriteLine("La media es " + suma / numeros.Count);