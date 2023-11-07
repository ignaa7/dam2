using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    internal class CicloDLL
    {
        Conexion conexion;
        public CicloDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"insert into Ciclo(nombre) values ('{nombreCiclo}')");
        }

        public bool Modificar(int idCiclo, string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"update Ciclo set nombre = '{nombreCiclo}' where id = {idCiclo}");
        }

        public bool Borrar(int idCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"delete from Ciclo where id = {idCiclo}");
        }
    }
}
