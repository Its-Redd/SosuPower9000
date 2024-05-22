using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuPower.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migrants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CareCenterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_CareCenters_CareCenterId",
                        column: x => x.CareCenterId,
                        principalTable: "CareCenters",
                        principalColumn: "CareCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTask",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTask", x => new { x.EmployeesEmployeeId, x.TasksTaskId });
                    table.ForeignKey(
                        name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTask_Tasks_TasksTaskId",
                        column: x => x.TasksTaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Administered = table.Column<bool>(type: "bit", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.MedicineId);
                    table.ForeignKey(
                        name: "FK_Medicine_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CareCenterId",
                table: "Employees",
                column: "CareCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTask_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_TaskId",
                table: "Medicine",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ResidentId",
                table: "Tasks",
                column: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles");

            migrationBuilder.DropTable(
                name: "EmployeeTask");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Roles");
        }
    }
}
