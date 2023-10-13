using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Serie : Entregable
    {
        int numeroTemporadasDefault = 3;
        bool entregadoDefault = false;

        public string Titulo { get; set; }
        public int NumeroTemporadas { get; set; }
        public bool Entregado { get; set; }
        public string Genero { get; set; }
        public string Creador { get; set; }

        public Serie()
        {
            Titulo = default!;
            NumeroTemporadas = numeroTemporadasDefault;
            Entregado = entregadoDefault;
            Genero = default!;
            Creador = default!;
        }

        public Serie(string titulo, string creador)
        {
            Titulo = titulo;
            NumeroTemporadas = numeroTemporadasDefault;
            Entregado = entregadoDefault;
            Genero = default!;
            Creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            Titulo = titulo;
            NumeroTemporadas = numeroTemporadas;
            Entregado = entregadoDefault;
            Genero = genero;
            Creador = creador;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}\nNúmero de temporadas: {NumeroTemporadas}\nEntregado: {Entregado}\nGénero: {Genero}\nCreador: {Creador}";
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
