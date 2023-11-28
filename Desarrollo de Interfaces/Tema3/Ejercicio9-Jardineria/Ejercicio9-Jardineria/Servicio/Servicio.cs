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

namespace Ejercicio9_Jardineria.Servicio
{
    internal class Servicio
    {
        private Servicio? ServicioObjeto { get; set; }
        private Conexion Conexion { get; set; }

        private Servicio()
        {
            Conexion = new Conexion();
        }

        public Servicio GetInstance()
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
    }
}
