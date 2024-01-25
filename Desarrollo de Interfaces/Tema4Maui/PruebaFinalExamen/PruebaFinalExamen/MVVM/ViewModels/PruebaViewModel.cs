using PruebaFinalExamen.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PruebaFinalExamen.MVVM.ViewModels
{
    public class PruebaViewModel
    {
        public Prueba Prueba { get; set; }
        public ICommand ComandoNumeroIntroducido { get; set; }

        public PruebaViewModel()
        {
            Prueba = new Prueba();

            ComandoNumeroIntroducido = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Alerta", "Esto es una alerta", "OK");
            });
        }
    }
}
