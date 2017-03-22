using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leandro.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public Int32 ItensTotal { get; set; }
        public Int32 ItensPorPagina { get; set; }
        public Int32 PaginaAtual { get; set; }
        public Int32 TotalPaginas
        {
            get
            {
                return (Int32)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);                    ;

            }
        }
    }
}