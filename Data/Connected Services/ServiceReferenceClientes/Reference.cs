﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.ServiceReferenceClientes {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName= "Services.IServiceCliente")]
    public interface IServiceCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetAllClientes", ReplyAction="http://tempuri.org/IServiceCliente/GetAllClientesResponse")]
        System.Collections.Generic.List<Entities.Models.Cliente> GetAllClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetAllClientes", ReplyAction="http://tempuri.org/IServiceCliente/GetAllClientesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entities.Models.Cliente>> GetAllClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetClienteById", ReplyAction="http://tempuri.org/IServiceCliente/GetClienteByIdResponse")]
        Entities.Models.Cliente GetClienteById(int IdCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/GetClienteById", ReplyAction="http://tempuri.org/IServiceCliente/GetClienteByIdResponse")]
        System.Threading.Tasks.Task<Entities.Models.Cliente> GetClienteByIdAsync(int IdCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceClienteChannel : Data.ServiceReferenceClientes.IServiceCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClienteClient : System.ServiceModel.ClientBase<Data.ServiceReferenceClientes.IServiceCliente>, Data.ServiceReferenceClientes.IServiceCliente {
        
        public ServiceClienteClient() {
        }
        
        public ServiceClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Entities.Models.Cliente> GetAllClientes() {
            return base.Channel.GetAllClientes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entities.Models.Cliente>> GetAllClientesAsync() {
            return base.Channel.GetAllClientesAsync();
        }
        
        public Entities.Models.Cliente GetClienteById(int IdCliente) {
            return base.Channel.GetClienteById(IdCliente);
        }
        
        public System.Threading.Tasks.Task<Entities.Models.Cliente> GetClienteByIdAsync(int IdCliente) {
            return base.Channel.GetClienteByIdAsync(IdCliente);
        }
    }
}
