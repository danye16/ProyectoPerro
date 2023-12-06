using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perros_Collar_CollarId",
                table: "Perros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collar",
                table: "Collar");

            migrationBuilder.RenameTable(
                name: "Collar",
                newName: "Collars");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Perros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collars",
                table: "Collars",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idperro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perros_UsuarioId",
                table: "Perros",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perros_Collars_CollarId",
                table: "Perros",
                column: "CollarId",
                principalTable: "Collars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perros_Usuarios_UsuarioId",
                table: "Perros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perros_Collars_CollarId",
                table: "Perros");

            migrationBuilder.DropForeignKey(
                name: "FK_Perros_Usuarios_UsuarioId",
                table: "Perros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Perros_UsuarioId",
                table: "Perros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collars",
                table: "Collars");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Perros");

            migrationBuilder.RenameTable(
                name: "Collars",
                newName: "Collar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collar",
                table: "Collar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perros_Collar_CollarId",
                table: "Perros",
                column: "CollarId",
                principalTable: "Collar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
