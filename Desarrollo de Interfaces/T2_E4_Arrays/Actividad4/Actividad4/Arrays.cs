using System;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {
            int numeroMenor;

            if (array.Length == 0) numeroMenor = 0;
            else numeroMenor = array[0];

            foreach (int i in array)
            {
                if (i < numeroMenor) numeroMenor = i;
            }

            return numeroMenor;

            throw new NotImplementedException();
        }
        public static int[] invertirArray(int[] array)
        {
            int aux;
            int j = 0;

            for (int i = 0; i < array.Length / 2; i++)
            {
                aux = array[i];
                array[i] = array[j];
                array[j] = aux;
            }

            return array;

            throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {
            int posicion = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    if (posicion == -1) posicion = i;
                    else
                    {
                        if (valor != array[posicion]) posicion = i;
                    }
                }
            }

            return posicion;

            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
