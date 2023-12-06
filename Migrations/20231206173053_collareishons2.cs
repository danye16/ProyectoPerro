using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class collareishons2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collars_Perros_PerroId",
                table: "Collars");

            migrationBuilder.DropColumn(
                name: "CollarId",
                table: "Collars");

            migrationBuilder.AlterColumn<int>(
                name: "PerroId",
                table: "Collars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Collars_Perros_PerroId",
                table: "Collars",
                column: "PerroId",
                principalTable: "Perros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collars_Perros_PerroId",
                table: "Collars");

            migrationBuilder.AlterColumn<int>(
                name: "PerroId",
                table: "Collars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CollarId",
                table: "Collars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Collars_Perros_PerroId",
                table: "Collars",
                column: "PerroId",
                principalTable: "Perros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
