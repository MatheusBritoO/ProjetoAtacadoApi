using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.EF.Database
{
    [Table("Rebanho")]
    public partial class Rebanho
    {
        [Key]
        [Column("ID_Rebanho")]
        public int IdRebanho { get; set; }

        [Column("Ano_Ref")]       
        public int AnoRef { get; set; }

        [Column("ID_Municipio")]
        public int IdMunicipio { get; set; }

        [Column("ID_Tipo_Rebanho")]
       public int IdTipoRebanho { get; set; }

        [Column("Tipo_Rebanho")]
        [Unicode(false)]
        public string TipoRebanho { get; set; }

        [Column("Quantidade")]
        public int? Quantidade { get; set; }

       
        public bool? Situacao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]

        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]

        public DateTime? DataExclusao { get; set; }
    }
}
