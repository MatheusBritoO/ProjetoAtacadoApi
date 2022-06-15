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

        [HttpGet]
        public List<CategoriaPoco> GetAll()
        {
            this.servico = new CategoriaService();
            return this.servico.Listar();
        }
    
        [HttpGet("{id:int}")]
        public CategoriaPoco GetByID(int id)
        {
            this.servico = new CategoriaService();
            return this.servico.Selecionar(id);
        }
    }
}
