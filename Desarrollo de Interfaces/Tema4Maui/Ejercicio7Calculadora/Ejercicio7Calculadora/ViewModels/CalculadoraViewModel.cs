using Dangl.Calculator;
using Ejercicio7Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejercicio7Calculadora.ViewModels
{
    public class CalculadoraViewModel
    {
        public Calculadora Calculadora { get; set; }
        public ICommand BotonPulsado { get; }

        public CalculadoraViewModel()
        {
            Calculadora = new Calculadora();

            BotonPulsado = new Command((text) =>
            {
                if (text.Equals("AC"))
                {
                    Calculadora.Resultado = "0";
                }
                else if (text.Equals("x"))
                {
                    if (!Calculadora.Resultado.Equals("0"))
                    {
                        Calculadora.Resultado = Calculadora.Resultado.Substring(0, Calculadora.Resultado.Length - 1);
                    }
                }
                else if (Calculadora.Resultado.Equals("="))
                {
                    var resultado = Calculator.Calculate(Calculadora.Resultado);

                    if (resultado != null)
                    {
                        Calculadora.Resultado = $"{resultado}";
                    }
                }
                else
                {
                    Calculadora.Resultado += text;
                }
            });
        }
    }
}
