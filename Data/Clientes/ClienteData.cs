using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Clientes
{
    public class ClienteData
    {
        
        public List<Cliente> GetAllClientes()
        {
            ServiceReferenceClientes.ServiceClienteClient Service = new ServiceReferenceClientes.ServiceClienteClient("Services.ServiceCliente");
            List<Cliente> Lista=Service.GetAllClientes().ToList();
            return Lista;

        }
        public Cliente GetClienteByID(int IdCliente)
        {
            ServiceReferenceClientes.ServiceClienteClient Service = new ServiceReferenceClientes.ServiceClienteClient();
            Cliente Cliente = Service.GetClienteById(IdCliente);
            return Cliente;
        }
    }
}
