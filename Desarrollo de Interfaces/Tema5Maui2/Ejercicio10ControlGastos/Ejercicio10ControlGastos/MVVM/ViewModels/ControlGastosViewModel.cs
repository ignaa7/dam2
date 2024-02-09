using Ejercicio10ControlGastos.MVVM.Models;
using Ejercicio10ControlGastos.MVVM.Views;
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
        public double TotalBalance { get; set; }
        public double Ingresos { get; set; }
        public double Gastos { get; set; }
        public Command CambiarPaginaCommand { get; set; }

        public ControlGastosViewModel()
        {
            Transacciones = new List<Transaccion>();

            CambiarPaginaCommand = new Command((page) =>
            {
                ((ControlGastosView)page).Navigation.PushAsync(new AgregarTransaccionView(this));
            });
        }
    }
}
