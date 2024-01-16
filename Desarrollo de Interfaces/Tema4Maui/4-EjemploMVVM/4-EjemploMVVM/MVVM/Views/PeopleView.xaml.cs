using MVVMDem.MVVM.ViewModels;

namespace _4_EjemploMVVM.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();

		BindingContext = new PeopleViewModel();
	}
}