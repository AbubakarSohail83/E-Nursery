using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursery.Migrations
{
    public partial class Aduit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId2",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Item",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedUserId",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LastModifiedUserId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "ItemId2",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
