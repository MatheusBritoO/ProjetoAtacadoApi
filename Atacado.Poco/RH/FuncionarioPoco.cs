namespace Atacado.Poco.RH
{
    public class FuncionarioPoco
    {
        public long IdFuncionario { get; set; }

        public long IdFuncionarioDadosEmpresa { get; set; }

        public long Matricula { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataAdmissao { get; set; }

        public string Sexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public int IdPais { get; set; }

        public string CTPS { get; set; }

        public long CTPSNum { get; set; }

        public int CTPSerie { get; set; }

        public bool? Situacao { get; set; }
    }
}
