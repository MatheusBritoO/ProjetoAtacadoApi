using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Pedido")]
    public partial class Pedido
    {
        public Pedido()
        {
            Carrinhos = new HashSet<Carrinho>();
        }

        [Key]
        [Column("ID_Pedido")]
        public int IdPedido { get; set; }
        [Column("ID_Cliente")]
        public int IdCliente { get; set; }
        [Column("ID_Forma_Envio")]
        public int IdFormaEnvio { get; set; }
        [Column("ID_Forma_Pagto")]
        public int IdFormaPagto { get; set; }
        [Column("Observacao_Pedido")]
        [Unicode(false)]
        public string? ObservacaoPedido { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("Pedidos")]
        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        [ForeignKey("IdFormaEnvio")]
        [InverseProperty("Pedidos")]
        public virtual FormaEnvio IdFormaEnvioNavigation { get; set; } = null!;
        [ForeignKey("IdFormaPagto")]
        [InverseProperty("Pedidos")]
        public virtual FormaPagto IdFormaPagtoNavigation { get; set; } = null!;
        [InverseProperty("IdPedidoNavigation")]
        public virtual ICollection<Carrinho> Carrinhos { get; set; }
    }
}
