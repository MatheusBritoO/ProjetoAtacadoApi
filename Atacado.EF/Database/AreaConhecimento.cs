using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Area_Conhecimento")]
    public partial class AreaConhecimento
    {
        [Key]
        [Column("ID_Area")]
        public int IdArea { get; set; }

        [Column("Descricao_Area")]
        [Unicode(false)]
        public string? DescricaoArea { get; set; }

        public bool? Situacao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
