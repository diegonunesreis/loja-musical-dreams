using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInstrumentosMusicais.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<itemPedido> Itens { get; private set; }
        public decimal Total {
            get {
                return this.Itens.Sum(i => i.Subtotal); 
            }
        }

        public CarrinhoViewModel(List<itemPedido> itens)
        {
            this.Itens = itens;
        }  
    }
}
