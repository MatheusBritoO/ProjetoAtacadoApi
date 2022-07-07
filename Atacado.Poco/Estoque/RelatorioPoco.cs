namespace Atacado.Poco.Estoque
{
    public class RelatorioPoco
    {
        public int IdCategoria { get; set; }

        public string DescricaoCategoria { get; set; }

        public int IdSubcategoria { get; set; }

        public string DescricaoSubcategoria { get; set; } = null!;

        public int IdProduto { get; set; }

        public string DescricaoProduto { get; set; } = null!;

    }
}
