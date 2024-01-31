using Ejercicio8AdministradorDeTareas.MVVM.ViewModels;

namespace Ejercicio8AdministradorDeTareas.MVVM.Views;

public partial class TareasView : ContentPage
{
	public TareasView()
	{
		InitializeComponent();
		BindingContext = new TareasViewModel();
	}
}