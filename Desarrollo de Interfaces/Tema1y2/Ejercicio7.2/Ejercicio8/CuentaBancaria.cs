using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class CuentaBancaria
    {

        public enum Operaciones
        {
            Ingresar,
            Extraer
        }

        public String Titular { get; set; }

        public double Saldo { get; set; }

        public CuentaBancaria()
        {
            
        }

        public void Operar(Operaciones operacion, double cantidad)
        {
            switch (operacion)
            {
                case Operaciones.Ingresar:
                    Saldo += cantidad;
                    break;
                case Operaciones.Extraer:
                    Saldo -= cantidad;
                    break;
                default:
                    break;
            }
        }

        public double MostrarSaldo()
        {
            return Saldo;
        }

        protected String RealizarTransferencia(CuentaBancaria cuenta, double cantidad)
        {
            String respuesta;

            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                cuenta.Saldo += cantidad;
                respuesta = "Transferencia realizada.";
            }
            else
            {
                respuesta = "No hay suficientes fondos.";
            }

            return respuesta;
        }
    }
}
