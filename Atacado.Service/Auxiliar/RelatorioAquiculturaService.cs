
using Atacado.EF.Database;
using Atacado.Poco.Auxiliar;

namespace Atacado.Service.Auxiliar
{
    public class RelatorioAquiculturaService
    {
        private AtacadoContext contexto;

        public RelatorioAquiculturaService()
        {
            this.contexto = new AtacadoContext();
        }

        public RelatorioAquiculturaService(AtacadoContext contexto)
        {
            this.contexto = contexto;
        }

        public List<RelatorioAquiculturaPoco> AquiculturaPorIDeAno(int IdMun, int AnoRef)
        {
            List<RelatorioAquiculturaPoco> pesquisa =
                 (from aquis in this.contexto.Aquiculturas
                  join tipos in this.contexto.TipoAquiculturas on aquis.IdTipoAquicultura equals tipos.IdTipoAquicultura
                  join muns in this.contexto.Municipios on aquis.IdMunicipio equals muns.CodigoIbge7
                  join ufs in this.contexto.UnidadesFederacaos on muns.SiglaUf equals ufs.SiglaUf
                  where (aquis.IdMunicipio == IdMun)
                  && (aquis.Ano == AnoRef)
                  && (aquis.Producao.HasValue == true)
                  select new RelatorioAquiculturaPoco()
                  {
                      IdAquicultura = aquis.IdAquicultura,
                      Ano = aquis.Ano,
                      IdMunicipio = aquis.IdMunicipio,
                      NomeMunicipio = muns.NomeMunicipio,
                      SiglaUF = ufs.SiglaUf,
                      DescricaoUF = ufs.DescricaoUf,
                      IdTipoAquicultura = aquis.IdTipoAquicultura,
                      DescricaoTipoAquicultura = tipos.DescricaoTipoAquicultura,
                      Producao = aquis.Producao,
                      ValorProducao = aquis.ValorProducao,
                      ProporcaoValorProducao = aquis.ProporcaoValorProducao,
                      Moeda = aquis.Moeda
                  }).ToList();
            return pesquisa;

        }

        public List<RelatorioAquiculturaPoco> AquiculturaPorTipoeAno(int TipoA, int AnoRef, int IdMun)
        {
            List<RelatorioAquiculturaPoco> pesquisa =
                (from aquis in this.contexto.Aquiculturas
                 join tipos in this.contexto.TipoAquiculturas on aquis.IdTipoAquicultura equals tipos.IdTipoAquicultura
                 join muns in this.contexto.Municipios on aquis.IdMunicipio equals muns.CodigoIbge7
                 join ufs in this.contexto.UnidadesFederacaos on muns.SiglaUf equals ufs.SiglaUf
                 where
                    (aquis.IdTipoAquicultura == TipoA) &&
                    (aquis.Ano == AnoRef) &&
                    (aquis.IdMunicipio == IdMun)
                 select new RelatorioAquiculturaPoco()
                 {
                     IdAquicultura = aquis.IdAquicultura,
                     Ano = aquis.Ano,
                     IdMunicipio = aquis.IdMunicipio,
                     NomeMunicipio = muns.NomeMunicipio,
                     SiglaUF = ufs.SiglaUf,
                     DescricaoUF = ufs.DescricaoUf,
                     IdTipoAquicultura = aquis.IdTipoAquicultura,
                     DescricaoTipoAquicultura = tipos.DescricaoTipoAquicultura,
                     Producao = aquis.Producao,
                     ValorProducao = aquis.ValorProducao,
                     ProporcaoValorProducao = aquis.ProporcaoValorProducao,
                     Moeda = aquis.Moeda
                 }).ToList();
            return pesquisa;

        }
    }
}