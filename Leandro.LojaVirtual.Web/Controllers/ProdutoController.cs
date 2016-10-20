using Leandro.LojaVitural.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leandro.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepository _repository;

        public ActionResult Index()
        {
            _repository = new ProdutoRepository();
            var produtos = _repository.Produtos.Take(10);

            return View(produtos);
        }
    }
}