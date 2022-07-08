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

        //
        /// <summary>
        /// Aquicultura
        /// </summary>
        public int IdAquicultura { get; set; }

        public int Ano { get; set; }

        public int IdMunicipio { get; set; }

        public int IdTipoAquicultura { get; set; }

        public int Producao { get; set; }

        public int ValorProducao { get; set; }

        public double ProporcaoValorProducao { get; set; }

        public string Moeda { get; set; }

        public bool? Situacao { get; set; }
        ///
    
    
    
    }
}
