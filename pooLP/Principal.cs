using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooLP
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            EstoqueProdutos estoque = new EstoqueProdutos();
            estoque.AdicionaProduto(new ProdutoEstoque("monitor", 500, 100));
            estoque.AdicionaProduto(new ProdutoEstoque("telefone", 150, 300));
            estoque.AdicionaProduto(new ProdutoEstoque("teclado", 70, 50));
            estoque.AdicionaProduto(new ProdutoEstoque("mouse", 50, 50));

            CarrinhoCompra carrinho = new CarrinhoCompra(estoque);
            carrinho.AdicionaItem("monitor", 2);
            carrinho.AdicionaItem("telefone", 5);
            carrinho.AdicionaItem("teclado", 2);
        
            carrinho.FinalizaCompra();

            Console.WriteLine("A soma dos produtos : " + carrinho.CalculaTotal());
            Console.ReadKey();
        }
    }
}