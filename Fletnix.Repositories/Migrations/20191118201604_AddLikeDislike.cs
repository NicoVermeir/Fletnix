using Microsoft.EntityFrameworkCore.Migrations;

namespace Fletnix.Repositories.Migrations
{
    public partial class AddLikeDislike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountOfDislikes",
                table: "CatalogItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmountOfLikes",
                table: "CatalogItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfDislikes",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "AmountOfLikes",
                table: "CatalogItems");
        }
    }
}
