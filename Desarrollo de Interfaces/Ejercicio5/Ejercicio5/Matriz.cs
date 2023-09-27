using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Matriz
    {
        private int numFilas;
        private int numColumnas;

        public Matriz(int numFila, int numColumnas)
        {
            this.numFilas = numFila;
            this.numColumnas = numColumnas;
        }

        public int[,] generarMatriz()
        {
            int[,] matriz = new int[numFilas, numColumnas];
            Random random = new Random();

            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numColumnas; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            return matriz;
        }

        public (int, Dictionary<string, int>) calcularPuntoSilla(int[,] matriz)
        {
            int puntoSilla = 0;
            Dictionary<string, int> posicionesPuntoSilla = new Dictionary<string, int>();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int numMenorFila = 0;
                int posicionMenorFila = 0;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 0) numMenorFila = matriz[i, j];
                    else if (matriz[i, j] < numMenorFila)
                    {
                        numMenorFila = matriz[i, j];
                        posicionMenorFila = j;
                    }
                }

                int numMayorColumna = 0;
                int posicionMayorColumna = 0;

                for (int k = 0; k < matriz.GetLength(0); k++)
                {
                    if (k == 0) numMayorColumna = matriz[k, posicionMenorFila];
                    else if (matriz[k, posicionMenorFila] > numMayorColumna)
                    {
                        numMayorColumna = matriz[k, posicionMenorFila];
                        posicionMayorColumna = k;
                    }
                }

                if (numMenorFila == numMayorColumna)
                {
                    puntoSilla = numMenorFila;
                    posicionesPuntoSilla["fila"] = posicionMayorColumna;
                    posicionesPuntoSilla["columna"] = posicionMenorFila;
                }
            }

            return (puntoSilla, posicionesPuntoSilla);
        }
    }
}
