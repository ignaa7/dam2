using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Empleado
    {
        public string? DNI { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        public double PagoPorHoraExtra { get; set; }
        public double HorasExtrasRealizadas { get; set; }
        public int TipoIRPF { get; set; }
        public bool Casado { get; set; }
        public int NumeroHijos { get; set; }

        public Empleado()
        {
            Nombre = default;
            SueldoBase = default; 
            PagoPorHoraExtra = default;
            HorasExtrasRealizadas = default;
            TipoIRPF = default;
            Casado = default;
            NumeroHijos = default;
        }

        public Empleado(string dni)
        {
            Nombre = default;
            SueldoBase = default;
            PagoPorHoraExtra = default;
            HorasExtrasRealizadas = default;
            TipoIRPF = default;
            Casado = default;
            NumeroHijos = default;

            try
            {
                if (Regex.IsMatch(dni, @"^\d{8}[A-Z]$")) DNI = dni;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw exception;
            }
        }

        public double CalcularComplementoHorasExtra()
        {
            return PagoPorHoraExtra * HorasExtrasRealizadas;
        }

        public double CalcularSueldoBruto()
        {
            return SueldoBase + CalcularComplementoHorasExtra();
        }

        public double CalcularRetencionIRPF()
        {
            if (Casado) TipoIRPF -= 2;
            TipoIRPF -= NumeroHijos;

            return TipoIRPF * CalcularSueldoBruto() / 100;
        }

        public double CalcularSueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularRetencionIRPF();
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nSueldo neto: {CalcularSueldoNeto()}";
        }
    }
}
