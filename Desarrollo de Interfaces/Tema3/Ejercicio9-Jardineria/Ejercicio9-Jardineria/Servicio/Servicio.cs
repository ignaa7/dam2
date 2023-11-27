using Ejercicio9_Jardineria.Dao;
using Ejercicio9_Jardineria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_Jardineria.Servicio
{
    internal class Servicio
    {
        public Servicio? ServicioObjeto { get; set; }
        public List<Producto> Productos { get; set; }

        public Servicio()
        {
            
        }
    }
}
