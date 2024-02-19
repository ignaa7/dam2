using ExamenIgnacio2.MVVM.Models;
using ExamenIgnacio2.MVVM.Views;
using ExamenIgnacio2.Repository;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIgnacio2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ContactosViewModel
    {
        public List<Contacto> Contactos { get; set; }
        public List<Contacto> ContactosFavoritos { get; set; }

        public String Nombre { get; set; }
        public String Foto { get; set; }
        public String Correo { get; set; }
        public String Categoria { get; set; }
        public String Telefono { get; set; }
        public bool Favorito { get; set; }

        public Command IrAgregarContactoView { get; set; }
        public Command AgregarContacto { get; set; }
        public Command EnviarMensaje { get; set; }
        public Command Llamar { get; set; }

        public Contacto ContactoActual { get; set; }


        public ContactosViewModel()
        {
            Contactos = new List<Contacto>();
            ContactosFavoritos = new List<Contacto>();

            IrAgregarContactoView = new Command((page) =>
            {
                ((ContentPage)page).Navigation.PushAsync(new AgregarContactoView(this));
            });

            AgregarContacto = new Command((page) =>
            {
                App.RepositorioContacto.SaveItemWithChildren(new Contacto(Nombre, Foto, Correo, Categoria, Telefono, Favorito));
                Refresh();

                ((AgregarContactoView)page).Navigation.PopAsync();
            });

            EnviarMensaje = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Mensaje", $"Hola {ContactoActual.Nombre}", "Enviar");
            });

            Llamar = new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Llamada", $"Llamando a {ContactoActual.Telefono}", "Colgar");
            });

            Refresh();
        }

        public void Refresh()
        {
            List<Contacto> contactos = App.RepositorioContacto.GetItemWithChildren();
            Contactos = new List<Contacto>();
            ContactosFavoritos = new List<Contacto>();

            foreach(Contacto contacto in contactos)
            {
                Contactos.Add(contacto);

                if (contacto.Favorito)
                {
                    ContactosFavoritos.Add(contacto);
                }
            }
        }
    }
}
