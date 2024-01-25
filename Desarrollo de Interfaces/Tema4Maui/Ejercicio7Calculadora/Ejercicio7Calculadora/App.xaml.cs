using Ejercicio7Calculadora.Views;

namespace Ejercicio7Calculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraView();
        }
    }
}
