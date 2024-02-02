using Ejercicio8AdministradorDeTareas.MVVM.Models;
using Ejercicio8AdministradorDeTareas.MVVM.ViewModels;

namespace Ejercicio8AdministradorDeTareas.MVVM.Views;

public partial class AgregarTareaView : ContentPage
{
	private TareasViewModel _tareasViewModel;

	public AgregarTareaView(TareasViewModel tareasViewModel)
	{
		InitializeComponent();

		_tareasViewModel = tareasViewModel;
		BindingContext = tareasViewModel;
	}
}