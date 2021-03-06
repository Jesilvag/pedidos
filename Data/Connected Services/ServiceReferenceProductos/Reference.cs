﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.ServiceReferenceProductos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceProductos.IServiceProductos")]
    public interface IServiceProductos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProductos/GetAllProductos", ReplyAction="http://tempuri.org/IServiceProductos/GetAllProductosResponse")]
        Entities.Models.Producto[] GetAllProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProductos/GetAllProductos", ReplyAction="http://tempuri.org/IServiceProductos/GetAllProductosResponse")]
        System.Threading.Tasks.Task<Entities.Models.Producto[]> GetAllProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProductos/GetAllProductosByCategoria", ReplyAction="http://tempuri.org/IServiceProductos/GetAllProductosByCategoriaResponse")]
        Entities.Models.Producto[] GetAllProductosByCategoria(int IdCategoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProductos/GetAllProductosByCategoria", ReplyAction="http://tempuri.org/IServiceProductos/GetAllProductosByCategoriaResponse")]
        System.Threading.Tasks.Task<Entities.Models.Producto[]> GetAllProductosByCategoriaAsync(int IdCategoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProductos/GetProductosById", ReplyAction="http://tempuri.org/IServiceProductos/GetProductosByIdResponse")]
        Entities.Models.Producto GetProductosById(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProductos/GetProductosById", ReplyAction="http://tempuri.org/IServiceProductos/GetProductosByIdResponse")]
        System.Threading.Tasks.Task<Entities.Models.Producto> GetProductosByIdAsync(int IdProducto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceProductosChannel : Data.ServiceReferenceProductos.IServiceProductos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProductosClient : System.ServiceModel.ClientBase<Data.ServiceReferenceProductos.IServiceProductos>, Data.ServiceReferenceProductos.IServiceProductos {
        
        public ServiceProductosClient() {
        }
        
        public ServiceProductosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProductosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Entities.Models.Producto[] GetAllProductos() {
            return base.Channel.GetAllProductos();
        }
        
        public System.Threading.Tasks.Task<Entities.Models.Producto[]> GetAllProductosAsync() {
            return base.Channel.GetAllProductosAsync();
        }
        
        public Entities.Models.Producto[] GetAllProductosByCategoria(int IdCategoria) {
            return base.Channel.GetAllProductosByCategoria(IdCategoria);
        }
        
        public System.Threading.Tasks.Task<Entities.Models.Producto[]> GetAllProductosByCategoriaAsync(int IdCategoria) {
            return base.Channel.GetAllProductosByCategoriaAsync(IdCategoria);
        }
        
        public Entities.Models.Producto GetProductosById(int IdProducto) {
            return base.Channel.GetProductosById(IdProducto);
        }
        
        public System.Threading.Tasks.Task<Entities.Models.Producto> GetProductosByIdAsync(int IdProducto) {
            return base.Channel.GetProductosByIdAsync(IdProducto);
        }
    }
}
