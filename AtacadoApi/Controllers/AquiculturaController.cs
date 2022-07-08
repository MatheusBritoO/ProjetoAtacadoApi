using Atacado.Envelope.Auxiliar;
using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class AquiculturaController : ControllerBase
    {
        private AquiculturaService servico;

        public AquiculturaController() : base()
        {
            this.servico = new AquiculturaService();
        }


        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<AquiculturaEnvelopeJSON>> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }

        [HttpGet("{id:int}")]
        public ActionResult<AquiculturaEnvelopeJSON> GetByID(int id)
        {
            try
            {
                AquiculturaEnvelopeJSON lista = this.servico.Selecionar(id);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public ActionResult<AquiculturaEnvelopeJSON> Post([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaEnvelopeJSON lista = this.servico.Criar(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }


        [HttpPut]
        public ActionResult<AquiculturaEnvelopeJSON> Put([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaEnvelopeJSON lista = this.servico.Atualizar(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }


        [HttpDelete]
        public ActionResult<AquiculturaEnvelopeJSON> Delete([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaEnvelopeJSON lista = this.servico.Excluir(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult<AquiculturaEnvelopeJSON> Delete(int id)
        {
            try
            {
                AquiculturaEnvelopeJSON lista = this.servico.Excluir(id);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

    }
}
