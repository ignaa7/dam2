using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal abstract class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string codigo, string nombre)
        {
            Precio = 0;
            Nombre = nombre;
            SetCodigo(codigo);
        }

        public Producto(string codigo, string nombre, double precio)
        {
            SetPrecio(precio);
            Nombre = nombre;
            SetCodigo(codigo);
        }

        public void SetCodigo(string codigo)
        {
            if (Regex.IsMatch(codigo, @"^[A-Z]{3}-\d{3}[A-Z]$")) Codigo = codigo;
            else throw new ExcepcionCodigo();
        }

        public void SetPrecio<T> (T precio)
        {
            if (precio is double) Precio = Convert.ToDouble(precio);
        }

        public virtual double Calcular(int cantidadProductos)
        {
            return cantidadProductos * Precio;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}\nNombre: {Nombre}\nPrecio: {Precio}\n";
        }
    }
}
