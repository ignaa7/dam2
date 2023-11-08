using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    public class EstudianteDLL
    {
        Conexion conexion;

        public EstudianteDLL()
        {
            conexion = new Conexion();
        }

        public bool Agregar(string nombre, string primerApellido, string segundoApellido, string correo, int idCiclo)
        {
            bool consulta1 = conexion.EjecutarComandoSinRetornarDatos($"insert into Estudiante(nombre, primerapellido, segundoapellido, email) values ('{nombre}', '{primerApellido}', '{segundoApellido}', '{correo}')");

            int idEstudiante = conexion.SelectId("select id from Estudiante having max(id)");

            bool consulta2 = conexion.EjecutarComandoSinRetornarDatos($"insert into Estudiante_Asignar_Ciclo(id_estudiante, id_ciclo) values ('{idEstudiante}', '{idCiclo}')");

            return consulta1 && consulta2;
        }

        public bool Modificar(int idCiclo, string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"update Ciclo set nombre = '{nombreCiclo}' where id = {idCiclo}");
        }

        public bool Borrar(int idCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"delete from Ciclo where id = {idCiclo}");
        }


        public DataSet MostrarCiclos()
        {
            SqlCommand sentencia = new SqlCommand("select * from Ciclo");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
