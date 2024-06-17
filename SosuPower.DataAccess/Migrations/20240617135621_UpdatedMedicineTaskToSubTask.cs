using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuPower.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMedicineTaskToSubTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "MedicineTasks",
                newName: "Completed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Completed",
                table: "MedicineTasks",
                newName: "IsCompleted");
        }
    }
}
