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
    internal class DaoClientes
    {
        public static DataSet ConsultarClientesNoPagan()
        {
            Conexion conexion = new Conexion();

            SqlCommand sentencia = new SqlCommand("SELECT nombre_cliente FROM (SELECT nombre_cliente, cliente.codigo_cliente FROM pedido JOIN cliente ON pedido.codigo_cliente=cliente.codigo_cliente) AS clientes_pedidos JOIN pago ON clientes_pedidos.codigo_cliente=pago.codigo_cliente");
            DataSet resultado = conexion.EjecutarSentencia(sentencia);

            return resultado;
        }
    }
}
