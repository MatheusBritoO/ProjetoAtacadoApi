using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissaoController : ControllerBase
    {
        private ProfissaoService servico;


        public ProfissaoController(AtacadoContext contexto) : base()
        {
            this.servico = new ProfissaoService(contexto);
        }

        [HttpGet]
        public List<ProfissaoPoco> GetAll()
        {
            return this.servico.Listar();
        }

        [HttpGet("{id:int}")]
        public ProfissaoPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public ProfissaoPoco Post([FromBody] ProfissaoPoco poco)
        {
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public ProfissaoPoco Put([FromBody] ProfissaoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public ProfissaoPoco Delete([FromBody] ProfissaoPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public ProfissaoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
