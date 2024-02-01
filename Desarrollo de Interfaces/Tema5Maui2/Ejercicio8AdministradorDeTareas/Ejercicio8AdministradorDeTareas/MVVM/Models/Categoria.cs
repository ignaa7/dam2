using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8AdministradorDeTareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Categoria
    {
        private int _tareasTerminadas;
        private int _tareasNoTerminadas;

        public String Nombre { get; set; }
        public int TareasTerminadas {
            get
            {
                return _tareasTerminadas;
            }
            set
            {
                _tareasTerminadas = value;
                PorcentajeTotal = (double)_tareasTerminadas / (_tareasTerminadas + _tareasNoTerminadas);
            }
        }
        public int TareasNoTerminadas {
            get
            {
                return _tareasNoTerminadas;
            }
            set
            {
                _tareasNoTerminadas = value;
                PorcentajeTotal = (double)_tareasTerminadas / (_tareasTerminadas + _tareasNoTerminadas);
            }
        }
        public double PorcentajeTotal { get; set; }

        public Categoria(String nombre)
        {
            Nombre = nombre;
        }
    }
}
