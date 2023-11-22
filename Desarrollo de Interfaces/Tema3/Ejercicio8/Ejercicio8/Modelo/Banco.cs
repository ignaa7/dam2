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

        public static Banco? BancoObjeto { get; set; }

        private Banco()
        {
            serializer = new XmlSerializer(typeof(List<Cliente>));
            Clientes = GetClientes();
        }

        public static Banco getInstance()
        {
            if (BancoObjeto == null)
            {
                return new Banco();
            }
            else
            {
                return BancoObjeto;
            }
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

        public List<string> GetDnis()
        {
            List<string> dnis = new List<string>();

            foreach (Cliente cliente in Clientes)
            {
                dnis.Add(cliente.Dni);
            }

            return dnis;
        }

        public Cliente? GetCliente(string dni)
        {
            return Clientes.Find(cliente => cliente.Dni == dni);
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
            if (File.Exists("banco.xml"))
            {
                using(TextReader reader = new StreamReader("banco.xml"))
                {
                    object? clientes = serializer.Deserialize(reader);

                    if (clientes != null)
                    {
                        return (List<Cliente>)clientes;
                    }

                    return new List<Cliente>();
                }
            }
            
            return new List<Cliente>();
        }
    }
}
