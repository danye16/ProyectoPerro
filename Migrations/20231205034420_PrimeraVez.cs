using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class PrimeraVez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idcollar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perros");
        }
    }
}
