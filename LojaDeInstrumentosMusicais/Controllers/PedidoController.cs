using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LojaDeInstrumentosMusicais.Models;
using LojaDeInstrumentosMusicais.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaDeInstrumentosMusicais.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IDataService _dataService;
        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }
       
        public IActionResult Index()
        {
            List<Produto> produtos = _dataService.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel carrinhoViewModel = getCarrinhoViewModel();
            return View(carrinhoViewModel);
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel carrinhoViewModel = getCarrinhoViewModel();
            return View(carrinhoViewModel);
        }



        private CarrinhoViewModel getCarrinhoViewModel()
        {
            List<Produto> produtos = this._dataService.GetProdutos();

            var itensCarrinho = this._dataService.GetItensPedido();

            CarrinhoViewModel viewModel = new CarrinhoViewModel(itensCarrinho);
            return viewModel;
        }
    }
}
