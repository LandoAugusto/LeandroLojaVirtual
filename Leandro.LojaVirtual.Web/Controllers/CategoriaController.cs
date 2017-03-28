using Leandro.LojaVitural.Dominio.Entidades;
using Leandro.LojaVitural.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leandro.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutoRepository _repositorio;
        // GET: Categoria
        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            _repositorio = new ProdutoRepository();

            IEnumerable<string> categorias = _repositorio.Produtos.
                    Select(c => c.Categoria)
                    .Distinct()
                    .OrderBy(c => c);


            return PartialView(categorias);
        }
    }
}