using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    public partial class Subcategoria
    {
        public Subcategoria()
        {
            Produtos = new HashSet<Produto>();
        }

        [Key]
        [Column("ID_Subcategoria")]
        public int IdSubcategoria { get; set; }
        
        [Column("ID_Categoria")]
        public int IdCategoria { get; set; }
        
        [Column("Descricao_Subcategoria")]
        [Unicode(false)]
        public string DescricaoSubcategoria { get; set; } = null!;
        
        public bool? Situacao { get; set; }
        
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [ForeignKey("IdCategoria")]
        [InverseProperty("Subcategoria")]
        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
        [InverseProperty("IdSubcategoriaNavigation")]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
