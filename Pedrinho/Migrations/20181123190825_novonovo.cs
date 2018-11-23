using Microsoft.EntityFrameworkCore.Migrations;

namespace Pedrinho.Migrations
{
    public partial class novonovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Bug",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "resposta",
                table: "Bug",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resposta",
                table: "Bug");

            migrationBuilder.AlterColumn<int>(
                name: "descricao",
                table: "Bug",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
