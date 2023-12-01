using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.modelo
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int AnoFabricacion { get; set; }
        public string Estado { get; set; }

        public Vehiculo(int id, string matricula, string modelo, string marca, int anoFabricacion, string estado)
        {
            Id = id;
            Matricula = matricula;
            Modelo = modelo;
            Marca = marca;
            AnoFabricacion = anoFabricacion;
            Estado = estado;
        }
    }
}
