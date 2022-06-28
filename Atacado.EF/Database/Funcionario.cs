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

    [Table("Funcionario")]
    public partial class Funcionario
    {
        [Key]
        [Column("ID_Funcionario")]
        public long IdFuncionario{ get; set; }
        
        [Column("ID_FuncDadosEmpresa")]
        public long IdFuncionarioDadosEmpresa { get; set; }

        [Column("Matricula_Funcionario")]
        public long Matricula { get; set; }

        [Column("Nome_funcionario")]
        [Unicode(false)]
        [StringLength(50)]
        public string Nome { get; set; }

        [Column("Sobrenome_Funcionario")]
        [Unicode(false)]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Column("Data_Admissao_Funcionario", TypeName = "datetime")]
        [Unicode(false)]
        public DateTime DataAdmissao { get; set; }

        [Column("Sexo_Funcionario")]
        [Unicode(false)]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Column("Datanasc_Funcionario", TypeName = "datetime")]       
        public DateTime DataNascimento { get; set; }

        [Column("Email_Funcionario")]
        [StringLength(75)]
        public string Email { get; set; }

        [Column("ID_Pais")]
        public int IdPais { get; set; }

        [Column("Ctps_Funcionario")]
        [Unicode(false)]
        [StringLength(50)]
        public string CTPS { get; set; }

        [Column("Ctps_Num_Funcionario")]
        public long CTPSNum { get; set; }

        [Column("Ctps_Serie_Funcionario")]
        public int CTPSerie { get; set; }

        public bool? Situacao { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]

        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]

        public DateTime? DataExclusao { get; set; }

    }
}
