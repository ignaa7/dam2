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

        public EstudianteDLL(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public DataSet GetCiclos()
        {
            SqlCommand sentencia = new SqlCommand("select nombre from Ciclo");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool Agregar(string nombre, string primerApellido, string segundoApellido, string correo, string nombreCiclo)
        {
            bool consulta1 = conexion.EjecutarComandoSinRetornarDatos($"insert into Estudiante(nombre, primerapellido, segundoapellido, email) values ('{nombre}', '{primerApellido}', '{segundoApellido}', '{correo}')");

            int idEstudiante = conexion.SelectId("select id from Estudiante group by id having id = max(id)");

            int idCiclo = conexion.SelectId($"select id from Ciclo group by id, nombre having nombre = '{nombreCiclo}'");

            bool consulta2 = conexion.EjecutarComandoSinRetornarDatos($"insert into Estudiante_Asignar_Ciclo(id_estudiante, id_ciclo) values ('{idEstudiante}', '{idCiclo}')");

            return consulta1 && consulta2;
        }

        public bool Modificar(int idEstudiante, string nombreEstudiante, string primerApellido, string segundoApellido, string correo, string nombreCiclo)
        {
            int idCiclo = conexion.SelectId($"select id from Ciclo group by id, nombre having nombre = '{nombreCiclo}'");

            return conexion.EjecutarComandoSinRetornarDatos($"update Estudiante set nombre = '{nombreEstudiante}', primerapellido = '{primerApellido}', segundoapellido = '{segundoApellido}', email = '{correo}' where id = {idEstudiante}");
        }

        public bool Borrar(int idEstudiante)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"delete from Estudiante where id = {idEstudiante}");
        }


        public DataSet MostrarEstudiantes()
        {
            SqlCommand sentencia = new SqlCommand("select nombre, primerapellido, segundoapellido, email from Estudiante");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
