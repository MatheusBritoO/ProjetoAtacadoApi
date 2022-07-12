using Atacado.EF.Database;
using Atacado.Envelope.Auxiliar;
using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{   
    /// <summary>
    /// 
    /// </summary>
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    
    public class AquiculturaController : ControllerBase
    {

        private AquiculturaService servico;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public AquiculturaController(AtacadoContext contexto) : base()
        {
            this.servico = new AquiculturaService(contexto);
        }
        /// <summary>
        /// Busca pela empresa por todos os registros, filtrando onde inicia(skip) e a quantidade(take)
        /// </summary>
        /// <param name="skip">Onde inicia os resultados da pesquisa.</param>
        /// <param name="take"> Quantos registros serão retornados.</param>
        /// <returns>Coleção de dados.</returns>

        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<AquiculturaEnvelopeJSON>> GetAll(int skip, int take)
        {
            try
            {
                List<AquiculturaEnvelopeJSON> lista = this.servico.Listar(skip, take);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }


        }
        /// <summary>
        /// BUsca pelo Codigo(id).
        /// </summary>
        /// <param name="id">Codigo</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public ActionResult<AquiculturaEnvelopeJSON> Get(int id)
        {
            try
            {
                AquiculturaEnvelopeJSON envelope = this.servico.Selecionar(id);
                return Ok(envelope);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }
        /// <summary>
        /// Criar dados.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<AquiculturaEnvelopeJSON> Post([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaEnvelopeJSON envelope = this.servico.Criar(poco);
                return Ok(envelope);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }
        /// <summary>
        /// Atualizar dados.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<AquiculturaEnvelopeJSON> Put([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaEnvelopeJSON envelope = this.servico.Atualizar(poco);
                return Ok(envelope);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }

        }
        /// <summary>
        /// Deletar Relatorio.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<AquiculturaEnvelopeJSON> Delete([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaEnvelopeJSON envelope = this.servico.Excluir(poco); ;
                return Ok(envelope);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }

        }
        /// <summary>
        /// Deletar relatorio pelo codigo(id).
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public ActionResult<AquiculturaEnvelopeJSON> Delete(int id)
        {
            try
            {
                AquiculturaEnvelopeJSON envelope = this.servico.Excluir(id);
                return Ok(envelope);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }

        }
    }
}