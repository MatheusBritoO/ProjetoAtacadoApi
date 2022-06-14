using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("PrimeiroNome")]
    public partial class PrimeiroNome
    {
        [Key]
        [Column("ID_PriNome")]
        public int IdPriNome { get; set; }
        [Column("Nome_PriNome")]
        [StringLength(50)]
        [Unicode(false)]
        public string? NomePriNome { get; set; }
        [Column("Sexo_PriNome")]
        [StringLength(1)]
        [Unicode(false)]
        public string? SexoPriNome { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
