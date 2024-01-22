using Ejercicio5IndiceMasaCorporal.ViewModels;

namespace Ejercicio5IndiceMasaCorporal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new IMCViewModel();
        }
    }
}