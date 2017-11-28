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
        List<Produto> produtos = new List<Produto>
            {
                new Produto (1, "Baixo 4c American Standard 2012 Jazz Bass", 520.00m),
                new Produto (2, "Baixo 4 Cordas Sjb 75 3ts Sx Sunburst 3 Tone Sunburst 3ts", 520.00m),
                new Produto (3, "Baixo 4 Cordas Tbm 4 Sb Tagima Sunburst Sb", 520.00m),
                new Produto (4, "Baixo 5 Cordas Tbm 5 Bk Tagima", 520.00m),
                new Produto (5, "Baixo Epiphone Viola Bass Vs Epiphone Sunburst Vintage Sunburst Vs", 520.00m),
                new Produto (6, "Contrabaixo B5 Open Pore Natural Cort", 520.00m),
                new Produto (7, "Guitarra Corsair Com Ponte Bigsby Schecter Preto Gloss Black Blk", 559.00m),
                new Produto (8, "Guitarra Semi Acustica Es335 Dot Studio Ltd Ed Epiphone Vinho Cherry Ch", 559.00m),
                new Produto (9, "Guitarra Solo Ii Custom Schecter Preto Aged Black Satin Abs", 559.00m),
                new Produto (10, "Guitarra Strato Sst62 Vintage Plus Sx Branco Vintage White Vwh", 559.00m),
                new Produto (11, "Guitarra Woodstock Tw 55 Sb Tagima Sunburst Sb", 559.00m),
                new Produto (12, "Guitarra Woodstock Tw61 Wv Branco Vintage Tagima Branco Vintage White Vwh", 559.00m),
                new Produto (13, "Violao Cd 60 Ce Folk Dreadnought Mahogany Com Case Fender", 499.00m),
                new Produto (14, "Violao Classico Nylon Cutaway Ch800 Eagle Nt Eagle Natural Nt", 499.00m),
                new Produto (15, "Violao Classico Nylon Eletrico Vegas T Serie America Tagima Natural Na", 499.00m),
                new Produto (16, "Violao Dreadnought Aco Ch888 12 Cordas Folk Nt Natural Eagle Natural Nt", 499.00m),
                new Produto (17, "Violao Dreadought Aco Gd11 Mce Eletrico Folk Takamine Mogno Nmh", 499.00m)
            };
        
        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            List<itemPedido> itensCarrinho = new List<itemPedido>
            {
                new itemPedido(1, produtos[0], 3),
                new itemPedido(1, produtos[4], 1),
                new itemPedido(1, produtos[2], 7)
            };

            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itensCarrinho);
            return View(carrinhoViewModel);
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}
