using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    public partial class Categoria
    {
        public Categoria()
        {
            Subcategoria = new HashSet<Subcategoria>();
        }

        [Key]
        [Column("ID_Categoria")]
        public int IdCategoria { get; set; }
        [Column("Descricao_Categoria")]
        [Unicode(false)]
        public string DescricaoCategoria { get; set; } = null!;
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [InverseProperty("IdCategoriaNavigation")]
        public virtual ICollection<Subcategoria> Subcategoria { get; set; }
    }
}
