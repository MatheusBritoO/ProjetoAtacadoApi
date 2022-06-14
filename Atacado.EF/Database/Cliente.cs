using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [Column("ID_Cliente")]
        public int IdCliente { get; set; }
        [Column("Nome_Cliente")]
        [Unicode(false)]
        public string NomeCliente { get; set; } = null!;
        [Column("Endereco_Cliente")]
        [StringLength(255)]
        [Unicode(false)]
        public string EnderecoCliente { get; set; } = null!;
        [Column("Cpf_Cliente")]
        [StringLength(14)]
        [Unicode(false)]
        public string CpfCliente { get; set; } = null!;
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
