namespace Atacado.Dal.Auxiliar
{
    public class ProfissaoPoco
    {
        public int IdProfissao { get; set; }

        public string DescricaoProfissao { get; set; } = null!;

        public bool? Situacao { get; set; }
    }
}
