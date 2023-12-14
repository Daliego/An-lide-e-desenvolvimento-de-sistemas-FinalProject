using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thirdProject.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_NotaDeVenda_NotaDeVendaId",
                table: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "NotaDeVendaId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_NotaDeVenda_NotaDeVendaId",
                table: "Cliente",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_NotaDeVenda_NotaDeVendaId",
                table: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "NotaDeVendaId",
                table: "Cliente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_NotaDeVenda_NotaDeVendaId",
                table: "Cliente",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");
        }
    }
}
