using ExamenIgnacio.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenIgnacio.MVVM.ViewModels
{
    public class AppComidaViewModel
    {
        public AppComida AppComida { get; set; }
        public ICommand CalificarCommand { get; set; }
        public ICommand LlamarCommand { get; set; }
        public ICommand AyudaCommand { get; set; }

        public AppComidaViewModel()
        {
            AppComida = new AppComida();

            CalificarCommand = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("A domicilio", $"Gracias por su valoración de un {AppComida.Valoracion}", "OK");
            });

            LlamarCommand = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("A domicilio", "Llama al 123456789", "OK");
            });

            AyudaCommand = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("A domicilio", "Mandar correo a adomicilio@adomicilio.com", "OK");
            });
        }
    }
}
