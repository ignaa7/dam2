using _4_EjemploMVVM.MVVM.ViewModels;

namespace _4_EjemploMVVM.MVVM.Views;

public partial class CommandView : ContentPage
{
	public CommandView()
	{
		InitializeComponent();

		BindingContext = new CommandViewModel();
	}
}