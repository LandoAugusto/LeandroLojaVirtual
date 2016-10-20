using Leandro.LojaVitural.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leandro.LojaVitural.Dominio.Repository
{
    public class ProdutoRepository
    {
        private readonly EfDbContext _context = new EfDbContext();


        public IEnumerable<Produto> Produtos
        {

            get
            {
                return _context.Produto;

            }
        }
    }
}
