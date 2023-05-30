using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhoValeria.Migrations
{
    /// <inheritdoc />
    public partial class Produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Estoques(Quantidade) VALUES(100)");
            migrationBuilder.Sql("INSERT INTO Produtos(NomeProduto,Preco,DescricaoProduto,ImagemUrl,EstoqueId) VALUES('elgin lâmpada led 9w 6500k',6.99, 'A lâmpada LED economiza até 90% de energia elétrica quando comparada às lâmpadas incandescentes', '~/images/lampada.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Estoques(Quantidade) VALUES(200)");
            migrationBuilder.Sql("INSERT INTO Produtos(NomeProduto,Preco,DescricaoProduto,ImagemUrl,EstoqueId) VALUES('cobrecom cabo flex 2,5mm azul (100 metros)',200.00, 'O cabo flexível é um cabo elétrico formado por vários fios elétricos que dão sua flexibilidade', '~/images/cabo.jpg', 4)");
            migrationBuilder.Sql("INSERT INTO Estoques(Quantidade) VALUES(300)");
            migrationBuilder.Sql("INSERT INTO Produtos(NomeProduto,Preco,DescricaoProduto,ImagemUrl,EstoqueId) VALUES('ResISTOR',0.99, 'O resistor é um componente que limita o fluxo da corrente elétrica em um circuito', '~/images/resistor.jpg', 4)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Estoques");
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
