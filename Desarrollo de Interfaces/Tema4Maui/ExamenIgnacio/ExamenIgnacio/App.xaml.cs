using ExamenIgnacio.MVVM.Views;

namespace ExamenIgnacio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppComidaView();
        }
    }
}
