using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.HerenciaPersona
{
    internal class Empleado : Persona
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, int edad, double sueldo) : base(nombre, edad)
        {
            Sueldo = sueldo;
        }

        public double getSueldo()
        {
            return Sueldo;
        }
    }
}
