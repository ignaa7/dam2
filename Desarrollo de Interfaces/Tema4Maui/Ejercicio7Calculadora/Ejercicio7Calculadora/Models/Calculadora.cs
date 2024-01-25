using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Calculadora.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Calculadora
    {
        public string Resultado { get; set; }

        public Calculadora()
        {
            Resultado = "0";
        }
    }
}
