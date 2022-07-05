using Atacado.Envelope.RH;
using Atacado.Poco.RH;
using Atacado.Service.RH;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/rh/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private EmpresaService servico;

        public EmpresaController() : base()
        {
            this.servico = new EmpresaService();
        }

        /// <summary>
        /// Realiza a busca por todos os registros filtrando onde inicia(skip) e a quantidade(take).
        /// </summary>
        /// <param name="skip">Onde inicia os resultados da pesquisa.</param>
        /// <param name="take">Quantos registros serão retornados.</param>
        /// <returns>Coleção de dados.</returns>
        [HttpGet]
        public ActionResult<List<EmpresaEnvelopeJSON>> GetAll(int skip, int take)
        {
            try
            {
               List<EmpresaEnvelopeJSON> lista = this.servico.Listar(skip, take);
                return Ok(lista);
               
            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Realiza a busca por todos os registros filtrando onde inicia(skip) e a quantidade(take).
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<EmpresaEnvelopeJSON>> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }


        /// <summary>
        /// Realiza a busca por ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public ActionResult<EmpresaEnvelopeJSON> GetByID(int id)
        {
            try
            {
                EmpresaEnvelopeJSON lista = this.servico.Selecionar(id);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Realiza a Atualização ou alteração de registro.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<EmpresaEnvelopeJSON> Post([FromBody] EmpresaPoco poco)
        {
            try
            {
                EmpresaEnvelopeJSON lista = this.servico.Criar(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<EmpresaEnvelopeJSON> Put([FromBody] EmpresaPoco poco)
        {
            try
            {
                EmpresaEnvelopeJSON lista = this.servico.Atualizar(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<EmpresaEnvelopeJSON> Delete([FromBody] EmpresaPoco poco)
        {
            try
            {
                EmpresaEnvelopeJSON lista = this.servico.Excluir(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public ActionResult<EmpresaEnvelopeJSON> Delete(int id)
        {
            try
            {
                EmpresaEnvelopeJSON lista = this.servico.Excluir(id);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

    }
}
