using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class SeedingDataVersion2Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations2",
                keyColumn: "Destination2Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations2",
                keyColumn: "Destination2Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations2",
                keyColumn: "Destination2Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations2",
                keyColumn: "Destination2Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations2",
                keyColumn: "Destination2Id",
                keyValue: 5);
        }
    }
}
