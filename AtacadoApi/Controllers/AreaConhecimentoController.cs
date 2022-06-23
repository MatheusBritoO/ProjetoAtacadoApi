using Atacado.Dal.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaConhecimentoController : ControllerBase
    {
        private AreaConhecimentoService servico;


        public AreaConhecimentoController() : base()
        {
            this.servico = new AreaConhecimentoService();
        }

        [HttpGet]
        public List<AreaConhecimentoPoco> GetAll()
        {
            return this.servico.Listar();
        }

        [HttpGet("{id:int}")]
        public AreaConhecimentoPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public AreaConhecimentoPoco Post([FromBody] AreaConhecimentoPoco poco)
        {
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public AreaConhecimentoPoco Put([FromBody] AreaConhecimentoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public AreaConhecimentoPoco Delete([FromBody] AreaConhecimentoPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public AreaConhecimentoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
