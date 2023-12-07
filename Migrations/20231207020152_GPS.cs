using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class GPS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gpss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rango = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicionCasa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicionPerro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CollarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gpss_Collars_CollarId",
                        column: x => x.CollarId,
                        principalTable: "Collars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gpss_CollarId",
                table: "Gpss",
                column: "CollarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gpss");
        }
    }
}
