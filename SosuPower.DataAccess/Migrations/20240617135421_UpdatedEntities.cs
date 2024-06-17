using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuPower.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_TaskId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Medicines");

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "MedicineTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_TaskId",
                table: "SubTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_TaskId",
                table: "MedicineTasks",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_Tasks_TaskId",
                table: "MedicineTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Tasks_TaskId",
                table: "SubTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_Tasks_TaskId",
                table: "MedicineTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Tasks_TaskId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_TaskId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_MedicineTasks_TaskId",
                table: "MedicineTasks");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "MedicineTasks");

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_TaskId",
                table: "Medicines",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }
    }
}
