
namespace Atacado.Poco.Auxiliar
{
    public class AquiculturaPoco
    {
        public int IdAquicultura { get; set; }

        public int Ano { get; set; }

        public int IdMunicipio { get; set; }

        public int IdTipoAquicultura { get; set; }

        public int Producao { get; set; }

        public int ValorProducao { get; set; }

        public double ProporcaoValorProducao { get; set; }

        public string Moeda { get; set; }

        public bool? Situacao { get; set; }
    }
}
