using Ejercicio9_Jardineria.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9_Jardineria
{
    public partial class FormConsultarEmpleados : Form
    {
        private Servicio Servicio;

        public FormConsultarEmpleados()
        {
            InitializeComponent();

            Servicio = Servicio.GetInstance();

            foreach (int codigoJefe in Servicio.GetCodigosJefes())
            {
                cbCodigosJefes.Items.Add(codigoJefe);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            object jefe = cbCodigosJefes.SelectedItem;

            if (jefe != null)
            {
                int codigoJefe = Convert.ToInt32(jefe);

                List<Object> empleados = Servicio.ConsultarEmpleadosDeJefe(codigoJefe);

                foreach (dynamic empleado in empleados)
                {
                    lblEmpleados.Text += ($"Nombre: {empleado.nombre}\nPrimer apellido: {empleado.apellido1}\nSegundo apellido: {empleado.apellido2}\nEmail: {empleado.email}\n");
                }
            }
        }
    }
}
