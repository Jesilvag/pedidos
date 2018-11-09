using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProductos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProductos
    {
        [OperationContract]
        List<Producto> GetAllProductos();


        [OperationContract]
        List<Producto> GetAllProductosByCategoria(int IdCategoria);


        [OperationContract]
        Producto GetProductosById(int IdProducto);





    }
}
