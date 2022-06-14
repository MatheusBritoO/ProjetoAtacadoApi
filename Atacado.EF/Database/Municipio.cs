using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Municipio")]
    public partial class Municipio
    {
        [Key]
        [Column("ID_Municipio")]
        public int IdMunicipio { get; set; }
        [Column("Nome_Municipio")]
        [Unicode(false)]
        public string NomeMunicipio { get; set; } = null!;
        [Column("ID_UF")]
        public int IdUf { get; set; }
        [Column("Sigla_UF")]
        [StringLength(2)]
        [Unicode(false)]
        public string SiglaUf { get; set; } = null!;
        [Column("ID_Mesoregiao")]
        public int IdMesoregiao { get; set; }
        [Column("ID_Microregiao")]
        public int IdMicroregiao { get; set; }
        [Column("Codigo_IBGE_6")]
        public int CodigoIbge6 { get; set; }
        [Column("Codigo_IBGE_7")]
        public int CodigoIbge7 { get; set; }
        [Column("Populacao_Municipio")]
        public long? PopulacaoMunicipio { get; set; }
        [Column("Porte_Municipio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PorteMunicipio { get; set; }
        [Column("CEP_Municipio")]
        public long? CepMunicipio { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [ForeignKey("IdUf")]
        [InverseProperty("Municipios")]
        public virtual UnidadesFederacao IdUfNavigation { get; set; } = null!;
    }
}
