using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Servicio
    {
        public static bool comprobarFormatoFecha(string cadena)
        {
            string patron = @"^\d{2}/\d{2}/\d{4}$";

            return Regex.Match(cadena, patron).Success;
        }

        public static bool comprobarFormatoCorreo(string cadena)
        {
            string patron = @"^\w+@\w+\.\w+$";

            return Regex.Match(cadena, patron).Success;
        }

        public static bool comprobarFormatoTelefono(string cadena)
        {
            string patron = @"^\d{3}-\d{3}-\d{4}$";

            return Regex.Match(cadena, patron).Success;
        }

        public static bool comprobarFormatoIp(string cadena)
        {
            string patron = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$";

            return Regex.Match(cadena, patron).Success;
        }

        public static bool comprobarFormatoMac(string cadena)
        {
            string patron = @"^\w{2}:\w{2}:\w{2}:\w{2}:\w{2}:\w{2}$";

            return Regex.Match(cadena, patron).Success;
        }

        public static string buscarPalabrasPorLetra(string cadena, char letra)
        {
            String[] palabras = cadena.Split(" ");
            MatchCollection palabrasLetra = Regex.Matches(cadena, $@"{letra}\w*");

            string cadenaPalabrasLetra = " ";
            foreach(Match palabra in palabrasLetra)
            {
                cadenaPalabrasLetra += $"{palabra.Value} ";
            }

            return cadenaPalabrasLetra;
        }
    }
}
