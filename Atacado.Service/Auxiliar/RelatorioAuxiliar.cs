using Atacado.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repository.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Auxiliar
{
    public class RelatorioAuxiliar
    {
        private AtacadoContext contexto;
        private AquiculturaRepository aquiRepo;
        private TipoAquiculturaRepository tipoAquiRepo;
        

        public RelatorioService()
        {
            this.contexto = new AtacadoContext();
            this.aquiRepo = new AquiculturaRepository(this.contexto);
            this.tipoAquiRepo = new TipoAquiculturaRepository(this.contexto);
            
        }

        public List<RelatorioPoco> AquiculturaPorIdmunAno(int idMuns, int ano)
        {
            List<RelatorioPoco> pesquisa =
                 (from aquis in this.contexto.Aquiculturas
                  join taquis in contexto.TipoAquiculturas on aquis.IdTipoAquicultura equals taquis.IdTipoAquicultura
                  join muns in contexto.Municipios on aquis.IdMunicipio equals muns.IdMunicipio
                  where (muns.IdMunicipio == idMuns) && (aquis.Ano == ano) && (aquis.Producao != null)
                  select new RelatorioPoco()
                  {
                    IdAquicultura = aquis.IdAquicultura,                     
                     ValorProducao = aquis.ValorProducao,

                     = aquis.ProporcaoValorProducao,


                  }).ToList();
            return pesquisa;
        }


    }
}
