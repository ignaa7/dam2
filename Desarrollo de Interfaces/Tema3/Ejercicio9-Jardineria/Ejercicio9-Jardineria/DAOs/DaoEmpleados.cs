using Ejercicio9_Jardineria.Dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Jardineria.DAOs
{
    internal class DaoEmpleados
    {
        public static List<int> GetCodigosJefes()
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand("SELECT codigo_empleado FROM empleado WHERE codigo_jefe IS NULL");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

            List<int> codigosJefes = new List<int>();

            foreach (DataRow fila in resultado.Tables[0].Rows)
            {
                codigosJefes.Add(Convert.ToInt32(fila["codigo_empleado"]));
            }

            return codigosJefes;
        }

        public static List<Object> ConsultarEmpleadosDeJefe(int codigoJefe)
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand($"SELECT nombre, apellido1, apellido2, email FROM empleado WHERE codigo_jefe={codigoJefe}");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

            List<Object> empleados = new List<Object>();

            foreach (DataRow fila in resultado.Tables[0].Rows)
            {
                empleados.Add(new {
                    nombre = fila["nombre"],
                    apellido1 = fila["apellido1"],
                    apellido2 = fila["apellido2"],
                    email = fila["email"]
                });
            }

            return empleados;
        }
    }
}
