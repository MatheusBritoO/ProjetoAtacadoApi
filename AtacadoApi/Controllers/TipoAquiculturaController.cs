using Atacado.Envelope.Auxiliar;
using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class TipoAquiculturaController : ControllerBase
    {
        private TipoAquiculturaService servico;

        public TipoAquiculturaController() : base()
        {
            this.servico = new TipoAquiculturaService();
        }


        [HttpGet]
        public ActionResult<List<TipoAquiculturaEnvelopeJSON>> GetAll(int skip, int take)
        {
            try
            {
                List<TipoAquiculturaEnvelopeJSON> lista = this.servico.Listar(skip, take);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<TipoAquiculturaEnvelopeJSON>> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }

        [HttpGet("{id:int}")]
        public ActionResult<TipoAquiculturaEnvelopeJSON> GetByID(int id)
        {
            try
            {
                TipoAquiculturaEnvelopeJSON lista = this.servico.Selecionar(id);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public ActionResult<TipoAquiculturaEnvelopeJSON> Post([FromBody] TipoAquiculturaPoco poco)
        {
            try
            {
                TipoAquiculturaEnvelopeJSON lista = this.servico.Criar(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }


        [HttpPut]
        public ActionResult<TipoAquiculturaEnvelopeJSON> Put([FromBody] TipoAquiculturaPoco poco)
        {
            try
            {
                TipoAquiculturaEnvelopeJSON lista = this.servico.Atualizar(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }


        [HttpDelete]
        public ActionResult<TipoAquiculturaEnvelopeJSON> Delete([FromBody] TipoAquiculturaPoco poco)
        {
            try
            {
                TipoAquiculturaEnvelopeJSON lista = this.servico.Excluir(poco);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult<TipoAquiculturaEnvelopeJSON> Delete(int id)
        {
            try
            {
                TipoAquiculturaEnvelopeJSON lista = this.servico.Excluir(id);
                return Ok(lista);

            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

    }
}
