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
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Ciclo(nombre) values ('" + nombreCiclo + "')");
        }
    }
}
