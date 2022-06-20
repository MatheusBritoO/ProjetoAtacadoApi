using Atacado.Poco.Estoque;
using Atacado.Service.Estoque;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaService servico;


        public SubcategoriaController() : base()
        {
            this.servico = new SubcategoriaService();
        }

        [HttpGet("{skip:int}/{take:int}")]
        public List<SubcategoriaPoco> GetAll(int skip, int take)
        {
            return this.servico.Listar(skip, take);
        }
    }
}
