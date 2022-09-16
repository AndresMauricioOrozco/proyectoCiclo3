using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mecanico",
                table: "Mecanico");

            migrationBuilder.RenameTable(
                name: "Mecanico",
                newName: "Persona");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Mecanico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mecanico",
                table: "Mecanico",
                column: "Id");
        }
    }
}
