using Microsoft.EntityFrameworkCore.Migrations;

namespace Pedrinho.Migrations
{
    public partial class qualquernom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contato",
                table: "contato");

            migrationBuilder.RenameTable(
                name: "contato",
                newName: "Contato");

            migrationBuilder.AddColumn<string>(
                name: "tipoAcesso",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contato",
                table: "Contato",
                column: "contatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contato",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "tipoAcesso",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Contato",
                newName: "contato");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contato",
                table: "contato",
                column: "contatoId");
        }
    }
}
