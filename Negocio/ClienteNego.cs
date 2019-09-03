using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;
using System.Configuration;

namespace Negocio
{
    public class ClienteNego
    {
        ClienteRepo clienteRepo = new ClienteRepo();

        public void GuardarCliente(Cliente cliente)
        {
            clienteRepo.GuardarCliente(cliente);
        }

        public void BorrarCliente(Cliente cliente)
        {
            clienteRepo.BorrarCliente(cliente);
        }

        public DataTable ListarCliente()
        {
            return clienteRepo.ListarCliente();
        }    
        
        public void ModificarCliente(Cliente cliente)
        {
            clienteRepo.ModificarCliente(cliente);
        }
        public Cliente BuscarClientePorID(int idCliente)
        {
            return clienteRepo.BuscarClientePorID(idCliente);
        }
    }
}