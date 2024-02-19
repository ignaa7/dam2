using ExamenIgnacio2.MVVM.ViewModels;

namespace ExamenIgnacio2.MVVM.Views;

public partial class ContactosView : TabbedPage
{
    public ContactosViewModel ContactosViewModel { get; set; }
    public ContactosView()
	{
		InitializeComponent();
		ContactosViewModel = new ContactosViewModel();
        BindingContext = ContactosViewModel;
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Navigation.PushAsync(new ContactoDetallesView(ContactosViewModel));
    }
}