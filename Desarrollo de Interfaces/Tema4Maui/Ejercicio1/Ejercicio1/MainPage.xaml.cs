namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        int redColorValue;
        int greenColorValue;
        int blueColorValue;
        string hexColorValue;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGenerateRandomColor_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            redColorValue = random.Next(0, 256);
            greenColorValue = random.Next(0, 256);
            blueColorValue = random.Next(0, 256);
            updateColor();

            sliderRed.Value = redColorValue;
            sliderGreen.Value = greenColorValue;
            sliderBlue.Value = blueColorValue;
        }

        private void sliderRed_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            redColorValue = (int)sliderRed.Value;
            updateColor();
        }

        private void sliderGreen_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            greenColorValue = (int)sliderGreen.Value;
            updateColor();
        }

        private void sliderBlue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            blueColorValue = (int)sliderBlue.Value;
            updateColor();
        }

        private void updateColor()
        {
            btnCopy.BackgroundColor = new Color(redColorValue, greenColorValue, blueColorValue);
            BackgroundColor = new Color(redColorValue, greenColorValue, blueColorValue);
            hexColorValue = $"#{redColorValue:X2}{greenColorValue:X2}{blueColorValue:X2}";
            lblHexColor.Text = $"HEX Value: {hexColorValue}";
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Clipboard.SetTextAsync(hexColorValue);
        }
    }
}