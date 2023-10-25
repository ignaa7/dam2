using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class ProductoPerecedero : Producto
    {
        public int DiasACaducar { get; set; }

        public ProductoPerecedero(int diasACaducar, string codigo, string nombre) : base(codigo, nombre)
        {
            DiasACaducar = diasACaducar;
        }

        public ProductoPerecedero(int diasACaducar, string codigo, string nombre, double precio) : base(codigo, nombre, precio)
        {
            DiasACaducar = diasACaducar;
        }

        public override double Calcular(int cantidadProductos)
        {
            double precio = base.Calcular(cantidadProductos);

            if (DiasACaducar == 1) precio *= 0.75;
            else if (DiasACaducar == 2) precio *= 2 / 3;
            else if (DiasACaducar == 3) precio *= 0.5;

            return precio;
        }

        public override string ToString()
        {
            return $"Perecedero\n{base.ToString()}Días a caducar: {DiasACaducar}\n";
        }
    }
}
