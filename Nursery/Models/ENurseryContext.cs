using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Nursery.Models
{
    public partial class ENurseryContext : DbContext
    {
        public ENurseryContext()
        {
        }

        public ENurseryContext(DbContextOptions<ENurseryContext> options)
            : base(options)
        {
            ;
               }

        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=E-Nursery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Inventor__3FB50874F286C6C5");

                entity.ToTable("Inventory");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("Item_Id");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("Date_Added");

                entity.Property(e => e.ItemInventoryValue).HasColumnName("Item_InventoryValue");

                entity.Property(e => e.ItemQuantity).HasColumnName("Item_Quantity");

                entity.Property(e => e.ItemUnitPrice).HasColumnName("Item_UnitPrice");

                entity.HasOne(d => d.Item)
                    .WithOne(p => p.Inventory)
                    .HasForeignKey<Inventory>(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("invenory_fk_itemId");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.ItemId).HasColumnName("Item_Id");

                entity.Property(e => e.ItemCategory)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Item_Category")
                    .IsFixedLength(true);

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Item_Description");

                entity.Property(e => e.ItemPrice).HasColumnName("Item_Price");

                entity.Property(e => e.ItemSubCategory)
                    .HasMaxLength(20)
                    .HasColumnName("Item_SubCategory")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("Order_Date");

                entity.Property(e => e.OrderShippingMethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Order_ShippingMethod")
                    .IsFixedLength(true);

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Order_Status")
                    .IsFixedLength(true);

                entity.Property(e => e.UId).HasColumnName("U_Id");

                entity.HasOne(d => d.UIdNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_fk_U_Id");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ItemId })
                    .HasName("PK__OrderIte__A21F30FC660AEAA0");

                entity.ToTable("OrderItem");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.ItemId).HasColumnName("Item_Id");

                entity.Property(e => e.ItemNumber).HasColumnName("Item_Number");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__Users__5A2040BBA9586B96");

                entity.Property(e => e.UId).HasColumnName("U_Id");

                entity.Property(e => e.UAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("U_Address")
                    .IsFixedLength(true);

                entity.Property(e => e.UEmail)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("U_Email")
                    .IsFixedLength(true);

                entity.Property(e => e.UName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("U_Name");

                entity.Property(e => e.UPassword)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("U_Password")
                    .IsFixedLength(true);

                entity.Property(e => e.UPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("U_Phone");

                entity.Property(e => e.URole)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("U_Role")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
