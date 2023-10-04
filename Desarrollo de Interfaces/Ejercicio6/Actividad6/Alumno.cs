using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad6
{
    public class Alumno
    {
        static void Main(string[] args)
        {
        }

        public string Nombre { get; set; }
        public int Nota { get; set; }

        public static List<string> getNombres(List<Alumno> alumnos)
        {
            return alumnos.Select(alumno => alumno.Nombre).ToList();
            throw new NotImplementedException();
        }

        public static Alumno getListadoNota(List<Alumno> alumnos, int nota)
        {
            return alumnos.FirstOrDefault(alumno => alumno.Nota == nota);
            throw new NotImplementedException();
        }

        public static Alumno getPrimerAlumno(List<Alumno> alumnos)
        {
            return alumnos.FirstOrDefault();
            throw new NotImplementedException();
        }

        public static Alumno getUltimoAlumno(List<Alumno> alumnos)
        {
            return alumnos.LastOrDefault();
            throw new NotImplementedException();
        }

        public static int getSumaNota(List<Alumno> alumnos)
        {
            return alumnos.Sum(alumno => alumno.Nota);
            throw new NotImplementedException();
        }

        public static int getNotaMaxima(List<Alumno> alumnos)
        {
            return alumnos.Max(alumno => alumno.Nota);
            throw new NotImplementedException();
        }

        public static int getNotaMinima(List<Alumno> alumnos)
        {
            return alumnos.Min(alumno => alumno.Nota);
            throw new NotImplementedException();
        }

        public static int getNotaPorNombre(List<Alumno> alumnos, string v)
        {
            return alumnos.FirstOrDefault(alumno => alumno.Nombre.Equals(v)).Nota;
            throw new NotImplementedException();
        }

        public static double getNotaMedia(List<Alumno> alumnos)
        {
            return Math.Round(alumnos.Average(alumno => alumno.Nota), 2);
            throw new NotImplementedException();
        }
    }
}
