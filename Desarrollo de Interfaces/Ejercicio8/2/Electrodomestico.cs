using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal abstract class Electrodomestico
    {
        Color colorDefault = Color.White;
        const char consumoDefault = 'F';
        const double precioBaseDefault = 100;
        const double pesoDefault = 5;

        public double PrecioBase { get; set; }
        public Color Color { get; set; }
        public char Consumo { get; set; }
        public double Peso { get; set; }

        public Electrodomestico()
        {
            PrecioBase = precioBaseDefault;
            Color = colorDefault;
            Consumo = consumoDefault;
            Peso = pesoDefault;
        }

        public Electrodomestico(double precio, double peso)
        {
            PrecioBase = precio;
            Color = colorDefault;
            Consumo = consumoDefault;
            Peso = peso;
        }

        public Electrodomestico(double precio, Color color, char consumo, double peso)
        {
            PrecioBase = precio;
            Color = ComprobarColor(color);
            Consumo = ComprobarConsumoEnergia(consumo);
            Peso = peso;
        }

        private Color ComprobarColor(Color color)
        {
            if (color != Color.White && color != Color.Black && color != Color.Red && color != Color.Blue && color != Color.Gray)
            {
                color = colorDefault;
            }

            return color;
        }

        private char ComprobarConsumoEnergia(char consumo)
        {
            switch (consumo)
            {
                case 'A':
                    break;
                case 'B':
                    break;
                case 'C':
                    break;
                case 'D':
                    break;
                case 'E':
                    break;
                case 'F':
                    break;
                default:
                    consumo = consumoDefault;
                    break;
            }

            return consumo;
        }

        public double PrecioFinal()
        {
            double precioFinal = PrecioBase;

            switch (Consumo)
            {
                case 'A':
                    precioFinal += 100;
                    break;
                case 'B':
                    precioFinal += 80;
                    break;
                case 'C':
                    precioFinal += 60;
                    break;
                case 'D':
                    precioFinal += 50;
                    break;
                case 'E':
                    precioFinal += 30;
                    break;
                case 'F':
                    precioFinal += 10;
                    break;
                default:
                    break;
            }

            if (Peso >= 0)
            {
                if (Peso <= 19)
                {
                    precioFinal += 10;
                }
                else if (Peso <= 49)
                {
                    precioFinal += 50;
                }
                else if (Peso <= 79)
                {
                    precioFinal += 80;
                }
                else
                {
                    precioFinal += 100;
                }
            }

            return precioFinal;
        }
    }
}
