using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities.Models;
using System.Data.Entity;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicePedidos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicePedidos.svc o ServicePedidos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicePedidos : IServicePedidos
    {
        public int DeletePedido(Pedido Pedido)
        {
            Model ModelBD = new Model();
            ModelBD.Entry(Pedido).State = EntityState.Modified;
            int Retval = ModelBD.SaveChanges();
            return Retval;
        }

        public List<Pedido> GetAllPedidos()
        {
            Model ModelBD = new Model();
            IQueryable<Pedido> Pedidos = from c in ModelBD.Pedidos select c;
            return Pedidos.ToList();
        }

        public List<Pedido> GetAllPedidosByCliente(int IdCliente)
        {
            Model ModelBD = new Model();
            IQueryable<Pedido> Pedidos = from p in ModelBD.Pedidos where p.ClienteFK==IdCliente select p;
            return Pedidos.ToList();
        }
        
        public int InsertPedido(Pedido _Pedido)
        {

            Model ModelBD = new Model();
            ModelBD.Entry(_Pedido).State = EntityState.Added;
            int Retval = ModelBD.SaveChanges();
            return Retval;
        }
    }
}
