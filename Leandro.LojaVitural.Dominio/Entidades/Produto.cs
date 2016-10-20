﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leandro.LojaVitural.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Decimal Preco { get; set; }

        public int Categoria { get; set; }

    }
}
