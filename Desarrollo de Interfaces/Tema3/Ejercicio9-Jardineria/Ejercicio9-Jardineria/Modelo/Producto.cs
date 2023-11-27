using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Jardineria.Modelo
{
    internal class Producto
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Gama { get; set; }
        public String Dimensiones { get; set; }
        public String Proveedor { get; set; }
        public String Descripcion { get; set; }
        public int CantidadStock { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioProveedor { get; set; }

        public Producto(String codigo, String nombre, String gama, String dimensiones, String proveedor, String descripcion, int cantidadStock, double precioVenta, double precioProveedor)
        {
            Codigo = codigo;
            Nombre = nombre;
            Gama = gama;
            Dimensiones = dimensiones;
            Proveedor = proveedor;
            Descripcion = descripcion;
            CantidadStock = cantidadStock;
            PrecioVenta = precioVenta;
            PrecioProveedor = precioProveedor;
        }
    }
}
