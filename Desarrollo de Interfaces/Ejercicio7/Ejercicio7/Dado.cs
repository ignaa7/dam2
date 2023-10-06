using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Dado
    {
        private int valor;

        public void Tirar()
        {
            Random random = new Random();
            valor = random.Next();
        }

        public int Imprimir()
        {
            return valor;
        }
    }
}
