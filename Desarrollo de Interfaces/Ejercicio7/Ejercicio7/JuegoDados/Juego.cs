using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.JuegoDados
{
    internal class Juego
    {
        public static Dado[] dados { get; set; } = new Dado[3];

        public static dynamic Jugar()
        {
            for (int i = 0; i < 3; i++)
            {
                dados[i] = new Dado();
            }

            int dado1 = dados[0].Imprimir();
            int dado2 = dados[1].Imprimir();
            int dado3 = dados[2].Imprimir();

            string mensaje = "Perdió";

            if (dado1 == dado2 && dado2 == dado3) mensaje = "Ganó";

            return new
            {
                dado1,
                dado2,
                dado3,
                mensaje
            };
        }
    }
}
