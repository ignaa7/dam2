using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8AdministradorDeTareas.MVVM.Models
{
    public class Categoria
    {
        public String Nombre { get; set; }

        public Categoria(String nombre)
        {
            Nombre = nombre;
        }
    }
}
