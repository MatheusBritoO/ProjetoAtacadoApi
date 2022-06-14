using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("Funcionario_Dados_Empresa")]
    public partial class FuncionarioDadosEmpresa
    {
        [Key]
        [Column("ID_FuncDadosEmpresa")]
        public long IdFuncDadosEmpresa { get; set; }
        [Column("Matricula_Funcionario")]
        public long MatriculaFuncionario { get; set; }
        [Column("Nome_Funcionario")]
        [StringLength(50)]
        [Unicode(false)]
        public string NomeFuncionario { get; set; } = null!;
        [Column("Sobrenome_Funcionario")]
        [StringLength(50)]
        [Unicode(false)]
        public string SobrenomeFuncionario { get; set; } = null!;
        [Column("Data_Admissao_Funcionario", TypeName = "datetime")]
        public DateTime DataAdmissaoFuncionario { get; set; }
        [Column("Ctps_Funcionario")]
        [StringLength(50)]
        [Unicode(false)]
        public string CtpsFuncionario { get; set; } = null!;
        [Column("Ctps_Num_Funcionario")]
        public long CtpsNumFuncionario { get; set; }
        [Column("Ctps_Serie_Funcionario")]
        public int CtpsSerieFuncionario { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
