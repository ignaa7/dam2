using Ejercicio9_Jardineria.Dao;
using Ejercicio9_Jardineria.DAOs;
using Ejercicio9_Jardineria.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Jardineria.Servicios
{
    public class Servicio
    {
        private static Servicio? ServicioObjeto { get; set; }
        private Conexion Conexion { get; set; }

        private Servicio()
        {
            Conexion = new Conexion();
        }

        public static Servicio GetInstance()
        {
            if (ServicioObjeto == null)
            {
                return new Servicio();
            }
            else
            {
                return ServicioObjeto;
            }
        }

        private List<Producto> GetProductos()
        {
            return DaoProductos.GetProductos();
        }

        public bool AgregarProducto(string codigo, string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidadStock, double precioVenta, double precioProveedor)
        {
            return DaoProductos.AgregarProducto(codigo, nombre, gama, dimensiones, proveedor, descripcion, cantidadStock, precioVenta, precioProveedor);
        }

        public List<string> GetGamas()
        {
            return DaoGamas.GetGamas();
        }

        public Object GetGama(string gama)
        {
            return DaoGamas.GetGama(gama);
        }

        public bool EliminarGama(string gama)
        {
            return DaoGamas.EliminarGama(gama);
        }

        public DataSet ConsultarPedidosEntregados(int mes)
        {
            return DaoPedidos.ConsultarPedidosEntregados(mes);
        }

        public List<int> GetCodigosJefes()
        {
            return DaoEmpleados.GetCodigosJefes();
        }

        public List<Object> ConsultarEmpleadosDeJefe(int codigoJefe)
        {
            return DaoEmpleados.ConsultarEmpleadosDeJefe(codigoJefe);
        }
    }
}
