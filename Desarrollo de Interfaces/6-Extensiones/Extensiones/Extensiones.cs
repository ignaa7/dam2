using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    internal static class Extensiones
    {
        internal static int ContarPalabras(this string cadena)
        {
            return cadena.Split(" ").Count();
        }

        internal static string ImprimirArray<T>(this List<T> array)
        {
            string cadena = "";

            foreach (T item in array)
            {
                cadena += $"{item}, ";
            }

            cadena = cadena.Remove(cadena.Length-2, 2);

            return cadena;
        }
    }
}
