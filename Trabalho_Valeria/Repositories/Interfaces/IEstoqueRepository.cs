using Trabalho_Valeria.Models;

namespace Trabalho_Valeria.Repositories.Interfaces
{
    public interface IEstoqueRepository
    {
        IEnumerable<Estoque> Estoques { get; }
    }
}
