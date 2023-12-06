using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoPerro.Migrations
{
    public partial class collars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CollarModelo",
                table: "Collars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollarModelo",
                table: "Collars");
        }
    }
}
