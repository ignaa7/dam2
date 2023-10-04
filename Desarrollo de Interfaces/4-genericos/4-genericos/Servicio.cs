using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_genericos
{
    internal class Servicio
    {
        public static T[] crearCopiaArrayGenerico<T>(T[] array)
        {
            T[] copiaArray = Array.Empty<T>();
            array.CopyTo(copiaArray, 0);

            return copiaArray;
        }
    }
}
