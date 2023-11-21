using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio8
{
    internal class Banco
    {
        public List<Cliente> Clientes { get; set; }

        public XmlSerializer serializer { get; set; }

        public Banco()
        {
            serializer = new XmlSerializer(typeof(List<Cliente>));
        }

        public bool agregarCliente(string dni, string nombre, string direccion,  int edad, string telefono, string numeroCuentaCorriente)
        {
            bool correcto = false;

            Cliente cliente = new Cliente(dni, nombre, direccion, edad, telefono, numeroCuentaCorriente);
            Clientes.Add(cliente);

            using (TextWriter writer = new StreamWriter("banco.xml"))
            {
                serializer.Serialize(writer, Clientes);
            }

            return correcto;
        }

        public bool modificarCliente(string dni, string nombre, string direccion, int edad, string telefono, string numeroCuentaCorriente)
        {
            bool correcto = false;

            return correcto;
        }

        public bool eliminarCliente(string dni)
        {
            bool correcto = false;

            return correcto;
        }

        public string mostrarCliente(string dni)
        {
            Cliente? cliente = Clientes.Find(cliente => cliente.Dni == dni);

            if (cliente != null)
            {
                return cliente.ToString();
            }

            return "";
        }

        private List<Cliente> GetClientes()
        {
            using (TextReader reader = new StreamReader("people.xml"))
            {
                object? clientes = serializer.Deserialize(reader);

                if (clientes != null )
                {
                    return (List<Cliente>) clientes;
                }

                return new List<Cliente>();
            }
        }
    }
}
