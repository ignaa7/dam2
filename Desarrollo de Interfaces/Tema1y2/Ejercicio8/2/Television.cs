using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Television : Electrodomestico
    {
        private int resolucionDefault = 20;
        private bool SintonizadorTDTDefault = false;

        public int Resolucion { get; set; }
        public bool SintonizadorTDT { get; set; }

        public Television() : base()
        {
            Resolucion = resolucionDefault;
            SintonizadorTDT = SintonizadorTDTDefault;
        }

        public Television(double precio, double peso) : base(precio, peso)
        {
            Resolucion = resolucionDefault;
            SintonizadorTDT = SintonizadorTDTDefault;
        }

        public Television(int resolucion, bool sintonizadorTDT, double precio, Color color, char consumo, double peso) : base(precio, color, consumo, peso)
        {
            Resolucion = resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }

        public new double PrecioFinal()
        {
            if (Resolucion > 40)
            {
                PrecioBase *= 1.3;
            }
            if (SintonizadorTDT)
            {
                PrecioBase += 50;
            }

            return base.PrecioFinal();
        }
    }
}
