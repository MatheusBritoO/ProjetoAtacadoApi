using Atacado.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Service.Estoque;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private CategoriaService servico;


        public CategoriaController(AtacadoContext contexto) : base()
        {
            this.servico = new CategoriaService(contexto);
        }

        [HttpGet]
        public List<CategoriaPoco> GetAll()
        {           
            return this.servico.Listar();
        }

        [HttpGet("{id:int}")]
        public CategoriaPoco GetByID(int id)
        {          
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public CategoriaPoco Post([FromBody] CategoriaPoco poco)
        {          
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public CategoriaPoco Put([FromBody] CategoriaPoco poco)
        {         
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public CategoriaPoco Delete([FromBody] CategoriaPoco poco)
        {           
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public CategoriaPoco Delete(int id)
        {         
            return this.servico.Excluir(id);
        }
    }
}
