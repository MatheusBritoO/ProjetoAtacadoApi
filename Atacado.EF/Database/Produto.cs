using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Produto")]
    public partial class Produto
    {
        public Produto()
        {
            CarrinhoItens = new HashSet<CarrinhoIten>();
        }

        [Key]
        [Column("ID_Produto")]
        public int IdProduto { get; set; }
        [Column("ID_Subcategoria")]
        public int IdSubcategoria { get; set; }
        [Column("ID_Categoria")]
        public int IdCategoria { get; set; }
        [Column("Descricao_Produto")]
        [Unicode(false)]
        public string DescricaoProduto { get; set; } = null!;
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [ForeignKey("IdSubcategoria")]
        [InverseProperty("Produtos")]
        public virtual Subcategoria IdSubcategoriaNavigation { get; set; } = null!;
        [InverseProperty("IdProdutoNavigation")]
        public virtual ICollection<CarrinhoIten> CarrinhoItens { get; set; }
    }
}
