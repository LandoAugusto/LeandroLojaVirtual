using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leandro.LojaVitural.Dominio.Repository;
using Leandro.LojaVitural.Dominio.Entidades;
using Leandro.LojaVirtual.Web.Models;

namespace Leandro.LojaVirtual.Web.Controllers
{
    public class CarrinhoController : Controller
    {

        private ProdutoRepository _repositorio;

        // GET: Carrinho
        public RedirectToRouteResult Adicionar(Int32 produtoID, string returnUrl)
        {
            _repositorio = new ProdutoRepository();

            Produto produto = _repositorio.Produtos.FirstOrDefault(x => x.ProdutoId == produtoID);

            if (produto != null)
            {
                ObterCarrinho().AdicionarItem(produto, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public Carrinho ObterCarrinho()
        {
            Carrinho carrinho = (Carrinho)Session["Carrinho"];

            if (carrinho == null)
            {
                carrinho = new Carrinho();
                Session["Carrinho"] = carrinho;
            }

            return carrinho;
        }

        public RedirectToRouteResult Remover(int produtoID, string returnUrl)
        {
            _repositorio = new ProdutoRepository(); 

            Produto produto = _repositorio.Produtos.FirstOrDefault(x => x.ProdutoId == produtoID);

            if (produto != null)
            {
                ObterCarrinho().RemoverItem(produto);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CarrinhoViewModel
            {
                Carrinho = ObterCarrinho(),
                ReturnUrl = returnUrl
            });
        }
    }
}