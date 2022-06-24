using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoRebanhoController : ControllerBase
    {
        private TipoRebanhoService servico;


        public TipoRebanhoController() : base()
        {
            this.servico = new TipoRebanhoService();
        }

        [HttpGet]
        public List<TipoRebanhoPoco> GetAll()
        {
            return this.servico.Listar();
        }

        [HttpGet("{id:int}")]
        public TipoRebanhoPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public TipoRebanhoPoco Post([FromBody] TipoRebanhoPoco poco)
        {
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public TipoRebanhoPoco Put([FromBody] TipoRebanhoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public TipoRebanhoPoco Delete([FromBody] TipoRebanhoPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public TipoRebanhoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
