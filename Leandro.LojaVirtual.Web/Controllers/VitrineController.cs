using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leandro.LojaVitural.Dominio.Repository;

namespace Leandro.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutoRepository _repository;

        int produtoPorPagina = 5;

        // GET: Vitrine
        public ActionResult ListarPaginaProduto(int pagina = 1)
        {
            _repository = new ProdutoRepository();
            var produtos = _repository.Produtos                                
                                .OrderBy(p => p.Descricao)
                                .Skip((pagina - 1) * produtoPorPagina)
                                .Take(produtoPorPagina);

            return View(produtos);
        }
    }
}