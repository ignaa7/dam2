using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5c
{
    internal class Servicio
    {
        public static bool validar(string cadena)
        {
            bool esValida = true;
            Stack<char> pila = new Stack<char>();

            foreach (char caracter in cadena)
            {
                if (caracter == '(' || caracter == '[' || caracter == '{') pila.Push(caracter);
                else if (caracter ==  ')' || caracter == ']' || caracter == '}')
                {
                    if (pila.Count == 0)
                    {
                        esValida = false;
                    }
                    else
                    {
                        switch (caracter)
                        {
                            case ')':
                                if (pila.Pop() != '(') esValida = false;
                                break;
                            case ']':
                                if (pila.Pop() != '[') esValida = false;
                                break;
                            case '}':
                                if (pila.Pop() != '{') esValida = false;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return esValida;
        }
    }
}
