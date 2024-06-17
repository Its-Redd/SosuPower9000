using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuPower.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMedicineTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "MedicineTasks",
                columns: table => new
                {
                    MedicineTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineTasks", x => x.MedicineTaskId);
                    table.ForeignKey(
                        name: "FK_MedicineTasks_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "MedicineId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_MedicineId",
                table: "MedicineTasks",
                column: "MedicineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicineTasks");

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
    }
}
