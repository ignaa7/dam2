using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8.Modelo
{
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string NumeroCuentaCorriente { get; set; }

        public Cliente(string dni, string nombre, string direccion, int edad, string telefono, string numeroCuentaCorriente)
        {
            Dni = dni;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            NumeroCuentaCorriente = numeroCuentaCorriente;
        }

        public Cliente() { }

        public override string ToString()
        {
            return $"DNI: {Dni}\nNombre: {Nombre}\nDirección: {Direccion}\nEdad: {Edad}\nTeléfono: {Telefono}\nNumero de cuenta corriente: {NumeroCuentaCorriente}";
        }
    }
}
