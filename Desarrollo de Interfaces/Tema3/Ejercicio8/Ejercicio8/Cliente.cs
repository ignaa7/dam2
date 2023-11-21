using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumeroCuentaCorriente { get; set; }

        public Cliente(string dni, string nombre, string direccion, int edad, string telefono, string numeroCuentaCorriente)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Telefono = telefono;
            this.NumeroCuentaCorriente = numeroCuentaCorriente;
        }

        public override string ToString()
        {
            return $"DNI: {Dni}\nNombre: {Nombre}\nDirección: {Direccion}\nEdad: {Edad}\nTeléfono: {Telefono}\nNumero de cuenta corriente: {NumeroCuentaCorriente}";
        }
    }
}
