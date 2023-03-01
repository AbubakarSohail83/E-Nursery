using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursery.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "Item",
        //        columns: table => new
        //        {
        //            Item_Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Item_Description = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
        //            Item_Price = table.Column<double>(type: "float", nullable: false),
        //            Item_Category = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
        //            Item_SubCategory = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Item", x => x.Item_Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OrderItem",
        //        columns: table => new
        //        {
        //            Order_Id = table.Column<int>(type: "int", nullable: false),
        //            Item_Id = table.Column<int>(type: "int", nullable: false),
        //            Quantity = table.Column<int>(type: "int", nullable: false),
        //            Item_Number = table.Column<int>(type: "int", nullable: false),
        //            TotalPrice = table.Column<double>(type: "float", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__OrderIte__A21F30FC660AEAA0", x => new { x.Order_Id, x.Item_Id });
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Users",
        //        columns: table => new
        //        {
        //            U_Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            U_Email = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: false),
        //            U_Password = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
        //            U_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
        //            U_Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
        //            U_Role = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
        //            U_Address = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__Users__5A2040BBA9586B96", x => x.U_Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Inventory",
        //        columns: table => new
        //        {
        //            Item_Id = table.Column<int>(type: "int", nullable: false),
        //            Item_Quantity = table.Column<int>(type: "int", nullable: false),
        //            Item_UnitPrice = table.Column<double>(type: "float", nullable: false),
        //            Item_InventoryValue = table.Column<double>(type: "float", nullable: false),
        //            Date_Added = table.Column<DateTime>(type: "date", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK__Inventor__3FB50874F286C6C5", x => x.Item_Id);
        //            table.ForeignKey(
        //                name: "invenory_fk_itemId",
        //                column: x => x.Item_Id,
        //                principalTable: "Item",
        //                principalColumn: "Item_Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Orders",
        //        columns: table => new
        //        {
        //            Order_Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            U_Id = table.Column<int>(type: "int", nullable: false),
        //            Order_ShippingMethod = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
        //            Order_Date = table.Column<DateTime>(type: "date", nullable: false),
        //            Order_Status = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Orders", x => x.Order_Id);
        //            table.ForeignKey(
        //                name: "order_fk_U_Id",
        //                column: x => x.U_Id,
        //                principalTable: "Users",
        //                principalColumn: "U_Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Orders_U_Id",
        //        table: "Orders",
        //        column: "U_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
