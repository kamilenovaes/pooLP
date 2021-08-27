using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Letra 'b'

namespace pooLP
{
    public class EstoqueProdutos
    {
        private List<ProdutoEstoque> listadeprodutos;
        
        public EstoqueProdutos()
        {
            listadeprodutos = new List<ProdutoEstoque>();
        }

        public void AdicionaProduto(ProdutoEstoque item)
        {
            listadeprodutos.Add(item);
        }

       // ProdutoEstoque p;

        public ProdutoEstoque PegaProduto(String nome)
        {

            for (int i=0; i < this.listadeprodutos.Count; i++)
            {
                ProdutoEstoque p = this.listadeprodutos[i];
                if ( p.Nome == nome)
                    return p;
            }

            return null;
        }

    }
}
