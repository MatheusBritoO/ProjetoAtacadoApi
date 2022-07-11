using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class RelatorioAquiculturaController : ControllerBase
    {
        private RelatorioAquiculturaService servico;

        public RelatorioAquiculturaController() : base()
        {
            this.servico = new RelatorioAquiculturaService();
        }

        /// <summary>
        /// Busca um relatorio de Aquicultura por todos os registros, filtrando por ID municipio e por ano.
        /// </summary>
        /// <param name="IdMun">Identificacao do Municipio</param>
        /// <param name="Ano">Ano de busca</param>
        /// <returns></returns>
        [HttpGet("ConsultaPor/IdMunicipio/{IdMun:int}/Ano/{Ano:int}")]
        public ActionResult<List<RelatorioAquiculturaPoco>> GetRelatorioPorMunicipioIDeAno(int IdMun, int Ano)
        {
            try
            {
                List<RelatorioAquiculturaPoco> resposta = this.servico.AquiculturaPorIDeAno(IdMun, Ano);
                return Ok(resposta);

            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Busca um relatorio de Aquicultura por todos os registros, filtrando Tipo Aquicultura, ano e Id Municipio.
        /// </summary>
        /// <param name="TipoA">Tipo de Aquicultura</param>
        /// <param name="Ano">Ano de busca</param>
        /// <param name="IdMun">Identificacao do Municipio</param>
        /// <returns></returns>

        [HttpGet("ConsultaPor/IdTipoAquicultura/{TipoA:int}/Ano/{Ano:int}/IdMunicipio/{IdMun:int}")]
        public ActionResult<List<RelatorioAquiculturaPoco>> GetRelatorioPorAquiculturaIDeAno(int TipoA, int Ano, int IdMun)
        {
            try
            {
                List<RelatorioAquiculturaPoco> resposta = this.servico.AquiculturaPorTipoeAno(TipoA, Ano, IdMun);
                return Ok(resposta);

            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }



    }
}