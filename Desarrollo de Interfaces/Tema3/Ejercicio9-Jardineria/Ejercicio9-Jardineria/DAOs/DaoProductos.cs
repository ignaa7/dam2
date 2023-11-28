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
        public static List<Producto> GetProductos()
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand("SELECT codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor FROM producto");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

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

            return productos;
        }

        public static bool AgregarProducto(string codigo, string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidadStock, double precioVenta, double precioProveedor)
        {
            Conexion conexion = new Conexion();

            return conexion.EjecutarComandoSinRetornarDatos($"insert into producto(codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor) values ('{codigo}', '{nombre}', '{gama}', '{dimensiones}', '{proveedor}', '{descripcion}', {cantidadStock}, {precioVenta}, {precioProveedor})");
        }
    }
}
