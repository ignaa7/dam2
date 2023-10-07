using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.JuegoDados
{
    internal class Dado
    {
        private int valor;

        public Dado()
        {
            Tirar();
        }

        public void Tirar()
        {
            Random random = new Random();
            valor = random.Next(6) + 1;
        }

        public int Imprimir()
        {
            return valor;
        }
    }
}
