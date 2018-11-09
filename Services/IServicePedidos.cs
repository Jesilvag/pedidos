using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicePedidos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicePedidos
    {
        [OperationContract]
        List<Pedido> GetAllPedidos();

        [OperationContract]
        List<Pedido> GetAllPedidosByCliente(int IdCliente);


      

        [OperationContract]
        int InsertPedido(Pedido _Pedido);

        [OperationContract]
        int DeletePedido(Pedido IdPedido);
    }
}
