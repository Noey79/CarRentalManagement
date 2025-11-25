using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(8313), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(8341), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(8345), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(8346), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9002), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9007), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9008), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9188), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9189), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9193), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9194), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9197), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9199), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9202), new DateTime(2025, 11, 25, 16, 33, 6, 268, DateTimeKind.Local).AddTicks(9203), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
