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
    [Table("EMPRESA")]
    public partial class Empresa
    {
        [Key]
        [Column("ID_Empresa")]
        public int IdEmpresa { get; set; }

        [Column("RAZAOSOCIAL")]
        [Unicode(false)]
        public string RazaoSocial { get; set; }

        [Column("NOMEFANTASIA")]
        [Unicode(false)]
        public string NomeFantasia { get; set; }

        [Column("CNPJ")]
        [Unicode(false)]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [Column("INSCRICAOESTADUAL")]
        [Unicode(false)]
        [StringLength(14)]
        public string InscricaoEstadual { get; set; }

        [Column("TELEFONE")]
        [Unicode(false)]
        [StringLength(14)]
        public string Telefone { get; set; }

        [Column("EMAIL")]
        [Unicode(false)]
        public string Email { get; set; }

        [Column("ENDERECO")]
        [Unicode(false)]
        public string Endereco { get; set; }

    }
}
