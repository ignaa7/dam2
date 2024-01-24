using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Carrito
    {
        private double _precioSubtotal = 185.90;
        private int _porcentajeDescuento;

        public double PrecioTotal { get; set; }
        public int PorcentajeDescuento
        {
            get
            {
                return _porcentajeDescuento;
            }
            set
            {
                _porcentajeDescuento = value;
                PrecioDescuento = _precioSubtotal * _porcentajeDescuento / 100;
                PrecioTotal = _precioSubtotal - PrecioDescuento;
            }
        }
        public double PrecioDescuento { get; set; }

        public Carrito()
        {
            Clear();
        }

        public void Clear()
        {
            PorcentajeDescuento = 10;
        }
    }
}
