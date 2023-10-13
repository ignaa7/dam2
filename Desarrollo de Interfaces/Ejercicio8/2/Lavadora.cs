using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Lavadora : Electrodomestico
    {
        private double CargaDefault = 5;

        public double Carga { get; set; }

        public Lavadora() : base()
        {
            Carga = CargaDefault;
        }

        public Lavadora(double precio, double peso) : base(precio, peso)
        {
            Carga = CargaDefault;
        }

        public Lavadora(double carga, double precio, Color color, char consumo, double peso) : base(precio, color, consumo, peso)
        {
            Carga = Carga;
        }

        public new double PrecioFinal()
        {
            if (Carga > 30)
            {
                PrecioBase += 50;
            }

            return base.PrecioFinal();
        }
    }
}
