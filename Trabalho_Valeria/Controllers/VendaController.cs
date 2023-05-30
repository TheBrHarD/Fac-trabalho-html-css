using Microsoft.AspNetCore.Mvc;
using Trabalho_Valeria.Models;
using Trabalho_Valeria.Repositories.Interfaces;

namespace Trabalho_Valeria.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public VendaController(IVendaRepository vendaRepository, CarrinhoCompra carrinhoCompra)
        {
            _vendaRepository = vendaRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Venda venda) 
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0.0m;

            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = items;

            if(_carrinhoCompra.CarrinhoCompraItems.Count == 0) 
            {
                ModelState.AddModelError("","Seu carrinho esta vazio!");
            }

            foreach (var item in items) 
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Produto.Preco * item.Quantidade);
            }

            venda.TotalItensProduto = totalItensPedido;
            venda.ProdutoTotal = precoTotalPedido;

            if (ModelState.IsValid) 
            {
                _vendaRepository.CriarVenda(venda);

                ViewBag.CheckoutCompletoMensagem = "Obrigado por comprar conosco!";
                ViewBag.TotalVenda = _carrinhoCompra.GetCarrinhoCompraTotal();

                _carrinhoCompra.LimparCarrinho();
                return View("~/Views/Venda/CheckoutCompleto.cshtml", venda);
            }
            return View(venda);
        }
    }
}