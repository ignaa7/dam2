using DataBindingDemo.Models;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = "Pepe",
                Address = "Larga",
                Phone = "123456789"
            };

            BindingContext = person;
        }
    }
}