using PruebaExamen.ViewModels;

namespace PruebaExamen.Views;

public partial class CarritoView : ContentPage
{
	public CarritoView()
	{
		InitializeComponent();
		BindingContext = new CarritoViewModel();
	}
}