using Ejercicio10ControlGastos.MVVM.Models;
using Ejercicio10ControlGastos.MVVM.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio10ControlGastos.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ControlGastosViewModel
    {
        private List<Transaccion> _transacciones;

        public List<Transaccion> Transacciones
        {
            get { return _transacciones; }
            set
            {
                _transacciones = value;

                double ingresos = 0;
                double gastos = 0;

                foreach (Transaccion transaccion in _transacciones)
                {
                    if (transaccion.EsIngreso)
                    {
                        ingresos += transaccion.Cantidad;
                    }
                    else
                    {
                        gastos += transaccion.Cantidad;
                    }
                }

                Ingresos = ingresos;
                Gastos = gastos;
                TotalBalance = ingresos - gastos;
            }
        }
        public double TotalBalance { get; set; }
        public double Ingresos { get; set; }
        public double Gastos { get; set; }
        public Command CambiarPaginaCommand { get; set; }
        public Command VolverCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public Date Fecha { get; set; }
        public bool EsIngreso { get; set; }

        public ControlGastosViewModel()
        {
            Transacciones = new List<Transaccion>();

            CambiarPaginaCommand = new Command((page) =>
            {
                ((ControlGastosView)page).Navigation.PushAsync(new AgregarTransaccionView(this));
            });

            VolverCommand = new Command((page) =>
            {
                ((AgregarTransaccionView)page).Navigation.PopAsync();
            });

            AddCommand = new Command(async (page) =>
            {
                //App.CustomerRepo.SaveItem(CurrentCustomer);

                App.TransaccionRepo.SaveItemWithChildren(new Transaccion(Nombre, Cantidad, Fecha, EsIngreso));

                Console.WriteLine(App.TransaccionRepo.StatusMessage);
                Refresh();

                await ((AgregarTransaccionView)page).Navigation.PopAsync();

            });
        }

        private void Refresh()
        {
            //Customers = App.CustomerRepo.GetItems();

            //Métodos para flexibilizar las consultas con expresiones Lambda - cambiamos
            //Customers = App.CustomerRepo.GetItems(x => x.Name.StartsWith("A"));

            Transacciones = App.TransaccionRepo.GetItemWithChildren();

        }
    }
}
