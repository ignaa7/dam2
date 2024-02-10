using Ejercicio10ControlGastos.Abstraction;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio10ControlGastos.MVVM.Models
{
    [Table("Transacciones")]
    public class Transaccion : TableData
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public Date Fecha { get; set; }
        public bool EsIngreso { get; set; }

        public Transaccion(string nombre, double cantidad, Date fecha, bool esIngreso)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Fecha = fecha;
            EsIngreso = esIngreso;
        }

        public Transaccion()
        {
            
        }
    }
}
