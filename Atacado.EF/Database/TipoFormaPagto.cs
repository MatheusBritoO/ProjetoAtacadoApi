using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Tipo_Forma_Pagto")]
    public partial class TipoFormaPagto
    {
        public TipoFormaPagto()
        {
            FormaPagtos = new HashSet<FormaPagto>();
        }

        [Key]
        [Column("ID_Tipo_Forma_Pagto")]
        public int IdTipoFormaPagto { get; set; }
        [Column("Descricao_Forma_Pagto")]
        [Unicode(false)]
        public string DescricaoFormaPagto { get; set; } = null!;
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [InverseProperty("IdTipoFormaPagtoNavigation")]
        public virtual ICollection<FormaPagto> FormaPagtos { get; set; }
    }
}
