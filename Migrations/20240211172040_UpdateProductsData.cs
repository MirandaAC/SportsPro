using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsPro.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2018, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2024, 2, 11, 12, 9, 4, 733, DateTimeKind.Local).AddTicks(8476));
        }
    }
}
