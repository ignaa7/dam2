using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class CuentaEmpresarial : CuentaBancaria
    {
        public CuentaEmpresarial()
        {
            
        }

        public String RealizarTransferencia(CuentaBancaria cuenta, double cantidad)
        {
            return base.RealizarTransferencia(cuenta, cantidad);
        }
    }
}
