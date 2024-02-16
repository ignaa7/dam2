using ExamenIgnacio2.MVVM.ViewModels;

namespace ExamenIgnacio2.MVVM.Views;

public partial class ContactoDetallesView : ContentPage
{
	public ContactoDetallesView(ContactosViewModel contactosViewModel)
	{
		InitializeComponent();
		BindingContext = contactosViewModel;
	}
}