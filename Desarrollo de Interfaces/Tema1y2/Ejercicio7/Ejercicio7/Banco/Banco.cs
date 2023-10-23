using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.Banco
{
    internal class Banco
    {

        public enum Operaciones
        {
            Ingresar,
            Extraer
        }

        public static Cliente[] clientes { get; set; } = {
                new Cliente("12345678G", "Pepe", 100),
                new Cliente("75847362H", "Pepa", 123.1),
                new Cliente("71672890P", "Paco", 289.6)
            };

        public static void Operar(string dni, Operaciones operacion, double cantidad)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.GetDni() == dni)
                {
                    switch (operacion)
                    {
                        case Operaciones.Ingresar:
                            cliente.Ingresar(cantidad);
                            break;
                        case Operaciones.Extraer:
                            cliente.Extraer(cantidad);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public static double CalcularDinero()
        {
            double dinero = 0;

            foreach (var cliente in clientes)
            {
                dinero += cliente.ConsultarSaldo();
            }

            return Math.Round(dinero, 2);
        }
    }
}
