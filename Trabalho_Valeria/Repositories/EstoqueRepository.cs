using Microsoft.CodeAnalysis.Operations;
using Trabalho_Valeria.Context;
using Trabalho_Valeria.Models;
using Trabalho_Valeria.Repositories.Interfaces;

namespace Trabalho_Valeria.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly AppDbContext _context;

        public EstoqueRepository(AppDbContext context)
        {
            _context = context;
        }
        //aqui fica as query
        public IEnumerable<Estoque> Estoques => _context.Estoques;
    }
}
