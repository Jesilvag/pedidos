using Entities.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
namespace Services
{

    [KnownType(typeof(Cliente))]
    public class ServiceCliente : IServiceCliente
    {
        
        public List<Cliente> GetAllClientes()
        {
            Model ModelBD = new Model();
            var clientes = from c in ModelBD.Clientes select c;
            return clientes.ToList();

        }

        public Cliente GetClienteById(int IdCliente)
        {
            Model ModelBD = new Model();
            var cliente = from c in ModelBD.Clientes where c.IdCliente==IdCliente select c;
            return cliente.FirstOrDefault();
        }
    }
}
