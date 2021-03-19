using Microsoft.EntityFrameworkCore.Migrations;

namespace OperacaoCarga.Migrations
{
    public partial class PopularConteiner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Conteineres(Cliente,NumeroConteiner,TipoConteiner,StatusConteiner,CategoriaConteiner) VALUES('Santos Brasil','CAJU1234321',20,1,1)");
            migrationBuilder.Sql("INSERT INTO Conteineres(Cliente,NumeroConteiner,TipoConteiner,StatusConteiner,CategoriaConteiner) VALUES('Dínamo','CAJU4321123',40,2,2)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Conteineres");
            migrationBuilder.Sql("DELETE FROM Movimentacoes");
        }
    }
}
