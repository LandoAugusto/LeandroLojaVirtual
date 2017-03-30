using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leandro.LojaVitural.Dominio.Entidades
{
    public class Carrinho
    {

        private readonly List<ItemCarrinho> itensCarrinho = new List<ItemCarrinho>();

        //Adicionar
        public void AdicionarItem(Produto produto, Int32 quantidade)
        {
            var dadosEditado = ItensCarrinho.Where(a => a.Produto.ProdutoId.Equals(produto.ProdutoId) == true).FirstOrDefault();

            if (dadosEditado == null)
            {
                itensCarrinho.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                dadosEditado.Quantidade += quantidade;
            }
        }

        //Remover
        public void RemoverItem(Produto produto)
        {
            itensCarrinho.RemoveAll(a => a.Produto.Equals(produto.ProdutoId));
        }

        //Obter valor total
        public decimal ObterValorTotal()
        {
          return  itensCarrinho.Sum(a => a.Produto.Preco * a.Quantidade);
        }

        // Limpar Carrinho
        public void LimparCarrinho()
        {
            itensCarrinho.Clear();
        }

        //Itens do Carrinho
        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get
            {
                return itensCarrinho;
            }
        }
    }

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
