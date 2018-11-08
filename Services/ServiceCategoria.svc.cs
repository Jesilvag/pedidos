using Entities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
   
   
    [KnownType(typeof(Categoria))]
    public class ServiceCategoria:IServiceCategoria
    {
                
       
        public string GetAllCategorias()
        {
            // Agregue aquí la implementación de la operación
            List<Categoria> categorias = new Business.Categorias.Categorias().GetAllCategorias();
            var json = JsonConvert.SerializeObject(categorias);
            return json;
        }

        // Agregue aquí más operaciones y márquelas con [OperationContract]
    }
}
