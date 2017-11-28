using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeInstrumentosMusicais.Models
{
    public class itemPedido
    {
        public int Id { get; private set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public decimal Subtotal {
            get {
                return this.Quantidade * this.PrecoUnitario;
            }
        }

        public itemPedido(int id, Produto produto, int quantidade)
        {
            this.Id = id;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = produto.Preco;
        }

    }
}
