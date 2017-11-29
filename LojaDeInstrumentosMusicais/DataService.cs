using LojaDeInstrumentosMusicais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInstrumentosMusicais
{
    public class DataService : IDataService
    {
        private readonly Contexto _contexto;


        public DataService(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public List<ItemPedido> GetItensPedido()
        {
            return this._contexto.ItensPedido.ToList();
        }

        public List<Produto> GetProdutos()
        {
            return this._contexto.Produtos.ToList();
        }

        public void InicializaDB()
        {
            this._contexto.Database.EnsureCreated();
            if (this._contexto.Produtos.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
                {
                    new Produto ("Baixo 4c American Standard 2012 Jazz Bass", 520.00m),
                    new Produto ("Baixo 4 Cordas Sjb 75 3ts Sx Sunburst 3 Tone Sunburst 3ts", 520.00m),
                    new Produto ("Baixo 4 Cordas Tbm 4 Sb Tagima Sunburst Sb", 520.00m),
                    new Produto ("Baixo 5 Cordas Tbm 5 Bk Tagima", 520.00m),
                    new Produto ("Baixo Epiphone Viola Bass Vs Epiphone Sunburst Vintage Sunburst Vs", 520.00m),
                    new Produto ("Contrabaixo B5 Open Pore Natural Cort", 520.00m),
                    new Produto ("Guitarra Corsair Com Ponte Bigsby Schecter Preto Gloss Black Blk", 559.00m),
                    new Produto ("Guitarra Semi Acustica Es335 Dot Studio Ltd Ed Epiphone Vinho Cherry Ch", 559.00m),
                    new Produto ("Guitarra Solo Ii Custom Schecter Preto Aged Black Satin Abs", 559.00m),
                    new Produto ("Guitarra Strato Sst62 Vintage Plus Sx Branco Vintage White Vwh", 559.00m),
                    new Produto ("Guitarra Woodstock Tw 55 Sb Tagima Sunburst Sb", 559.00m),
                    new Produto ("Guitarra Woodstock Tw61 Wv Branco Vintage Tagima Branco Vintage White Vwh", 559.00m),
                    new Produto ("Violao Cd 60 Ce Folk Dreadnought Mahogany Com Case Fender", 499.00m),
                    new Produto ("Violao Classico Nylon Cutaway Ch800 Eagle Nt Eagle Natural Nt", 499.00m),
                    new Produto ("Violao Classico Nylon Eletrico Vegas T Serie America Tagima Natural Na", 499.00m),
                    new Produto ("Violao Dreadnought Aco Ch888 12 Cordas Folk Nt Natural Eagle Natural Nt", 499.00m),
                    new Produto ("Violao Dreadought Aco Gd11 Mce Eletrico Folk Takamine Mogno Nmh", 499.00m)
                };

                foreach (var produto in produtos)
                {
                    this._contexto.Produtos
                        .Add(produto);

                    this._contexto.ItensPedido
                        .Add(new ItemPedido(produto, 1));
                }
                this._contexto.SaveChanges();
            }
        }
    }
}
