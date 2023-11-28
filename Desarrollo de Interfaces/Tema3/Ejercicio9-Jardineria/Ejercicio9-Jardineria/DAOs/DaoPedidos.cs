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
    internal class DaoPedidos
    {
        public static DataSet ConsultarPedidosEntregados(int mes)
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand($"SELECT codigo_pedido, fecha_pedido, fecha_esperada, fecha_entrega, estado, comentarios, codigo_cliente FROM pedido WHERE MONTH(fecha_entrega)={mes}");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

            return resultado;
        }
    }
}
