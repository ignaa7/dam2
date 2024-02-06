using Ejercicio10ControlGastos.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10ControlGastos.MVVM.ViewModels
{
    public class ControlGastosViewModel
    {
        public List<Transaccion> Transacciones { get; set; }

        public ControlGastosViewModel()
        {
            Transacciones = new List<Transaccion>();
        }
    }
}
