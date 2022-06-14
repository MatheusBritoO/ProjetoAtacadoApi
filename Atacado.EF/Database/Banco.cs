using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Banco")]
    public partial class Banco
    {
        [Key]
        [Column("ID_Banco")]
        public int IdBanco { get; set; }
        [Column("Cod_Banco")]
        public int? CodBanco { get; set; }
        [Column("Descricao_Banco")]
        [Unicode(false)]
        public string? DescricaoBanco { get; set; }
        [Column("Site_Banco")]
        [Unicode(false)]
        public string? SiteBanco { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
