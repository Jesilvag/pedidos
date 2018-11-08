namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedidos")]
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            Pedido_Productos = new HashSet<Pedido_Productos>();
        }

        [Key]
        public int IdPedido { get; set; }

        public int ValorTotal { get; set; }

        public int ClienteFK { get; set; }

     
        public int CantidadTotal { get; set; }

        public Boolean Estado { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Productos> Pedido_Productos { get; set; }
    }
}
