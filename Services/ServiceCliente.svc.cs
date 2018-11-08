using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCliente : IServiceCliente
    {
        public List<Cliente> GetAllClientes()
        {
            List<Cliente> clientes = new Business.Clientes.Clientes().GetAllClientes();
            return clientes;
        }

        public Cliente GetClienteById(string IdCliente)
        {
            Cliente cliente = new Business.Clientes.Clientes().GetClienteById(Int32.Parse(IdCliente));
            return cliente;
        }
    }
}
