using Microsoft.EntityFrameworkCore.Migrations;

namespace RajvirsBooks.DataAccess.Migrations
{
    public partial class addProductToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "suthor",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "suthor",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
