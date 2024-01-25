using PruebaFinalExamen.MVVM.ViewModels;

namespace PruebaFinalExamen.MVVM.Views;

public partial class PruebaView : ContentPage
{
	public PruebaView()
	{
		InitializeComponent();
		BindingContext = new PruebaViewModel();
	}
}