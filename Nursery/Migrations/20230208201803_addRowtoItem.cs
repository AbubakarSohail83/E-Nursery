using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursery.Migrations
{
    public partial class addRowtoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId2",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId2",
                table: "Item");
        }
    }
}
