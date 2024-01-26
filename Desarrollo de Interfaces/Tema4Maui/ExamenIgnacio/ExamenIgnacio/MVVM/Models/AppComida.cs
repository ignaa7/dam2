using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIgnacio.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class AppComida
    {
        public int Valoracion { get; set; }
        public bool Entregado { get; set; }

        public AppComida()
        {
            Entregado = false;
        }
    }
}
