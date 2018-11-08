using Entities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Services
{

    [KnownType(typeof(Cliente))]
    public class ServiceCliente : IServiceCliente
    {
        
        public string GetAllClientes()
        {
           List<Cliente> clientes = new Business.Clientes.Clientes().GetAllClientes();
            var json = JsonConvert.SerializeObject(clientes);
           return json;
          
        }

        public string GetClienteById(string IdCliente)
        {
            Cliente cliente = new Business.Clientes.Clientes().GetClienteById(Int32.Parse(IdCliente));
            var json = JsonConvert.SerializeObject(cliente);
            return json;
        }
    }
}
