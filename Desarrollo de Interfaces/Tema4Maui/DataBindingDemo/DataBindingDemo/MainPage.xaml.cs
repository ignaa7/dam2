using DataBindingDemo.Models;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Person person;

        public MainPage()
        {
            InitializeComponent();

            person = new Person
            {
                Name = "Juanito",
                Address = "corta",
                Phone = "123"
            };

            BindingContext = person;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            person.Name = "Pepe";
            person.Address = "Larga";
            person.Phone = "123456789";
        }
    }
}