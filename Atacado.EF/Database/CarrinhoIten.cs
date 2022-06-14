using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Carrinho_Itens")]
    public partial class CarrinhoIten
    {
        [Key]
        [Column("ID_Carrinho_Itens")]
        public int IdCarrinhoItens { get; set; }
        [Column("ID_Carrinho")]
        public int IdCarrinho { get; set; }
        [Column("ID_Produto")]
        public int IdProduto { get; set; }
        [Column("Qtde_Produto")]
        public int QtdeProduto { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [ForeignKey("IdCarrinho")]
        [InverseProperty("CarrinhoItens")]
        public virtual Carrinho IdCarrinhoNavigation { get; set; } = null!;
        [ForeignKey("IdProduto")]
        [InverseProperty("CarrinhoItens")]
        public virtual Produto IdProdutoNavigation { get; set; } = null!;
    }
}
