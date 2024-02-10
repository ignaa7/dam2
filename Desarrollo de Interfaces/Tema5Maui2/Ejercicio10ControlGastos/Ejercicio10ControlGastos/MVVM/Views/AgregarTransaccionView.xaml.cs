using Ejercicio10ControlGastos.MVVM.ViewModels;

namespace Ejercicio10ControlGastos.MVVM.Views;

public partial class AgregarTransaccionView : ContentPage
{

    public AgregarTransaccionView(ControlGastosViewModel controlGastosViewModel)
	{
		InitializeComponent();
		BindingContext = controlGastosViewModel;
	}
}