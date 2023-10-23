using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6b
{
    internal class Libro
    {
        public string? titulo { get; set; }
        public int idAutor { get; set; }
        public int fechaPublicacion { get; set; } // Year
        public int ventas { get; set; } //Millions

        public Libro(string titulo, int idAutor, int fechaPublicacion, int ventas)
        {
            this.titulo = titulo;
            this.idAutor = idAutor;
            this.fechaPublicacion = fechaPublicacion;
            this.ventas = ventas;
        }
    }
}
