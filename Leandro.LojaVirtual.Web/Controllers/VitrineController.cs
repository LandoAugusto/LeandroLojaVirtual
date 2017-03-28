using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leandro.LojaVitural.Dominio.Repository;
using Leandro.LojaVirtual.Web.Models;

namespace Leandro.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutoRepository _repository;

        int produtoPorPagina = 5;


        // GET: Vitrine
        public ActionResult ListarPaginaProduto(string categoria,int pagina = 1)
        {
                _repository = new ProdutoRepository();
            ProdutosViewModel model = new ProdutosViewModel()
            {
                
                Produtos = _repository.Produtos
                                .Where(c => categoria == null || c.Categoria == categoria)
                                .OrderBy(p => p.Descricao)
                                .Skip((pagina - 1) * produtoPorPagina)
                                .Take(produtoPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = produtoPorPagina,
                    ItensTotal = _repository.Produtos.Where(c => categoria == null || c.Categoria == categoria).Count()
                },

                CategoriaAtual = categoria
            };

            return View(model);
        }
    }
}