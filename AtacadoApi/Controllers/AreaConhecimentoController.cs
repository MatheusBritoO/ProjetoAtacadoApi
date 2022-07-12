using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AreaConhecimentoController : ControllerBase
    {
        private AreaConhecimentoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public AreaConhecimentoController(AtacadoContext contexto) : base()
        {
            this.servico = new AreaConhecimentoService(contexto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<AreaConhecimentoPoco> GetAll()
        {
            return this.servico.Listar();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public AreaConhecimentoPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public AreaConhecimentoPoco Post([FromBody] AreaConhecimentoPoco poco)
        {
            return this.servico.Criar(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public AreaConhecimentoPoco Put([FromBody] AreaConhecimentoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public AreaConhecimentoPoco Delete([FromBody] AreaConhecimentoPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public AreaConhecimentoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
