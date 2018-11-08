namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Productos")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            Pedido_Productos = new HashSet<Pedido_Productos>();
        }

        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        public int CategoriaFK { get; set; }

        public int Precio { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Productos> Pedido_Productos { get; set; }
    }
}
