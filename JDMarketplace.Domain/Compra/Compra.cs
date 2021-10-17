using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JDMarketplace.Domain.Entity.User;

namespace JDMarketplace.Domain.Compra
{
    public class Compra
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<ItemPedido> ItensDeCompra { get; set; }
    }
}