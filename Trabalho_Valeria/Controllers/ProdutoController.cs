using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Trabalho_Valeria.Repositories.Interfaces;
using Trabalho_Valeria.ViewModels;

namespace Trabalho_Valeria.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult List()
        {

            var produtoEstoqueViewModel = new ProdutoEstoqueViewModel();
            produtoEstoqueViewModel.Produtos = _produtoRepository.Produtos;
            //var Produtos = _produtoRepository.Produtos;
            var totalProdutos = produtoEstoqueViewModel.Produtos.Count();

            ViewBag.Total = "Total dos Produtos: ";
            ViewBag.TotalProdutos = totalProdutos;
            return View(produtoEstoqueViewModel);
        }

        public IActionResult Details(int produtoId)
        {
            var produto = _produtoRepository.Produtos.FirstOrDefault(l => l.ProdutoId == produtoId);
            return View(produto);
        }

    }
}
