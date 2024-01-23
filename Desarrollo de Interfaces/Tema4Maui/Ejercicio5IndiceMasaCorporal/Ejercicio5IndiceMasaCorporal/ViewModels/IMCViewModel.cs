using Ejercicio5IndiceMasaCorporal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5IndiceMasaCorporal.ViewModels
{
    class IMCViewModel
    {
        public IMC IMC { get; set; }

        public IMCViewModel()
        {
            IMC = new IMC();
            IMC.Altura = 25;
            IMC.Peso = 50;
        }
    }
}
