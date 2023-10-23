using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            string cadena = "";

            foreach(string parteCadena in vs)
            {
                cadena += parteCadena;
            }

            return cadena;

            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            string cadena = "";

            Array.Sort(vs);

            foreach(string parteCadena in vs) cadena += parteCadena;

            return cadena;

            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {
            int cont = 0;

            foreach(string parteCadena in vs)
            {
                if (parteCadena.Contains(v)) cont++;
            }

            return cont;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            List<int> sumas = new List<int>();

            for (int i = 0; i < vs1.Length; i++)
            {
                sumas.Add(vs1[i] + vs2[i]);
            }

            return sumas.ToArray();

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            List<int> multiplicaciones = new List<int>();

            for (int i = 0; i < vs1.Length; i++)
            {
                multiplicaciones.Add(vs1[i] * vs2[i]);
            }

            return multiplicaciones.ToArray();

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            string[] partesCadena = entrada.Split(" ");
            string cadena = "";
            
            foreach (string parteCadena in partesCadena)
            {
                cadena += parteCadena;
            }

            cadena = cadena.ToLower().Trim();

            string cadenaAlReves = "";

            foreach (char caracter in cadena)
            {
                cadenaAlReves += caracter;
            }

            return cadena.Equals(cadenaAlReves);

            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            List<string> palabras = new List<string>();
            string[] palabrasArray = entrada.Split(" ");

            foreach (string palabraArray in palabrasArray)
            {
                if (palabraArray != "") palabras.Add(palabraArray);
            }

            return palabras.Count;

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            string[] partesCadena = entrada.Split(" ");
            string cadena = "";

            foreach (string parteCadena in partesCadena)
            {
                cadena += parteCadena;
            }

            return cadena.Count();

            throw new NotImplementedException();
        }
    }
}
