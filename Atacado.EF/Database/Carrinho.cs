using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Carrinho")]
    public partial class Carrinho
    {
        public Carrinho()
        {
            CarrinhoItens = new HashSet<CarrinhoIten>();
        }

        [Key]
        [Column("ID_Carrinho")]
        public int IdCarrinho { get; set; }
        [Column("ID_Pedido")]
        public int IdPedido { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [ForeignKey("IdPedido")]
        [InverseProperty("Carrinhos")]
        public virtual Pedido IdPedidoNavigation { get; set; } = null!;
        [InverseProperty("IdCarrinhoNavigation")]
        public virtual ICollection<CarrinhoIten> CarrinhoItens { get; set; }
    }
}
