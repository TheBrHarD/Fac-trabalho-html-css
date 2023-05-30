using Trabalho_Valeria.Models;

namespace Trabalho_Valeria.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto>  Produtos { get; }
    }
}
