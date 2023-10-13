using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Oficial : Operario
    {
        public Oficial(string nombre) : base(nombre) { }

        public override string ToString()
        {
            return $"{base.ToString()} -> Oficial";
        }
    }
}
