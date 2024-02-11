using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsPro.Migrations
{
    /// <inheritdoc />
    public partial class YourMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearlyPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Name", "ReleaseDate", "YearlyPrice" },
                values: new object[,]
                {
                    { 1, "TRNY10", "Tournament Master 1.0", 2018, 4.99m },
                    { 2, "LEAG10", "League Scheduler 1.0", 2019, 4.99m },
                    { 3, "LEAGD10", "League Scheduler Deluxe 1.0", 2019, 7.99m },
                    { 4, "DRAFT10", "Draft Manager 1.0", 2020, 4.99m },
                    { 5, "TEAM10", "Team Manager 1.0", 2020, 4.99m },
                    { 6, "TRNY20", "Tournament Master 2.0", 2021, 5.99m },
                    { 7, "DRAFT20", "Draft Manager 2.0", 2022, 5.99m }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
