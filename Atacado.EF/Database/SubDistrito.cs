using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("SubDistrito")]
    public partial class SubDistrito
    {
        [Key]
        [Column("ID_SubDistrito")]
        public int IdSubDistrito { get; set; }
        [Column("Descricao_SubDistrito")]
        [Unicode(false)]
        public string? DescricaoSubDistrito { get; set; }
        [Column("Sigla_UF")]
        [StringLength(2)]
        [Unicode(false)]
        public string? SiglaUf { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        public virtual UnidadesFederacao? SiglaUfNavigation { get; set; }
    }
}
