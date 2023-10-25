using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Tarea(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaCreacion = fecha;
        }
    }
}
