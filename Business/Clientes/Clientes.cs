using Data.Clientes;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Clientes
{
   public  class Clientes
    {
        public List<Cliente> GetAllClientes()
        {
            List<Cliente> clientes = new ClienteData().GetAllClientes().ToList();
            return clientes;
        }
        public Cliente GetClienteById(int IdCLiente)
        {
            Cliente cliente = new ClienteData().GetClienteByID(IdCLiente);
            return cliente;
        }
    }
}
