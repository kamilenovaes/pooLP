using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe produto que armazena um nome e um valor

namespace pooLP
{
    public class Produto
    {
        private String nome;
        private float valor;

        public Produto(String nomeProduto, float valorProduto)
        {
            this.nome = nomeProduto;
            this.valor = valorProduto;
        }
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public float Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }
    }
}
