using PruebaExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PruebaExamen.ViewModels
{
    public class CarritoViewModel
    {
        public Carrito Carrito { get; set; }
        public ICommand BtnMasPulsado { get; set; }
        public ICommand BtnMenosPulsado { get; set; }
        public ICommand BtnPagarLuegoPulsado { get; set; }
        public ICommand BtnPagarAhoraPulsado { get; set; }

        public CarritoViewModel()
        {
            Carrito = new Carrito();

            BtnMasPulsado = new Command(() =>
            {
                Carrito.PorcentajeDescuento += 10;
            });

            BtnMenosPulsado = new Command(() =>
            {
                Carrito.PorcentajeDescuento -= 10;
            });

            BtnPagarLuegoPulsado = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Nike Store", "Pedido guardado", "OK");
                Carrito.Clear();
            });

            BtnPagarAhoraPulsado = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Nike Store", $"Pagado {Carrito.PrecioTotal}€", "OK");
                Carrito.Clear();
            });
        }
    }
}
