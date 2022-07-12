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
    public class CursoController : ControllerBase
    {
        private CursoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public CursoController(AtacadoContext contexto) : base()
        {
            this.servico = new CursoService(contexto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CursoPoco> GetAll()
        {
            return this.servico.Listar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public CursoPoco GetByID(int id)
        {
            return this.servico.Selecionar(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public CursoPoco Post([FromBody] CursoPoco poco)
        {
            return this.servico.Criar(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public CursoPoco Put([FromBody] CursoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public CursoPoco Delete([FromBody] CursoPoco poco)
        {
            return this.servico.Excluir(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public CursoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
