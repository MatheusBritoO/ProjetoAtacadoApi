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

        public EmpresaController() : base()
        {
            this.servico = new EmpresaService();
        }

        [HttpGet]
        public List<EmpresaPoco> GetAll()
        {
            return this.servico.Listar();
        }

        [HttpGet("{skip:int}/{take:int}")]
        public List<EmpresaPoco> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }

        [HttpGet("{id:int}")]
        public EmpresaPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpPost]
        public EmpresaPoco Post([FromBody] EmpresaPoco poco)
        {
            return this.servico.Criar(poco);
        }

        [HttpPut]
        public EmpresaPoco Put([FromBody] EmpresaPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        [HttpDelete]
        public EmpresaPoco Delete([FromBody] EmpresaPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        [HttpDelete("{id:int}")]
        public EmpresaPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }

    }
}
