using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class refactormodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations2",
                columns: table => new
                {
                    Destination2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations2", x => x.Destination2Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinations2",
                columns: new[] { "Destination2Id", "City", "Country", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Seattle", "USA", 5, "Good coffee, scenic bay, awesome market" },
                    { 2, "Paris", "France", 4, "Bon bageutte" },
                    { 3, "Tokyo", "Japan", 5, "So many weebs and ramen" },
                    { 4, "London", "England", 3, "Fish n chips mate!" },
                    { 5, "New York", "USA", 4, "Great Parks and Museums" }
                });
        }
    }
}
