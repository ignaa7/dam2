using Ejercicio7Calculadora.ViewModels;

namespace Ejercicio7Calculadora.Views;

public partial class CalculadoraView : ContentPage
{
	public CalculadoraView()
	{
		InitializeComponent();

		BindingContext = new CalculadoraViewModel();
	}
}