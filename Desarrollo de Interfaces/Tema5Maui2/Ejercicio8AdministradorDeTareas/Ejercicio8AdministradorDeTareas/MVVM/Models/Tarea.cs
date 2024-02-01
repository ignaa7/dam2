using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8AdministradorDeTareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Tarea
    {
        private bool _completada = false;

        public String Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public bool Completada { 
            get
            {
                return _completada;
            }
            set
            {
                _completada = value;

                if (value)
                {
                    Categoria.TareasNoTerminadas--;
                    Categoria.TareasTerminadas++;
                }
                else
                {
                    Categoria.TareasTerminadas--;
                    Categoria.TareasNoTerminadas++;
                }
            }
        }

        public Tarea(String nombre, Categoria categoria)
        {
            Nombre = nombre;
            Categoria = categoria;
        }
    }
}
