using Atacado.EF.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{   /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        [HttpGet("fichacadastral/{idRebanho:int}")]
        public ActionResult<object> Get(int idRebanho)
        {
            AtacadoContext contexto = new AtacadoContext();
            try
            {
                              var retorno = from rebs in contexto.Rebanhos
                              where rebs.IdRebanho == idRebanho
                              join muns in contexto.Municipios on rebs.IdMunicipio equals muns.CodigoIbge7
                              join ufs in contexto.UnidadesFederacaos on muns.SiglaUf equals ufs.SiglaUf
                              select new
                              {
                                  idRebanho = rebs.IdRebanho,
                                  AnoReferencia = rebs.AnoRef,
                                  IdMunicipio = rebs.IdMunicipio,
                                  NomeMunicipio = muns.NomeMunicipio,
                                  SiglaUF = ufs.SiglaUf,
                                  NomeEstado = ufs.DescricaoUf,
                                  IdTipoRebanho = rebs.IdTipoRebanho,
                                  NomeRebanho = rebs.TipoRebanho,
                                  Quantidade = rebs.Quantidade,
                                  Situacao = rebs.Situacao
                              };
                return Ok(retorno);
            }
            catch (Exception ex )
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
                                   
            //Rebanho rebanho = contexto.Rebanhos.SingleOrDefault(reb => reb.IdRebanho == idRebanho);
            //if (rebanho != null)
            //{
            //    Municipio municipio = contexto.Municipios.SingleOrDefault(mun => mun.CodigoIbge7 == rebanho.IdMunicipio);
            //    if(municipio != null)
            //    {
            //        UnidadesFederacao estado = contexto.UnidadesFederacaos.SingleOrDefault(est => est.SiglaUf == municipio.SiglaUf);
            //        if(estado != null)
            //        {
            //            var retorno = new
            //            {
            //                idRebanho = rebanho.IdRebanho,
            //                AnoReferencia = rebanho.AnoRef,
            //                IdMunicipio = rebanho.IdMunicipio,
            //                NomeMunicipio = municipio.NomeMunicipio,
            //                SiglaUF = estado.SiglaUf,
            //                NomeEstado = estado.DescricaoUf,
            //                IdTipoRebanho = rebanho.IdTipoRebanho,
            //                NomeRebanho = rebanho.TipoRebanho,
            //                Quantidade = rebanho.Quantidade,
            //                Situacao = rebanho.Situacao
            //            };
            //            return Ok(retorno);
            //        }
            //        else
            //        {
            //            return Problem("Estado não encontrado.", statusCode: StatusCodes.Status400BadRequest);
            //        }
            //    }
            //    else
            //    {
            //        return Problem("Municipio não encontrado.", statusCode: StatusCodes.Status400BadRequest);
            //    }
            //}
            //else
            //{
            //    return Problem("Rebanho não encontrado.", statusCode: StatusCodes.Status400BadRequest);
            //}
       
        }

        [HttpGet("pesquisa/{anoRef:int}/{IdMunicipio:int}")]
        public ActionResult<List<object>> GetPorAnoRefMun(int anoRef,int  IdMunicipio)
        {
            AtacadoContext contexto = new AtacadoContext();
            try
            {
                var retorno = from rebs in contexto.Rebanhos
                              where (rebs.AnoRef == anoRef) &&(rebs.IdMunicipio == IdMunicipio)
                              join muns in contexto.Municipios on rebs.IdMunicipio equals muns.CodigoIbge7
                              join ufs in contexto.UnidadesFederacaos on muns.SiglaUf equals ufs.SiglaUf
                              select new
                              {
                                  idRebanho = rebs.IdRebanho,
                                  AnoReferencia = rebs.AnoRef,
                                  IdMunicipio = rebs.IdMunicipio,
                                  NomeMunicipio = muns.NomeMunicipio,
                                  SiglaUF = ufs.SiglaUf,
                                  NomeEstado = ufs.DescricaoUf,
                                  IdTipoRebanho = rebs.IdTipoRebanho,
                                  NomeRebanho = rebs.TipoRebanho,
                                  Quantidade = rebs.Quantidade,
                                  Situacao = rebs.Situacao
                              };
                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("buscaPorIdCategoria/{cat:int}")]
        public ActionResult<List<object>> GetPorCategoria(int cat)
        {
            AtacadoContext contexto = new AtacadoContext();
            try
            {
                var retorno = from cats in contexto.Categorias
                              where (cats.IdCategoria == cat) 
                              join subs in contexto.Subcategorias on cats.IdCategoria equals subs.IdCategoria
                              join pros in contexto.Produtos on subs.IdSubcategoria equals pros.IdSubcategoria
                              select new
                              {
                                  IdCategoria = cats.IdCategoria,
                                  DescricaoCategoria = cats.DescricaoCategoria,
                                  IdSubcategoria = subs.IdSubcategoria,
                                  DescricaoSubcategoria = subs.DescricaoSubcategoria,
                                  IdProduto = pros.IdProduto,
                                  DescricaoProduto = pros.DescricaoProduto,
                              };
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("buscaPorIdSubcategoria/{sub:int}")]
        public ActionResult<List<object>> GetPorSubcategoria(int sub)
        {
            AtacadoContext contexto = new AtacadoContext();
            try
            {
                var retorno = from subs in contexto.Subcategorias
                              where (subs.IdSubcategoria == sub)
                              join cats in contexto.Categorias on subs.IdCategoria equals cats.IdCategoria
                              join pros in contexto.Produtos on subs.IdSubcategoria equals pros.IdSubcategoria
                              select new
                              {
                                  IdCategoria = cats.IdCategoria,
                                  DescricaoCategoria = cats.DescricaoCategoria,
                                  IdSubcategoria = subs.IdSubcategoria,
                                  DescricaoSubcategoria = subs.DescricaoSubcategoria,
                                  IdProduto = pros.IdProduto,
                                  DescricaoProduto = pros.DescricaoProduto,
                              };
                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("buscaPorIdProduto/{pro:int}")]
        public ActionResult<List<object>> GetPorProduto(int pro)
        {
            AtacadoContext contexto = new AtacadoContext();
            try
            {
                var retorno = from pros in contexto.Produtos
                              where (pros.IdProduto == pro)
                              join cats in contexto.Categorias on pros.IdCategoria equals cats.IdCategoria
                              join subs in contexto.Subcategorias on pros.IdProduto equals subs.IdSubcategoria
                              select new
                              {
                                  IdCategoria = cats.IdCategoria,
                                  DescricaoCategoria = cats.DescricaoCategoria,
                                  IdSubcategoria = subs.IdSubcategoria,
                                  DescricaoSubcategoria = subs.DescricaoSubcategoria,
                                  IdProduto = pros.IdProduto,
                                  DescricaoProduto = pros.DescricaoProduto,
                              };
                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }
        }

    }
}

