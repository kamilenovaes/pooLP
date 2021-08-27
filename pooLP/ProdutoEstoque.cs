using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Letra 'a' 

namespace pooLP
{
    public class ProdutoEstoque : Produto
    {
        private int quantidade;
        public ProdutoEstoque(String nome, float valor, int qtd): base(nome,valor)
        {
            quantidade = qtd;
        }
        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }
    }
}
