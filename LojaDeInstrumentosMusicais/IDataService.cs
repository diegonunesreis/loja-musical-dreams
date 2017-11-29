using LojaDeInstrumentosMusicais.Models;
using System.Collections.Generic;

namespace LojaDeInstrumentosMusicais
{
    public interface IDataService
    {
        void InicializaDB();
        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();
    }
}