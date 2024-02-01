using Ejercicio8AdministradorDeTareas.MVVM.ViewModels;

namespace Ejercicio8AdministradorDeTareas.MVVM.Views;

public partial class AgregarTareaView : ContentView
{
	public AgregarTareaView(TareasViewModel tareasViewModel)
	{
		InitializeComponent();

		BindingContext = tareasViewModel;
	}
}