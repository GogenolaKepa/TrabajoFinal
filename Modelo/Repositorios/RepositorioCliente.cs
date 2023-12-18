using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCliente
    {
        private List<Cliente> clientes;
        public RepositorioCliente() 
        {
            clientes = new List<Cliente>();
        }

        private static RepositorioCliente instancia;
        public static RepositorioCliente Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new RepositorioCliente();
                return instancia;
            }
        }
        public ReadOnlyCollection<Cliente> Clientes { get => clientes.AsReadOnly() ; }

        public bool AgregarCliente(Cliente cliente)
        {
            var clienteExiste = BuscarDni(cliente.Dni);
            if(clienteExiste == null)
            {
                clientes.Add(cliente);
                return true;
            }
               
            return false;
        }

        public bool EliminarCliente(int dni)
        {
            var clienteExistente = BuscarDni(dni);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
                return true;
            }
            return false;
        }
       
        public bool ModificarCliente (Cliente cliente)
        {
            var clienteExistente = BuscarDni(cliente.Dni);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
                clientes.Add(cliente);
                return true;
            }
            return false;

        }
       
        public Cliente BuscarDni(int dni)
        {
            return clientes.FirstOrDefault(clientes => clientes.Dni == dni);
        }
        public ReadOnlyCollection<Cliente> ObtenerClientes()
        {
           return clientes.AsReadOnly();
        }
    }
}
