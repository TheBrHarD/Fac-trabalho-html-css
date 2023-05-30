using Microsoft.AspNetCore.Mvc;
using Trabalho_Valeria.Repositories.Interfaces;

namespace Trabalho_Valeria.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly IEstoqueRepository _estoqueRepository;

        public EstoqueController(IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public IActionResult List()
        {
            var Produtos = _estoqueRepository.Estoques;
            return View(Produtos);
        }
    }
}
