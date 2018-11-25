using Microsoft.EntityFrameworkCore.Migrations;

namespace Pedrinho.Migrations
{
    public partial class qualquercoisa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Contato",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Contato",
                newName: "sobrenome");

            migrationBuilder.AlterColumn<string>(
                name: "tipoAcesso",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Contato",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mensagem",
                table: "Contato",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "mensagem",
                table: "Contato");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Contato",
                newName: "usuarioId");

            migrationBuilder.RenameColumn(
                name: "sobrenome",
                table: "Contato",
                newName: "descricao");

            migrationBuilder.AlterColumn<string>(
                name: "tipoAcesso",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
