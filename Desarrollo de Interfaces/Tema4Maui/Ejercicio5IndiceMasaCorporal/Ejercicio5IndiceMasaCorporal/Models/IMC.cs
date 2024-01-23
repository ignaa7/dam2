using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5IndiceMasaCorporal.Models
{
    [AddINotifyPropertyChangedInterface]
    public class IMC
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Resultado { get {
                return Peso / Math.Pow(Altura / 100, 2);
            } }

        public IMC()
        {
            
        }
    }
}
