using Ejercicio10ControlGastos.MVVM.Views;

namespace Ejercicio10ControlGastos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ControlGastosView();
        }
    }
}
