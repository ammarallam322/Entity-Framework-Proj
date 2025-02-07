using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basma3.Migrations
{
    /// <inheritdoc />
    public partial class m61 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "EmployeesRecords");

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    recordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attendence = table.Column<DateTime>(type: "datetime2", nullable: true),
                    departure = table.Column<DateTime>(type: "datetime2", nullable: true),
                    day = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.recordId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_day",
                table: "Records",
                column: "day");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.CreateTable(
                name: "EmployeesRecords",
                columns: table => new
                {
                    recordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attendence = table.Column<DateTime>(type: "datetime2", nullable: true),
                    day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    departure = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesRecords", x => x.recordId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    repordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.repordId);
                    table.ForeignKey(
                        name: "FK_Reports_EmployeesRecords_RecordId",
                        column: x => x.RecordId,
                        principalTable: "EmployeesRecords",
                        principalColumn: "recordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesRecords_day",
                table: "EmployeesRecords",
                column: "day");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_EmployeeId",
                table: "Reports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_RecordId",
                table: "Reports",
                column: "RecordId");
        }
    }
}
