using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CandyStore.Migrations
{
    /// <inheritdoc />
    public partial class CandyStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "Brown", "Chocolate" },
                    { 2, "Pink/Blue", "Fizzy Pop" },
                    { 3, "Beige", "Werthes's Original" },
                    { 4, "Red", "Ferrari" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candies");
        }
    }
}
