using Ejercicio10ControlGastos.MVVM.ViewModels;

namespace Ejercicio10ControlGastos.MVVM.Views;

public partial class ControlGastosView : ContentPage
{
	public ControlGastosView()
	{
		InitializeComponent();
		BindingContext = new ControlGastosViewModel();
	}
}