using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class RebanhoController : ControllerBase
    {
        private RebanhoService servico;

        public RebanhoController() : base()
        {
            this.servico = new RebanhoService();
        }

        [HttpGet("{skip:int}/{take:int}")]
        public List<RebanhoPoco> Get(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }

        [HttpGet("{id:int}")]
        public RebanhoPoco GetPorId(int id)
        {
            return this.servico.Selecionar(id);
        }

        [HttpGet("anoref/{anoRef:int}/idmun/{idMun:int}")]
        public List<RebanhoPoco> GetPorAnoRefIdMun(int anoRef, int idMun)
        {
            return this.servico.FiltrarPorAnoRefIdMun(anoRef, idMun);
        }
    }
}
