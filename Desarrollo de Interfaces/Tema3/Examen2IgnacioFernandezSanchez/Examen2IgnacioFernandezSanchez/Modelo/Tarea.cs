using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2IgnacioFernandezSanchez.Modelo
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string FechaVencimiento { get; set; }
        public string Estado { get; set; }

        public Tarea(string nombre, string descripcion, string fechaVencimiento, string estado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            Estado = estado;
        }

        public Tarea()
        {
            
        }
    }
}
