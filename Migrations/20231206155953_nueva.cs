using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Perros_CollarId",
                table: "Perros");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_CollarId",
                table: "Perros",
                column: "CollarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Perros_CollarId",
                table: "Perros");

            migrationBuilder.CreateIndex(
                name: "IX_Perros_CollarId",
                table: "Perros",
                column: "CollarId",
                unique: true);
        }
    }
}
