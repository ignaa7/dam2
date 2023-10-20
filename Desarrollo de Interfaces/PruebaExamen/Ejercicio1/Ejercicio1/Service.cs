using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public static class Service
    {
        public static void imprimirNumeros(this int numeroInicio, int numeroFin)
        {
            for (int i = numeroInicio; i <= numeroFin; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
