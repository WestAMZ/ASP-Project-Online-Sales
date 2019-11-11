namespace OnlineMarket.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MarketContext : DbContext
    {
        public MarketContext()
            : base("name=MarketContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ShipingData> ShipingData { get; set; }
        public virtual DbSet<Trademark> Trademark { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentCategory);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Model)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ProductImage>()
                .Property(e => e.ImageURL)
                .IsUnicode(false);

            modelBuilder.Entity<ShipingData>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ShipingData>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ShipingData>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Trademark>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
