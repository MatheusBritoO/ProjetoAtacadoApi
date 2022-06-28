using Atacado.Poco.RH;
using Atacado.Service.RH;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/rh/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private FuncionarioService servico;

        public FuncionarioController() : base()
        {
            this.servico = new FuncionarioService();
        }

        [HttpGet("{skip:int}/{take:int}")]
        public List<FuncionarioPoco> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }
    }
}
