using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.Banco
{
    internal class Cliente
    {
        string Dni;
        string Nombre;
        double CantidadAhorrada;

        public Cliente(string dni, string nombre, double cantidadAhorrada)
        {
            Dni = dni;
            Nombre = nombre;
            CantidadAhorrada = cantidadAhorrada;
        }

        public string GetDni()
        {
            return Dni;
        }

        public void Ingresar(double cantidad)
        {
            CantidadAhorrada += cantidad;
        }

        public void Extraer(double cantidad)
        {
            CantidadAhorrada -= cantidad;
        }

        public double ConsultarSaldo()
        {
            return CantidadAhorrada;
        }
    }
}
