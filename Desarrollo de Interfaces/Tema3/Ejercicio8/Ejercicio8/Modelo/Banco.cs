using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio8.Modelo
{
    internal class Banco
    {
        public List<Cliente> Clientes { get; set; }

        public XmlSerializer serializer { get; set; }

        public Banco()
        {
            serializer = new XmlSerializer(typeof(List<Cliente>));
            Clientes = GetClientes();
        }

        public void AgregarCliente(string dni, string nombre, string direccion, int edad, string telefono, string numeroCuentaCorriente)
        {
            Cliente cliente = new Cliente(dni, nombre, direccion, edad, telefono, numeroCuentaCorriente);
            Clientes.Add(cliente);

            GuardarClientes();
        }

        public bool ModificarCliente(string dni, string nombre, string direccion, int edad, string telefono, string numeroCuentaCorriente)
        {
            bool modificado = false;
            Cliente? cliente = Clientes.Find(cliente => cliente.Dni == dni);

            if (cliente != null)
            {
                cliente.Dni = dni;
                cliente.Nombre = nombre;
                cliente.Direccion = direccion;
                cliente.Edad = edad;
                cliente.Telefono = telefono;
                cliente.NumeroCuentaCorriente = numeroCuentaCorriente;

                GuardarClientes();

                modificado = true;
            }

            return modificado;
        }

        public bool EliminarCliente(string dni)
        {
            bool eliminado = false;
            Cliente? cliente = Clientes.Find(cliente => cliente.Dni == dni);

            if (cliente != null)
            {
                Clientes.Remove(cliente);

                GuardarClientes();

                eliminado = true;
            }

            return eliminado;
        }

        public string MostrarCliente(string dni)
        {
            Cliente? cliente = Clientes.Find(cliente => cliente.Dni == dni);

            if (cliente != null)
            {
                return cliente.ToString();
            }

            return "";
        }

        private void GuardarClientes()
        {
            using (TextWriter writer = new StreamWriter("banco.xml"))
            {
                serializer.Serialize(writer, Clientes);
            }
        }

        private List<Cliente> GetClientes()
        {
            using (TextReader reader = new StreamReader("people.xml"))
            {
                object? clientes = serializer.Deserialize(reader);

                if (clientes != null)
                {
                    return (List<Cliente>)clientes;
                }

                return new List<Cliente>();
            }
        }
    }
}
