using Contatos_Eletronicos.Models;

namespace Trabalho_Valeria.Repositories.Interfaces
{
    public interface ICarrinhoRepository
    {
        IEnumerable<Carrinho> Carrinhos { get; }
    }
}
