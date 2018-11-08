namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pedido_Productos
    {
        public int ProductoFK { get; set; }

        public int PedidoFK { get; set; }

        public int Cantidad { get; set; }

        [Key]
        public int IdProductoPedido { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
