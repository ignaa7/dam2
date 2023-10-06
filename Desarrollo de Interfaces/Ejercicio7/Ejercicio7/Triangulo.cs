using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Triangulo
    {
        public double LongitudLadosIguales { get; set; }

        public double LongitudLadoDistinto { get; set; }

        public double Altura { get; set; }

        public Triangulo(double longitudLadosIguales, double longitudLadoDistinto)
        {
            LongitudLadosIguales = longitudLadosIguales;
            LongitudLadoDistinto = longitudLadoDistinto;
            Altura = Math.Sqrt(Math.Pow(longitudLadosIguales, 2) - Math.Pow(longitudLadoDistinto / 2, 2));
        }

        public double CalcularPerimetro()
        {
            return LongitudLadosIguales * 2 + LongitudLadoDistinto;
        }

        public double CalcularArea()
        {
            return LongitudLadoDistinto * Altura / 2;
        }
    }
}
