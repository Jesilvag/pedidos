using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [ServiceContract]
  public  interface IServiceCategoria
    {

        [OperationContract]
        [WebInvoke(Method ="GET",ResponseFormat =WebMessageFormat.Json,UriTemplate ="categorias")]
        string GetAllCategorias();
    }
}
