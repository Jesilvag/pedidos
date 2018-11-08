namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Serializable]
    public  class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [DataMember]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(20)]
        [DataMember]
        public string Cedula { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Telefono { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
