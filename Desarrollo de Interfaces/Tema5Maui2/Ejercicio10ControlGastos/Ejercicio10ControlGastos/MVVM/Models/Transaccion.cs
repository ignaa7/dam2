using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio10ControlGastos.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Transaccion
    {
        public Date Fecha { get; set; }
        public string Nombre { get; set; }
        public double Cantidad { get; set; }

        public Transaccion()
        {
            
        }
    }
}
