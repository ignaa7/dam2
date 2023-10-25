using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Servicio
    {
        public List<Producto> productos { get; set; }

        public Servicio()
        {
            productos = new List<Producto>();
        }

        public void agregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public string mostrarProductoMasCaro()
        {
            if (productos.Count == 0) return "No existe ningún producto";
            return productos.MaxBy(producto => producto.Precio)!.ToString();
        }

        public int contarProductosCasiCaducados()
        {
            return productos.Where(producto => (producto is ProductoPerecedero) ? ((ProductoPerecedero)producto).DiasACaducar == 1 : false).Count();
        }

        public List<Producto> mostrarProductosPerecederos()
        {
            return productos.Where(producto => producto is ProductoPerecedero).OrderByDescending(producto => ((ProductoPerecedero)producto).DiasACaducar).ToList();
        }

        public IEnumerable<IGrouping<int, Producto>> mostrarProductosNoPerecederos()
        {
            return productos.Where(producto => producto is ProductoNoPerecedero).GroupBy(producto => ((ProductoNoPerecedero)producto).Tipo);
        }
    }
}
