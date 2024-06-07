using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuPower.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Meds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Administered",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Medicines");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskType",
                table: "SubTasks",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "SubTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_MedicineId",
                table: "SubTasks",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Medicines_MedicineId",
                table: "SubTasks",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Medicines_MedicineId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_MedicineId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "TaskType",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "SubTasks");

            migrationBuilder.AddColumn<bool>(
                name: "Administered",
                table: "Medicines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
