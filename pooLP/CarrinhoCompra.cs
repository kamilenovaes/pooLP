using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Letra 'c'

namespace pooLP
{
    public class CarrinhoCompra
    {
        private List<Itens> produto;
        private EstoqueProdutos estoque;
        private int valorqtd;

        public CarrinhoCompra(EstoqueProdutos estq)
        {
            produto = new List<Itens>();
            estoque = estq;
        }

        public void AdicionaItem(String nome, int qtd)
        {
            ProdutoEstoque p = estoque.PegaProduto(nome);
            if(p.Quantidade >= qtd)
            {
                produto.Add(new Itens(qtd, p));
            }
            valorqtd = p.Quantidade;
        }
 
        public void FinalizaCompra()
        {
            for (int i = 0; i < this.produto.Count; i++)
            {
                Itens item = this.produto[i];
                valorqtd = valorqtd - item.Quantidade;
            }
        }

        public float CalculaTotal()
        {
            float somatotal = 0;
            for (int i=0; i < this.produto.Count; i++)
            {
                Itens item = this.produto[i];
                somatotal = somatotal + (item.Produto.Valor * item.Quantidade);
            }
            return somatotal;
        }

    }
}
