using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Services
{
    
    [KnownType(typeof(Cliente))]
    public class ServiceCliente : IServiceCliente
    {
        
        public List<Cliente> GetAllClientes()
        {
           List<Cliente> clientes = new Business.Clientes.Clientes().GetAllClientes();
         
           return clientes;
          
        }

        public string GetClienteById(string IdCliente)
        {
            Cliente cliente = new Business.Clientes.Clientes().GetClienteById(Int32.Parse(IdCliente));
            var json = JsonConvert.SerializeObject(cliente);
            return json;
        }
    }
}
