using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JDMarketplace.Domain.Entity.Produto
{
    public class Categoria
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<ProdutosCategorias> ProdutosCategorias { get; set; }
    }
}