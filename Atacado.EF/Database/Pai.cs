using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    public partial class Pai
    {
        [Key]
        [Column("ID_Pais")]
        public int IdPais { get; set; }
        [Column("Sigla_Pais")]
        [StringLength(3)]
        [Unicode(false)]
        public string SiglaPais { get; set; } = null!;
        [Column("Cod_Idioma")]
        [StringLength(2)]
        [Unicode(false)]
        public string CodIdioma { get; set; } = null!;
        [Column("Descricao_Pais")]
        [Unicode(false)]
        public string? DescricaoPais { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
