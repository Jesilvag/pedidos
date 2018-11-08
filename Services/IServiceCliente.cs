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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
  
    public interface IServiceCliente
    {

        [OperationContract]
        [WebInvoke(Method ="GET",UriTemplate ="clientes",ResponseFormat =WebMessageFormat.Json)]
        List<Cliente> GetAllClientes();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "cliente/{IdCliente}", ResponseFormat = WebMessageFormat.Json)]
        
        string GetClienteById(string IdCliente);




        // TODO: agregue aquí sus operaciones de servicio
    }




}

