using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("UnidadesFederacao")]
    [Index("SiglaUf", Name = "AK_UF", IsUnique = true)]
    public partial class UnidadesFederacao
    {
        public UnidadesFederacao()
        {
            Distritos = new HashSet<Distrito>();
            Mesoregiaos = new HashSet<Mesoregiao>();
            Microregiaos = new HashSet<Microregiao>();
            Municipios = new HashSet<Municipio>();
            SubDistritos = new HashSet<SubDistrito>();
        }

        [Key]
        [Column("ID_UnidadesFederacao")]
        public int IdUf { get; set; }

        [Column("Descricao_UnidadesFederacao")]
        [Unicode(false)]
        public string DescricaoUf { get; set; } = null!;

        [Column("SiglaUF")]
        [StringLength(2)]
        [Unicode(false)]
        public string SiglaUf { get; set; } = null!;

        [Column("RegiaoBrasil")]
        [StringLength(20)]
        [Unicode(false)]
        public string? RegiaoBrasil { get; set; }
        
        public bool? Situacao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column("DataAlterecao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        public virtual ICollection<Distrito> Distritos { get; set; }
        public virtual ICollection<Mesoregiao> Mesoregiaos { get; set; }
        public virtual ICollection<Microregiao> Microregiaos { get; set; }
        [InverseProperty("IdUfNavigation")]
        public virtual ICollection<Municipio> Municipios { get; set; }
        public virtual ICollection<SubDistrito> SubDistritos { get; set; }
    }
}
