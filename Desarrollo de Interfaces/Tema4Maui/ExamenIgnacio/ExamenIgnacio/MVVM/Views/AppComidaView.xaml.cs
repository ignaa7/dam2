using ExamenIgnacio.MVVM.ViewModels;

namespace ExamenIgnacio.MVVM.Views;

public partial class AppComidaView : ContentPage
{
	public AppComidaView()
	{
		InitializeComponent();
		BindingContext = new AppComidaViewModel();
	}
}