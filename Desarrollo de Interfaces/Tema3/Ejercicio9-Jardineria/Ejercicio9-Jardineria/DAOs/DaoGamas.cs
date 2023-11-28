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
    internal class DaoGamas
    {
        public static List<string> GetGamas()
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand("SELECT gama FROM gama_producto");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

            List<string> gamas = new List<string>();

            foreach (DataRow fila in resultado.Tables[0].Rows)
            {
                gamas.Add(fila["gama"].ToString()!);
            }

            return gamas;
        }

        public static Object GetGama(string gama)
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand($"SELECT gama, descripcion_texto, descripcion_html, imagen FROM gama_producto where gama='{gama}'");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

            DataRow datosGama = resultado.Tables[0].Rows[0];

            return new {
                gama,
                descripcionTexto = datosGama["descripcion_texto"],
                descripcionHtml = datosGama["descripcion_html"],
                imagen = datosGama["imagen"]
            };
        }

        public static bool EliminarGama(string gama)
        {
            Conexion conexion = new Conexion();

            return conexion.EjecutarComandoSinRetornarDatos($"delete from gama_producto where gama='{gama}'");
        }
    }
}
