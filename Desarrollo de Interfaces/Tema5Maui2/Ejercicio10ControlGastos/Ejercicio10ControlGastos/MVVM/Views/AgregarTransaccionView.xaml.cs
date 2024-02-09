using Ejercicio10ControlGastos.MVVM.ViewModels;

namespace Ejercicio10ControlGastos.MVVM.Views;

public partial class AgregarTransaccionView : ContentPage
{
	private ControlGastosViewModel _controlGastosViewModel;

    public AgregarTransaccionView(ControlGastosViewModel controlGastosViewModel)
	{
		InitializeComponent();

		_controlGastosViewModel = controlGastosViewModel;
		BindingContext = controlGastosViewModel;
	}
}