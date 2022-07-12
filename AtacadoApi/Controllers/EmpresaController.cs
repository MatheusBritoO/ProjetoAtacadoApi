using Atacado.EF.Database;
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

        public EmpresaController(AtacadoContext contexto) : base()
        {
            this.servico = new EmpresaService(contexto);
        }

   
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

  
        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<EmpresaEnvelopeJSON>> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }

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
