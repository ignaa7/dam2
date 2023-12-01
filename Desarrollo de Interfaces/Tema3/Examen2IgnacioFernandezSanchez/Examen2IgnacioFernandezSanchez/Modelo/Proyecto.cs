using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IgnacioFernandezSanchez.Modelo
{
    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }

        public Proyecto(string nombre, string descripcion, string fechaInicio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
        }

        public Proyecto()
        {
            
        }
    }
}
