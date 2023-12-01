using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.modelo
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int IdVehiculo { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Descripcion { get; set; }

        public Mantenimiento(int id, string codigo, int idVehiculo, string fechaInicio, string fechaFin, string descripcion)
        {
            Id = id;
            Codigo = codigo;
            IdVehiculo = idVehiculo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Descripcion = descripcion;
        }
    }
}
