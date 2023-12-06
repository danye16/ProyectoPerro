using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class Collar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollarId",
                table: "Perros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Collar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perros_CollarId",
                table: "Perros",
                column: "CollarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Perros_Collar_CollarId",
                table: "Perros",
                column: "CollarId",
                principalTable: "Collar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perros_Collar_CollarId",
                table: "Perros");

            migrationBuilder.DropTable(
                name: "Collar");

            migrationBuilder.DropIndex(
                name: "IX_Perros_CollarId",
                table: "Perros");

            migrationBuilder.DropColumn(
                name: "CollarId",
                table: "Perros");
        }
    }
}
