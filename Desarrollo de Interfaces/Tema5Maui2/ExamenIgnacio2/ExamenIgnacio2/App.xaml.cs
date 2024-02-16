using ExamenIgnacio2.MVVM.Models;
using ExamenIgnacio2.MVVM.Views;
using ExamenIgnacio2.Repository;

namespace ExamenIgnacio2
{
    public partial class App : Application
    {
        public static BaseRepository<Contacto> RepositorioContacto { get; private set; }
        public App(BaseRepository<Contacto> repositorioContacto)
        {
            InitializeComponent();
            RepositorioContacto = repositorioContacto;

            MainPage = new NavigationPage(new ContactosView());
        }
    }
}
