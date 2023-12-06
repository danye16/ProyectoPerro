using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class prue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perros_Collars_CollarId",
                table: "Perros");

            migrationBuilder.DropTable(
                name: "Collars");

            migrationBuilder.DropIndex(
                name: "IX_Perros_CollarId",
                table: "Perros");

            migrationBuilder.DropColumn(
                name: "CollarId",
                table: "Perros");

            migrationBuilder.DropColumn(
                name: "Idcollar",
                table: "Perros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollarId",
                table: "Perros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Idcollar",
                table: "Perros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Collars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollarModelo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collars", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perros_CollarId",
                table: "Perros",
                column: "CollarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perros_Collars_CollarId",
                table: "Perros",
                column: "CollarId",
                principalTable: "Collars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
