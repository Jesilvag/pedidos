using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Clientes
{
    public class ClienteData
    {
        public List<Cliente> GetAllClientes()
        {
            Model ModelBD = new Model();
            var clientes = from c in ModelBD.Clientes select c;
            return clientes.ToList();
        }
        public Cliente GetClienteByID(int IdCliente)
        {
            Model ModelBD = new Model();
            var clientes = from c in ModelBD.Clientes select c;
            return clientes.ToList().FirstOrDefault();

        }
    }
}
