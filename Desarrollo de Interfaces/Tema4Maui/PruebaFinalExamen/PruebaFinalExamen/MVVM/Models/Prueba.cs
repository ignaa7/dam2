using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFinalExamen.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Prueba
    {
        public int Numero { get; set; }

        public Prueba()
        {
            
        }
    }
}
