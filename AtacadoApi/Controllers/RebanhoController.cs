using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// Recurso Rebanho.
    /// </summary>
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class RebanhoController : ControllerBase
    {
        private RebanhoService servico;
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public RebanhoController() : base()
        {
            this.servico = new RebanhoService();
        }
        /// <summary>
        /// Reazlida a busca por todos os registros filtrando onde inicia(skip) e a quantidade(take).
        /// </summary>
        /// <param name="skip">Onde inicia os resultados da pesquisa.</param>
        /// <param name="take">Quantos registros serão retornados.</param>
        /// <returns>Coleção de dados.</returns>
        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<RebanhoPoco>> Get(int skip, int take)
        {
            try
            {
                List<RebanhoPoco> listaResposta = this.servico.Listar(skip, take);
                return Ok(listaResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Adiciona um novo Objeto.
        /// </summary>
        /// <param name="poco">O Objeto criado.</param>
        /// <returns>O Objeto salvo no banco de dados.</returns>
        [HttpPost]
        public ActionResult<RebanhoPoco> Post([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco pocoResposta = this.servico.Criar(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Alterar ou Atualizar um Objeto.
        /// </summary>
        /// <param name="poco">Objeto que será alterado ou atualizado.</param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<RebanhoPoco> Put([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco pocoResposta = this.servico.Atualizar(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// Deleta um objeto da tabela.
        /// </summary>
        /// <param name="poco">Dado a ser deletado.</param>
        /// <returns>Objeto será totalmente deletado do banco de dados.</returns>
        [HttpDelete]
        public ActionResult<RebanhoPoco> Delete([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco pocoResposta = this.servico.Excluir(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// Objeto será deletado pelo seu ID.
        /// </summary>
        /// <param name="id">ID do Objeto que será deletado.</param>
        /// <returns>Objeto deletado do banco de dados.</returns>
        [HttpDelete("{id:int}")]
        public ActionResult<RebanhoPoco> Delete(int id)
        {
            try
            {
                RebanhoPoco pocoResposta = this.servico.Excluir(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Busca de Objeto pelo seu ID.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Objeto pesquisado pelo ID.</returns>
        [HttpGet("{id:int}")]
        public ActionResult<RebanhoPoco> GetByID(int id)
        {
            try
            {
                RebanhoPoco pocoResposta = this.servico.Selecionar(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
            /// <summary>
            /// Busca de Objeto Por Ano Referencia e ID de Municipio.
            /// </summary>
            /// <param name="anoRef">Ano Referencia a ser pesquisado</param>
            /// <param name="idMun">ID municipio a ser pesquisado</param>
            /// <returns>Coleção de dados.</returns>
            [HttpGet("anoref/{anoRef:int}/idmun/{idMun:int}")]
        public ActionResult<List<RebanhoPoco>> GetPorAnoRefIdMun(int anoRef, int idMun)
        {
            try
            {
                List<RebanhoPoco> lista = this.servico.FiltrarPorAnoRefIdMun(anoRef, idMun);
                return Ok(lista);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
