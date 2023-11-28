using Ejercicio9_Jardineria.Dao;
using Ejercicio9_Jardineria.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Jardineria.DAOs
{
    internal class DaoProductos
    {
        private static Conexion Conexion { get; set; }

        public static List<Producto> GetProductos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor FROM producto");
            DataSet resultado = Conexion.EjecutarSentencia(sentencia);

            List<Producto> productos = new List<Producto>();

            foreach (DataRow fila in resultado.Tables[0].Rows)
            {
                string codigoProducto = fila["codigo_producto"].ToString()!;
                string nombre = fila["nombre"].ToString()!;
                string gama = fila["gama"].ToString()!;
                string dimensiones = fila["dimensiones"].ToString()!;
                string proveedor = fila["proveedor"].ToString()!;
                string descripcion = fila["descripcion"].ToString()!;
                int cantidadEnStock = Convert.ToInt32(fila["cantidad_en_stock"])!;
                double precioVenta = Convert.ToDouble(fila["precio_venta"])!;
                double precioProveedor = Convert.ToDouble(fila["precio_proveedor"])!;

                productos.Add(new Producto(codigoProducto, nombre, gama, dimensiones, proveedor, descripcion, cantidadEnStock, precioVenta, precioProveedor));
            }

            return new List<Producto>();
        }

        public static bool AgregarProducto(string codigo, string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidadStock, double precioVenta, double precioProveedor)
        {
            return Conexion.EjecutarComandoSinRetornarDatos($"insert into producto() values ('{codigo}', '{nombre}', '{gama}', '{dimensiones}', '{proveedor}', '{descripcion}', {cantidadStock}, {precioVenta}, {precioProveedor})");
        }
    }
}
