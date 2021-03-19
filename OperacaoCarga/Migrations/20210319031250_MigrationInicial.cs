using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OperacaoCarga.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteineres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    NumeroConteiner = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    TipoConteiner = table.Column<int>(type: "int", nullable: false),
                    StatusConteiner = table.Column<int>(type: "int", nullable: false),
                    CategoriaConteiner = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteineres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMovimentacao = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConteinerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movimentacoes_Conteineres_ConteinerID",
                        column: x => x.ConteinerID,
                        principalTable: "Conteineres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacoes_ConteinerID",
                table: "Movimentacoes",
                column: "ConteinerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "Conteineres");
        }
    }
}
