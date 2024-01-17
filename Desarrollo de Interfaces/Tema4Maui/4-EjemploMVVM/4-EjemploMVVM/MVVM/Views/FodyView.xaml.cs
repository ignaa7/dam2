using _4_EjemploMVVM.MVVM.ViewModels;

namespace _4_EjemploMVVM.MVVM.Views;

public partial class FodyView : ContentPage
{
	public FodyView()
	{
		InitializeComponent();

		BindingContext = new FodyViewModel();
	}
}