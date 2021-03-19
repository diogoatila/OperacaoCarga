using Microsoft.EntityFrameworkCore.Migrations;

namespace OperacaoCarga.Migrations
{
    public partial class PopularMovimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Movimentacoes(TipoMovimentacao,DataInicio,DataFim,ConteinerID) VALUES(1,'2021-03-18','2021-03-19',1)");
            migrationBuilder.Sql("INSERT INTO Movimentacoes(TipoMovimentacao,DataInicio,DataFim,ConteinerID) VALUES(2,'2021-03-18','2021-03-19',2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Movimentacoes");
        }
    }
}
