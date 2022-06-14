using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Forma_Pagto")]
    public partial class FormaPagto
    {
        public FormaPagto()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [Column("ID_Forma_Pagto")]
        public int IdFormaPagto { get; set; }
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

        [ForeignKey("IdTipoFormaPagto")]
        [InverseProperty("FormaPagtos")]
        public virtual TipoFormaPagto IdTipoFormaPagtoNavigation { get; set; } = null!;
        [InverseProperty("IdFormaPagtoNavigation")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
