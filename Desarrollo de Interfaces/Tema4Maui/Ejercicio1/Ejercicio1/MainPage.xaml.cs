namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        int redColorValue;
        int greenColorValue;
        int blueColorValue;

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
        }

        private void sliderRed_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            redColorValue = (int)sliderRed.Value;
            updateColor();
        }

        private void sliderGreen_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            greenColorValue= (int)sliderGreen.Value;
            updateColor();
        }

        private void sliderBlue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            blueColorValue= (int)sliderBlue.Value;
            updateColor();
        }

        private void updateColor()
        {
            BackgroundColor = new Color(redColorValue, greenColorValue, blueColorValue);
        }
    }
}