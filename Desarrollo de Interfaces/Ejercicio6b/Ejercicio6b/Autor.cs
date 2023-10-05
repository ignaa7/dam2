using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6b
{
    internal class Autor
    {
        public int idAutor { get; set; }
        public string? nombre { get; set; }

        public Autor(int idAutor, string nombre)
        {
            this.idAutor = idAutor;
            this.nombre = nombre;
        }
    }
}
