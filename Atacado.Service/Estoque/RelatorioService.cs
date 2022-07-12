using Atacado.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repository.Auxiliar;
using Atacado.Repository.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public  class RelatorioService
    {
        private AtacadoContext contexto;
        private CategoriaRepository categoriaRepo;
        private SubcategoriaRepository subcategoriaRepo;
        private ProdutoRepository produtoRepo;
        private AquiculturaRepository aquiRepo;
        private TipoAquiculturaRepository tipoAquiRepo;
        
    
    
        public RelatorioService(AtacadoContext contexto)
        {
            this.contexto = contexto;
            this.categoriaRepo = new CategoriaRepository(this.contexto);
            this.subcategoriaRepo = new SubcategoriaRepository(this.contexto);
            this.produtoRepo = new ProdutoRepository(this.contexto);           
        }
    
        public List<RelatorioPoco> CategoriaPorID(int idCategoria)
        {
            List<RelatorioPoco> pesquisa =
                (from cats in this.contexto.Categorias
                join subs in this.contexto.Subcategorias on cats.IdCategoria equals subs.IdCategoria
                join prods in this.contexto.Produtos on subs.IdCategoria equals prods.IdCategoria
                where cats.IdCategoria == idCategoria
                select new RelatorioPoco() 
                {
                          IdCategoria =  cats.IdCategoria,  
                          DescricaoCategoria = cats.DescricaoCategoria,
                          IdSubcategoria = subs.IdSubcategoria,
                          DescricaoSubcategoria = subs.DescricaoSubcategoria,
                          IdProduto = prods.IdProduto,
                          DescricaoProduto = prods.DescricaoProduto,
                }).ToList();
            return pesquisa;
        }



        public List<RelatorioPoco> SubcategoriaPorID(int idSubcategoria)
        {
            List<RelatorioPoco> pesquisa =
                 (from subs in this.contexto.Subcategorias
                  join cats in contexto.Categorias on subs.IdCategoria equals cats.IdCategoria
                  join prods in contexto.Produtos on subs.IdSubcategoria equals prods.IdSubcategoria
                  where subs.IdSubcategoria== idSubcategoria
                   select new RelatorioPoco()
                   {
                        IdCategoria = cats.IdCategoria,
                         DescricaoCategoria = cats.DescricaoCategoria,
                         IdSubcategoria = subs.IdSubcategoria,
                         DescricaoSubcategoria = subs.DescricaoSubcategoria,
                         IdProduto = prods.IdProduto,
                         DescricaoProduto = prods.DescricaoProduto,
                   }).ToList();
                        return pesquisa;
        }


        public List<RelatorioPoco> ProdutoPorID(int idProduto)
        {
            List<RelatorioPoco> pesquisa =
                 (from prods in this.contexto.Produtos
                  join cats in contexto.Categorias on prods.IdCategoria equals cats.IdCategoria
                  join subs in contexto.Subcategorias on prods.IdSubcategoria equals subs.IdSubcategoria
                  where prods.IdProduto == idProduto
                  select new RelatorioPoco()
                  {
                      IdCategoria = cats.IdCategoria,
                      DescricaoCategoria = cats.DescricaoCategoria,
                      IdSubcategoria = subs.IdSubcategoria,
                      DescricaoSubcategoria = subs.DescricaoSubcategoria,
                      IdProduto = prods.IdProduto,
                      DescricaoProduto = prods.DescricaoProduto,
                  }).ToList();
            return pesquisa;
        }

    }
}
