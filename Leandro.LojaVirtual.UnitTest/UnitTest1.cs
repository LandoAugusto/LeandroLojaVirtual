using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Leandro.LojaVirtual.Web.Models;
using Leandro.LojaVirtual.Web;

namespace Leandro.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestarSeAPaginaEstaSendoGeradaCorreta()
        {
            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal =28  
            };

            //Func<int, string> paginaUrl = i => "Pagina" + i;
            //MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert.AreEqual()
        }
    }
}
