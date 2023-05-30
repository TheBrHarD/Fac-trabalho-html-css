using Microsoft.CodeAnalysis.Operations;
using Trabalho_Valeria.Context;
using Trabalho_Valeria.Models;
using Trabalho_Valeria.Repositories.Interfaces;

namespace Trabalho_Valeria.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public VendaRepository(AppDbContext appDbContext,
            CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarVenda(Venda venda)
        {
            venda.ProdutoEnviado = DateTime.Now;
            _appDbContext.Vendas.Add(venda);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var vendaDetail = new VendaDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    ProdutoId = carrinhoItem.Produto.ProdutoId,
                    VendaId = venda.VendaId,
                    Preco = (decimal)carrinhoItem.Produto.Preco
                };
                _appDbContext.VendasDetalhe.Add(vendaDetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}

