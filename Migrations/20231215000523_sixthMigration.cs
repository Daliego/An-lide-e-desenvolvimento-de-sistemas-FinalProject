using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thirdProject.Migrations
{
    public partial class sixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_NotaDeVenda_NotaDeVendaId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Marca_Produto_ProdutoId",
                table: "Marca");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Item_ItemId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Pagamento_PagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Item_ItemId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoDePagamento_NotaDeVenda_NotaDeVendaId",
                table: "TipoDePagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Transportadora_NotaDeVenda_NotaDeVendaId",
                table: "Transportadora");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_NotaDeVenda_NotaDeVendaId",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_NotaDeVendaId",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transportadora",
                table: "Transportadora");

            migrationBuilder.DropIndex(
                name: "IX_Transportadora_NotaDeVendaId",
                table: "Transportadora");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDePagamento",
                table: "TipoDePagamento");

            migrationBuilder.DropIndex(
                name: "IX_TipoDePagamento_NotaDeVendaId",
                table: "TipoDePagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotaDeVenda",
                table: "NotaDeVenda");

            migrationBuilder.DropIndex(
                name: "IX_NotaDeVenda_PagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marca",
                table: "Marca");

            migrationBuilder.DropIndex(
                name: "IX_Marca_ProdutoId",
                table: "Marca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_NotaDeVendaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "DataLimite",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Transportadora");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "TipoDePagamento");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Marca");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Vendedor",
                newName: "Vendedores");

            migrationBuilder.RenameTable(
                name: "Transportadora",
                newName: "Transportadoras");

            migrationBuilder.RenameTable(
                name: "TipoDePagamento",
                newName: "TiposDePagamento");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "NotaDeVenda",
                newName: "NotasDeVendas");

            migrationBuilder.RenameTable(
                name: "Marca",
                newName: "Marcas");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "NomeDoCobrador",
                table: "TiposDePagamento",
                newName: "NomeDoCobrado");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Produtos",
                newName: "MarcaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_ItemId",
                table: "Produtos",
                newName: "IX_Produtos_MarcaId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "NotasDeVendas",
                newName: "VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_ItemId",
                table: "NotasDeVendas",
                newName: "IX_NotasDeVendas_VendedorId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Marcas",
                newName: "Nome");

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Pagamento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "NotasDeVendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoDePagamentoId",
                table: "NotasDeVendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportadoraId",
                table: "NotasDeVendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transportadoras",
                table: "Transportadoras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposDePagamento",
                table: "TiposDePagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotasDeVendas",
                table: "NotasDeVendas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_NotaDeVendaId",
                table: "Pagamento",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVendas_ClienteId",
                table: "NotasDeVendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVendas_TipoDePagamentoId",
                table: "NotasDeVendas",
                column: "TipoDePagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVendas_TransportadoraId",
                table: "NotasDeVendas",
                column: "TransportadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProdutoId",
                table: "Items",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVendas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Produtos_ProdutoId",
                table: "Items",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_Clientes_ClienteId",
                table: "NotasDeVendas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_TiposDePagamento_TipoDePagamentoId",
                table: "NotasDeVendas",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_Transportadoras_TransportadoraId",
                table: "NotasDeVendas",
                column: "TransportadoraId",
                principalTable: "Transportadoras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_Vendedores_VendedorId",
                table: "NotasDeVendas",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_NotasDeVendas_NotaDeVendaId",
                table: "Pagamento",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVendas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Produtos_ProdutoId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_Clientes_ClienteId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_TiposDePagamento_TipoDePagamentoId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_Transportadoras_TransportadoraId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_Vendedores_VendedorId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_NotasDeVendas_NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transportadoras",
                table: "Transportadoras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposDePagamento",
                table: "TiposDePagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotasDeVendas",
                table: "NotasDeVendas");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVendas_ClienteId",
                table: "NotasDeVendas");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVendas_TipoDePagamentoId",
                table: "NotasDeVendas");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVendas_TransportadoraId",
                table: "NotasDeVendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ProdutoId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "NotasDeVendas");

            migrationBuilder.DropColumn(
                name: "TipoDePagamentoId",
                table: "NotasDeVendas");

            migrationBuilder.DropColumn(
                name: "TransportadoraId",
                table: "NotasDeVendas");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Vendedores",
                newName: "Vendedor");

            migrationBuilder.RenameTable(
                name: "Transportadoras",
                newName: "Transportadora");

            migrationBuilder.RenameTable(
                name: "TiposDePagamento",
                newName: "TipoDePagamento");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produto");

            migrationBuilder.RenameTable(
                name: "NotasDeVendas",
                newName: "NotaDeVenda");

            migrationBuilder.RenameTable(
                name: "Marcas",
                newName: "Marca");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "NomeDoCobrado",
                table: "TipoDePagamento",
                newName: "NomeDoCobrador");

            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "Produto",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produto",
                newName: "IX_Produto_ItemId");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "NotaDeVenda",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVendas_VendedorId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_ItemId");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Marca",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataLimite",
                table: "Pagamento",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Vendedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Transportadora",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "TipoDePagamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagamentoId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Marca",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transportadora",
                table: "Transportadora",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDePagamento",
                table: "TipoDePagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotaDeVenda",
                table: "NotaDeVenda",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marca",
                table: "Marca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_NotaDeVendaId",
                table: "Vendedor",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transportadora_NotaDeVendaId",
                table: "Transportadora",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoDePagamento_NotaDeVendaId",
                table: "TipoDePagamento",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDeVenda_PagamentoId",
                table: "NotaDeVenda",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_ProdutoId",
                table: "Marca",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_NotaDeVendaId",
                table: "Cliente",
                column: "NotaDeVendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_NotaDeVenda_NotaDeVendaId",
                table: "Cliente",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Marca_Produto_ProdutoId",
                table: "Marca",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Item_ItemId",
                table: "NotaDeVenda",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Pagamento_PagamentoId",
                table: "NotaDeVenda",
                column: "PagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Item_ItemId",
                table: "Produto",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoDePagamento_NotaDeVenda_NotaDeVendaId",
                table: "TipoDePagamento",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transportadora_NotaDeVenda_NotaDeVendaId",
                table: "Transportadora",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_NotaDeVenda_NotaDeVendaId",
                table: "Vendedor",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
