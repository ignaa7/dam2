namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        double propina = 0;
        int numeroPersonas = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void calcularPrecio()
        {
            double cuenta;

            if (double.TryParse(entryCuenta.Text, out cuenta))
            {
                double subtotal = cuenta / numeroPersonas;
                lblSubtotal.Text = $"{subtotal}€";

                lblPropina.Text = $"{subtotal * propina / 100}€";

                lblTotal.Text = $"{subtotal * (propina / 100 + 1)}€";
            }
        }

        private void entryCuenta_TextChanged(object sender, TextChangedEventArgs e)
        {
            calcularPrecio();
        }

        private void btnPropina10_Clicked(object sender, EventArgs e)
        {
            propina = 10;
            sliderPropina.Value = propina;
            calcularPrecio();
        }

        private void btnPropina20_Clicked(object sender, EventArgs e)
        {
            propina = 20;
            sliderPropina.Value = propina;
            calcularPrecio();
        }

        private void btnPropina30_Clicked(object sender, EventArgs e)
        {
            propina = 30;
            sliderPropina.Value = propina;
            calcularPrecio();
        }

        private void sliderPropina_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            propina = sliderPropina.Value;
            lblPorcentajePropina.Text = $"Propina: {sliderPropina.Value}%";
            calcularPrecio();
        }

        private void btnRestarNumeroPersonas_Clicked(object sender, EventArgs e)
        {
            if (numeroPersonas > 0)
            {
                numeroPersonas--;
                lblNumeroPersonas.Text = numeroPersonas.ToString();
                calcularPrecio();
            }
        }

        private void btnSumarNumeroPersonas_Clicked(object sender, EventArgs e)
        {
            numeroPersonas++;
            lblNumeroPersonas.Text = numeroPersonas.ToString();
            calcularPrecio();
        }
    }
}