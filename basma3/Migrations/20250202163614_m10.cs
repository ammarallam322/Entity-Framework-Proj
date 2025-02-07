using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basma3.Migrations
{
    /// <inheritdoc />
    public partial class m10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "empId",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Records_empId",
                table: "Records",
                column: "empId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Employees_empId",
                table: "Records",
                column: "empId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Employees_empId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_empId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "empId",
                table: "Records");
        }
    }
}
