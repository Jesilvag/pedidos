using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Categoria" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Categoria.svc o Categoria.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCategoria : IServiceCategoria
    {
      

        public Categoria GetAllCategoriaById(int IdCategoria)
        {
            Model ModelBD = new Model();
            IQueryable<Categoria> Categorias = from c in ModelBD.Categorias select c;
            return Categorias.FirstOrDefault(x=>x.IdCategoria==IdCategoria);
        }

        public List<Categoria> GetAllCategorias()
        {
            Model ModelBD = new Model();
            IQueryable<Categoria> Categorias = from c in ModelBD.Categorias select c;
            return Categorias.ToList();
        }
    }
}
