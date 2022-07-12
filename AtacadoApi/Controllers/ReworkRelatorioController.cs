using Atacado.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Service.Estoque;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReworkRelatorioController : ControllerBase
    {
        private RelatorioService service;

        public ReworkRelatorioController(AtacadoContext contexto) : base()
        {
            this.service = new RelatorioService(contexto);
        }
        
        [HttpGet("Categoria/PorID/{idCat:int}")]
        public ActionResult<List<RelatorioPoco>> GetRelatorioPorCategoria(int idCat)
        {
            try
            {
                List<RelatorioPoco> resposta = this.service.CategoriaPorID(idCat);
                return Ok(resposta);

            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("Subcategoria/PorID/{idSub:int}")]
        public ActionResult<List<RelatorioPoco>> GetPorSubcategoria(int idSub)
        {
            try
            {
                List<RelatorioPoco> resposta = this.service.SubcategoriaPorID(idSub);
                return Ok(resposta);

            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("Produtos/PorID/{idPro:int}")]
        public ActionResult<List<RelatorioPoco>> GetPorProduto(int idPro)
        {
            try
            {
                List<RelatorioPoco> resposta = this.service.ProdutoPorID(idPro);
                return Ok(resposta);

            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }





    }
}
