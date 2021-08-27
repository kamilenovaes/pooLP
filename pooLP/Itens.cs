using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLP
{
    public class Itens
    {
        int quantidade;
        ProdutoEstoque produto;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public ProdutoEstoque Produto
        {
            get { return produto;  }
            set { this.produto = value; }
        }

        public Itens(int qtd, ProdutoEstoque p)
        {
            produto = p;
            quantidade = qtd;
        }
    }
}
