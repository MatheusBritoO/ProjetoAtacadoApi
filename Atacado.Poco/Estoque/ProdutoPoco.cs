namespace Atacado.Poco.Estoque
{
    public class ProdutoPoco
    {
        public int IdProduto { get; set; }

        public int IdCategoria { get; set; }

        public int IdSubcategoria { get; set; }

        public string DescricaoProduto { get; set; } = null!;

        public bool? Situacao { get; set; }
    }
}
