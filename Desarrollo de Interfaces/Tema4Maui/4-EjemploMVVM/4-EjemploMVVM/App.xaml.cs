using _4_EjemploMVVM.MVVM.Views;

namespace _4_EjemploMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PersonView();
        }
    }
}