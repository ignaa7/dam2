using Ejercicio5;
using System.Collections;

Random random = new Random();

int numFilas = random.Next(1, 11);
int numColumnas = random.Next(1, 11);

Matriz matrizClase = new Matriz(numFilas, numColumnas);
int[,] matriz = matrizClase.generarMatriz();

for (int i = 0; i < numFilas; i++)
{
    for (int j = 0; j < numColumnas; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

var resultados = matrizClase.calcularPuntoSilla(matriz);

int puntoSilla = resultados.Item1;
Dictionary<string, int> posicionesPuntoSilla = resultados.Item2;

if (puntoSilla == 0) Console.WriteLine("No hay ningún punto de silla");
else
{
    Console.WriteLine("Punto de silla: " + puntoSilla);
    Console.WriteLine("Posiciones: " + posicionesPuntoSilla["fila"] + ", " + posicionesPuntoSilla["columna"]);
}