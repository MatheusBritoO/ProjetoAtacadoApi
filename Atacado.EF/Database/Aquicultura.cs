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
    [Table("Aquicultura")]
    public partial class Aquicultura
    {
        [Key]
        [Column("IdAquicultura")]
        public int IdAquicultura { get; set; }

        [Column("Ano")]
        public int Ano { get; set; }

        [Column("IdMunicipio")]
        public int IdMunicipio { get; set; }

        [Column("IdTipoAquicultura")]
        public int IdTipoAquicultura { get; set; }

        [Column("Producao")]
        public int? Producao { get; set; }

        [Column("ValorProducao")]
        public int? ValorProducao { get; set; }

        [Column("ProporcaoValorProducao")]
        public double? ProporcaoValorProducao { get; set; }

        [Column("Moeda")]
        [Unicode(false)]
        public string Moeda { get; set; }    

    }
}
