using Ejercicio10ControlGastos.MVVM.Models;
using Ejercicio10ControlGastos.MVVM.Views;
using Ejercicio10ControlGastos.Repository;

namespace Ejercicio10ControlGastos
{
    public partial class App : Application
    {
        public static BaseRepository<Transaccion> TransaccionRepo { get; private set; }
        public App(BaseRepository<Transaccion> repo)
        {
            InitializeComponent();
            TransaccionRepo = repo;

            MainPage = new ControlGastosView();
        }
    }
}
