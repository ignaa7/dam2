using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasUnitarias
{
    public class Metodos
    {
        public static string devolverString(string[] vs)
        {
            string cadena = "";

            foreach (string parteCadena in vs)
            {
                cadena += parteCadena;
            }

            return cadena;

            throw new NotImplementedException();
        }
    }
}
