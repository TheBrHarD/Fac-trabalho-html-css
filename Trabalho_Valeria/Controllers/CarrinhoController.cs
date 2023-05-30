using Microsoft.AspNetCore.Mvc;
using Trabalho_Valeria.Repositories;
using Trabalho_Valeria.Repositories.Interfaces;

namespace Trabalho_Valeria.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly ICarrinhoRepository _carrinhoRepository;

        public CarrinhoController(ICarrinhoRepository carrinhoRepository)
        {
            _carrinhoRepository = carrinhoRepository;
        }

        public IActionResult List()
        {
            var Produtos = _carrinhoRepository.Carrinhos;
            return View(Produtos);
        }
    }
}
