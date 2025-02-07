using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basma3.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropIndex(
                name: "IX_EmployeesRecords_empId",
                table: "EmployeesRecords");

            migrationBuilder.DropColumn(
                name: "empId",
                table: "EmployeesRecords");

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
                name: "IX_Reports_EmployeeId",
                table: "Reports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_RecordId",
                table: "Reports",
                column: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "empId",
                table: "EmployeesRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesRecords_empId",
                table: "EmployeesRecords",
                column: "empId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesRecords_Employees_empId",
                table: "EmployeesRecords",
                column: "empId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
