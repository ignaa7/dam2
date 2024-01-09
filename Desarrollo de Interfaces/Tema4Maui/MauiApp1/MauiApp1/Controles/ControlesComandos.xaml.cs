using MauiApp1.Paginas;

namespace MauiApp1.Controles;

public partial class ControlesComandos : ContentPage
{
	public ControlesComandos()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlyoutPageDemo());
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {

    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {

    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {

    }
}