using _4_EjemploMVVM.MVVM.ViewModels;

namespace _4_EjemploMVVM.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}