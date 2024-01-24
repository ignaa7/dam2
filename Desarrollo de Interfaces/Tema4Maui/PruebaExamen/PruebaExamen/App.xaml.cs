using PruebaExamen.Views;

namespace PruebaExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarritoView();
        }
    }
}