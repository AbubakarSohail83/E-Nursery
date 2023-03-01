﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nursery.Models;

namespace Nursery.Migrations
{
    [DbContext(typeof(ENurseryContext))]
    [Migration("20230208200755_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nursery.Models.Inventory", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("Item_Id");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("date")
                        .HasColumnName("Date_Added");

                    b.Property<double>("ItemInventoryValue")
                        .HasColumnType("float")
                        .HasColumnName("Item_InventoryValue");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int")
                        .HasColumnName("Item_Quantity");

                    b.Property<double>("ItemUnitPrice")
                        .HasColumnType("float")
                        .HasColumnName("Item_UnitPrice");

                    b.HasKey("ItemId")
                        .HasName("PK__Inventor__3FB50874F286C6C5");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Nursery.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Item_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemCategory")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Item_Category")
                        .IsFixedLength(true);

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Item_Description");

                    b.Property<double>("ItemPrice")
                        .HasColumnType("float")
                        .HasColumnName("Item_Price");

                    b.Property<string>("ItemSubCategory")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Item_SubCategory")
                        .IsFixedLength(true);

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Nursery.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Order_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("Order_Date");

                    b.Property<string>("OrderShippingMethod")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("Order_ShippingMethod")
                        .IsFixedLength(true);

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("Order_Status")
                        .IsFixedLength(true);

                    b.Property<int>("UId")
                        .HasColumnType("int")
                        .HasColumnName("U_Id");

                    b.HasKey("OrderId");

                    b.HasIndex("UId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Nursery.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("Order_Id");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("Item_Id");

                    b.Property<int>("ItemNumber")
                        .HasColumnType("int")
                        .HasColumnName("Item_Number");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderId", "ItemId")
                        .HasName("PK__OrderIte__A21F30FC660AEAA0");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Nursery.Models.User", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("U_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .HasColumnName("U_Address")
                        .IsFixedLength(true);

                    b.Property<string>("UEmail")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("U_Email")
                        .IsFixedLength(true);

                    b.Property<string>("UName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("U_Name");

                    b.Property<string>("UPassword")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("U_Password")
                        .IsFixedLength(true);

                    b.Property<string>("UPhone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("U_Phone");

                    b.Property<string>("URole")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("U_Role")
                        .IsFixedLength(true);

                    b.HasKey("UId")
                        .HasName("PK__Users__5A2040BBA9586B96");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nursery.Models.Inventory", b =>
                {
                    b.HasOne("Nursery.Models.Item", "Item")
                        .WithOne("Inventory")
                        .HasForeignKey("Nursery.Models.Inventory", "ItemId")
                        .HasConstraintName("invenory_fk_itemId")
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Nursery.Models.Order", b =>
                {
                    b.HasOne("Nursery.Models.User", "UIdNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("UId")
                        .HasConstraintName("order_fk_U_Id")
                        .IsRequired();

                    b.Navigation("UIdNavigation");
                });

            modelBuilder.Entity("Nursery.Models.Item", b =>
                {
                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Nursery.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
