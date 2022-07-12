using Atacado.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Service.Estoque;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService servico;

        public ProdutoController(AtacadoContext contexto) : base()
        {
            this.servico = new ProdutoService(contexto);
        }

        [HttpGet("{skip:int}/{take:int}")]
        public List<ProdutoPoco> GetAll(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }

        [HttpGet("{id:int}")]
        public ProdutoPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public ProdutoPoco Post([FromBody] ProdutoPoco poco)
        {
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public ProdutoPoco Put([FromBody] ProdutoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public ProdutoPoco Delete([FromBody] ProdutoPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public ProdutoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }

    }
}
