using PruebaFinalExamen.MVVM.Views;

namespace PruebaFinalExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PruebaView();
        }
    }
}
