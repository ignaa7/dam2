using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Tecnico : Operario
    {
        public Tecnico(string nombre) : base(nombre) { }

        public override string ToString()
        {
            return $"{base.ToString()} -> Técnico";
        }
    }
}
