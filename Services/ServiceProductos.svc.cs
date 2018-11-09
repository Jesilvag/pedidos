using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities.Models;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProductos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProductos.svc o ServiceProductos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProductos : IServiceProductos
    {
        public List<Producto> GetAllProductos()
        {
            Model ModelBD = new Model();
            IQueryable<Producto> Productos = from p in ModelBD.Productos select p;
            return Productos.ToList();
        }

        public List<Producto> GetAllProductosByCategoria(int IdCategoria)
        {
            Model ModelBD = new Model();
            IQueryable<Producto> Productos = from p in ModelBD.Productos where p.CategoriaFK==IdCategoria select p;
            return Productos.ToList();
        }

        public Producto GetProductosById(int IdProducto)
        {
            Model ModelBD = new Model();
            IQueryable<Producto> Productos = (from p in ModelBD.Productos select p);
            return Productos.FirstOrDefault(x=>x.IdProducto==IdProducto);
        }
    }
}
