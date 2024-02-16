using ExamenIgnacio2.Abstraction;
using ExamenIgnacio2.MVVM.ViewModels;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIgnacio2.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]

    [Table("Contacto")]
    public class Contacto: TableData
    {
        private bool _favorito;

        public String Nombre { get; set; }
        public String Foto { get; set; }
        public String Correo { get; set; }
        public String Categoria { get; set; }
        public String Telefono { get; set; }
        public bool Favorito
        {
            get { return _favorito; }
            set
            {
                _favorito = value;
            }
        }

        public Contacto(String nombre, String foto, String correo, String categoria, String telefono, bool favorito)
        {
            Nombre = nombre;
            Foto = foto;
            Correo = correo;
            Categoria = categoria;
            Telefono = telefono;
            Favorito = favorito;
        }

        public Contacto()
        {
            
        }

        public bool GetFavorito()
        {
            return _favorito;
        }

        public void SetFavorito(bool favorito)
        {
            _favorito = favorito;
            App.RepositorioContacto.SaveItemWithChildren(this);
        }
    }
}
