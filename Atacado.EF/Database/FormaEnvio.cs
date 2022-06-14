using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Forma_Envio")]
    public partial class FormaEnvio
    {
        public FormaEnvio()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [Column("ID_Forma_Envio")]
        public int IdFormaEnvio { get; set; }
        [Column("Descricao_Forma_Envio")]
        [Unicode(false)]
        public string DescricaoFormaEnvio { get; set; } = null!;
        [Column("Valor_Por_Quilo_Forma_Envio", TypeName = "decimal(9, 2)")]
        public decimal ValorPorQuiloFormaEnvio { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [InverseProperty("IdFormaEnvioNavigation")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
