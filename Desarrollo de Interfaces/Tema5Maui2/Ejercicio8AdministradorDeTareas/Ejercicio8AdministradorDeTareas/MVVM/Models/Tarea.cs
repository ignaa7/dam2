using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8AdministradorDeTareas.MVVM.Models
{
    public class Tarea
    {
        public String Nombre { get; set; }
        public Categoria Categoria { get; set; }

        public Tarea(String nombre, Categoria categoria)
        {
            Nombre = nombre;
            Categoria = categoria;
        }
    }
}
