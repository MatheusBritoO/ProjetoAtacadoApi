using Atacado.Dal.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdiomaController : ControllerBase
    {
        private IdiomaService servico;


        public IdiomaController() : base()
        {
            this.servico = new IdiomaService();
        }

        [HttpGet]
        public List<IdiomaPoco> GetAll()
        {
            return this.servico.Listar();
        }

        [HttpGet("{id:int}")]
        public IdiomaPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public IdiomaPoco Post([FromBody] IdiomaPoco poco)
        {
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public IdiomaPoco Put([FromBody] IdiomaPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public IdiomaPoco Delete([FromBody] IdiomaPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public IdiomaPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
