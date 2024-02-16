using ExamenIgnacio2.MVVM.ViewModels;

namespace ExamenIgnacio2.MVVM.Views;

public partial class AgregarContactoView : ContentPage
{
	public AgregarContactoView(ContactosViewModel contactosViewModel)
	{
		InitializeComponent();
		BindingContext = contactosViewModel;
	}
}