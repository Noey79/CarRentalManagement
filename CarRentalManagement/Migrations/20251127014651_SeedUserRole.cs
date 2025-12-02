using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1869dc43-8a67-43b2-83b0-395bcd363c4a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIIT9alv1cObaVZD6XqE7N2U9EJxWEOfKkW9k3lg2v65ofngIfvFFRb90+5SkEKaHg==", null, false, "48537e44-746a-4a76-a3b7-8f05ea435d3f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(2802), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(2826), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3012), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3014), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3083), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3085), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3086), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3088), new DateTime(2025, 11, 27, 9, 46, 50, 523, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9015), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9036), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9204), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9206), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9272), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9274), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9275), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9276), new DateTime(2025, 11, 27, 9, 25, 16, 425, DateTimeKind.Local).AddTicks(9277) });
        }
    }
}
