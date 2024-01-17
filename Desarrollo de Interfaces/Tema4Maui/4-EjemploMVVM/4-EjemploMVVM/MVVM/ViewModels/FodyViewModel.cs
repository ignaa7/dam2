using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _4_EjemploMVVM.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class FodyViewModel
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Resultado { get; set; }
        public ICommand AddCommand => new Command(() => Resultado = Numero1 + Numero2);
    }
}
