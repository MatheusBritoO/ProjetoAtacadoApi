using Atacado.Poco.RH;
using Atacado.Service.RH;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/rh/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private FuncionarioService servico;
        /// <summary>
        /// 
        /// </summary>
        public FuncionarioController() : base()
        {
            this.servico = new FuncionarioService();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<FuncionarioPoco>> Get(int skip, int take)
        {
            try
            {
                List<FuncionarioPoco> listaResposta = this.servico.Listar(skip, take);
                return Ok(listaResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public ActionResult<FuncionarioPoco> GetByID(int id)
        {
            try
            {
                FuncionarioPoco pocoResposta = this.servico.SelecionarPorMatricula(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        [HttpGet("matricula/{mat:long}")]
        public ActionResult<FuncionarioPoco> GetPorMatricula(long mat)
        {
            try
            {
                FuncionarioPoco pocoResposta = this.servico.SelecionarPorMatricula(mat);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<FuncionarioPoco> Post([FromBody] FuncionarioPoco poco)
        {
            try
            {
                FuncionarioPoco pocoResposta = this.servico.Criar(poco);
                if (pocoResposta == null)
                {
                    return BadRequest(this.servico.MensagensProcessamentos);
                }
                else
                {
                    return Ok(pocoResposta);
                }
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<FuncionarioPoco> Put([FromBody] FuncionarioPoco poco)
        {
            try
            {
                FuncionarioPoco pocoResposta = this.servico.Atualizar(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<FuncionarioPoco> Delete([FromBody] FuncionarioPoco poco)
        {
            try
            {
                FuncionarioPoco pocoResposta = this.servico.Excluir(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public ActionResult<FuncionarioPoco> Delete(int id)
        {
            try
            {
                FuncionarioPoco pocoResposta = this.servico.Excluir(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}
