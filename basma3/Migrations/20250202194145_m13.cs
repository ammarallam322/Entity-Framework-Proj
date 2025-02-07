using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace basma3.Migrations
{
    /// <inheritdoc />
    public partial class m13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "recordId", "Attendence", "day", "departure", "empId" },
                values: new object[,]
                {
                    { 4, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 5, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 },
                    { 6, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 },
                    { 7, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 },
                    { 8, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 },
                    { 9, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10 },
                    { 10, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 },
                    { 11, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 },
                    { 12, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 },
                    { 13, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 },
                    { 14, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 },
                    { 15, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5 },
                    { 16, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10 },
                    { 17, null, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "recordId",
                keyValue: 17);
        }
    }
}
