using Microsoft.EntityFrameworkCore.Migrations;

namespace Fletnix.Repositories.Migrations
{
    public partial class AddGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "CatalogItems");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "CatalogItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItems_GenreId",
                table: "CatalogItems",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_Genre_GenreId",
                table: "CatalogItems",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_Genre_GenreId",
                table: "CatalogItems");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_CatalogItems_GenreId",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "CatalogItems");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "CatalogItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
