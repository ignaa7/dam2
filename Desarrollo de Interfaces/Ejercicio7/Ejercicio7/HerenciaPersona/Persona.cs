using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.HerenciaPersona
{
    internal class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string toString()
        {
            return $"Nombre: {Nombre}\nEdad: {Edad}";
        }
    }
}
