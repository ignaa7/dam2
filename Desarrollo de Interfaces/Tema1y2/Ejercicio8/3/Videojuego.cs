using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Videojuego : Entregable
    {
        private int horasEstimadasDefault = 10;
        private bool entregadoDefault = false;

        public string Titulo { get; set; }
        public int HorasEstimadas { get; set; }
        public bool Entregado { get; set; }
        public string Genero { get; set; }
        public string Compañia { get; set; }

        public Videojuego()
        {
            Titulo = default!;
            HorasEstimadas = horasEstimadasDefault;
            Entregado = entregadoDefault;
            Genero = default!;
            Compañia = default!;
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = entregadoDefault;
            Genero = default!;
            Compañia = default!;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = entregadoDefault;
            Genero = genero;
            Compañia = compañia;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}\nHoras estimadas: {HorasEstimadas}\nEntregado: {Entregado}\nGénero: {Genero}\nCompañía: {Compañia}";
        }

        public void entregar()
        {
            Entregado = true;
        }

        public void devolver()
        {
            Entregado = false;
        }

        public bool isEntregado()
        {
            return Entregado;
        }
    }
}
