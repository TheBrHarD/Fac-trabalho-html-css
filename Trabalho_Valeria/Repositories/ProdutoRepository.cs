using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using Trabalho_Valeria.Context;
using Trabalho_Valeria.Models;
using Trabalho_Valeria.Repositories.Interfaces;

namespace Trabalho_Valeria.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }
        //aqui fica as query
        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Estoque);
    }
}
