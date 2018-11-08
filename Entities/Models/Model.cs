namespace Entities.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Pedido_Productos> Pedido_Productos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categoria)
                .HasForeignKey(e => e.CategoriaFK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Pedidos)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.ClienteFK)
                .WillCascadeOnDelete(false);

          

            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.Pedido_Productos)
                .WithRequired(e => e.Pedido)
                .HasForeignKey(e => e.PedidoFK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Pedido_Productos)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => e.ProductoFK)
                .WillCascadeOnDelete(false);
        }
    }
}
