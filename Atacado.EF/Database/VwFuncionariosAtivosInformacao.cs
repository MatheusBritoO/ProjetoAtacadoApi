using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
    [Keyless]
    public partial class VwFuncionariosAtivosInformacao
    {
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
        [Column("Data_Admissao_Funcionario", TypeName = "datetime")]
        public DateTime DataAdmissaoFuncionario { get; set; }
        [Column("Ctps_Funcionario")]
        [StringLength(50)]
        [Unicode(false)]
        public string CtpsFuncionario { get; set; } = null!;
        [Column("Sexo_Funcionario")]
        [StringLength(1)]
        [Unicode(false)]
        public string SexoFuncionario { get; set; } = null!;
        [Column("Datanasc_Funcionario", TypeName = "datetime")]
        public DateTime DatanascFuncionario { get; set; }
        [Column("Email_Funcionario")]
        [Unicode(false)]
        public string EmailFuncionario { get; set; } = null!;
    }
}
