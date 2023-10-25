using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class ProductoNoPerecedero : Producto
    {
        public int Tipo { get; set; }

        public ProductoNoPerecedero(int tipo, string codigo, string nombre) : base(codigo, nombre)
        {
            Tipo = tipo;
        }

        public ProductoNoPerecedero(int tipo, string codigo, string nombre, double precio) : base(codigo, nombre, precio)
        {
            Tipo = tipo;
        }

        public override double Calcular(int cantidadProductos)
        {
            return base.Calcular(cantidadProductos);
        }

        public override string ToString()
        {
            return $"No perecedero\n{base.ToString()}Tipo: {Tipo}\n";
        }
    }
}
