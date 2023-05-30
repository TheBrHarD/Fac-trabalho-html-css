using Trabalho_Valeria.Models;

namespace Trabalho_Valeria.ViewModels
{
    public class ProdutoEstoqueViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public int Estoque { get; set; }
    }
}
