using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Table("FuncionarioTemp")]
    public partial class FuncionarioTemp
    {
        [Key]
        [Column("ID_Funcionario")]
        public long IdFuncionario { get; set; }
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
        [Column("Sexo_Funcionario")]
        [StringLength(1)]
        [Unicode(false)]
        public string SexoFuncionario { get; set; } = null!;
        [Column("Datanasc_Funcionario", TypeName = "datetime")]
        public DateTime DatanascFuncionario { get; set; }
        [Column("Email_Funcionario")]
        [Unicode(false)]
        public string EmailFuncionario { get; set; } = null!;
        [Column("ID_Pais")]
        public int IdPais { get; set; }
        public bool? Situacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
