using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    class Conexion
    {

        private string cadenaConexion = "Data Source=DESKTOP-KE2530F\\MSSQLSERVER1; Initial Catalog=db.Sistema; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            this.sqlConnection = new SqlConnection(this.cadenaConexion);
            return this.sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos( string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable EjecutarComandoRetornarDatos(string strComando)
        {
                DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter( strComando, sqlConnection);
                da.Fill(dt);
                sqlConnection.Close();
         
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand = sqlComando;
                sqlCommand.Connection = this.EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;

            }
            catch (Exception)
            {
                return ds;
                throw;
            }
        }
                
    }
}
