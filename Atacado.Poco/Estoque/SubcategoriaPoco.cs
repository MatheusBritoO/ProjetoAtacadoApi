namespace Atacado.Poco.Estoque
{
    public class SubcategoriaPoco
    {
        public int IdSubcategoria { get; set; }

        public int IdCategoria { get; set; }

        public string DescricaoSubcategoria { get; set; } = null!;

        public bool? Situacao { get; set; }
    }
}
