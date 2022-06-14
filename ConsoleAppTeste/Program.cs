using Atacado.Service.Estoque;
using Atacado.Poco.Estoque;
using Atacado.EF.Database;

namespace ConsoleAppTeste
{
     public class program
     {
        public static void Main(string[] args)
        {
            TestarListarServicePro();
            Console.ReadLine();
        }
        private static void TestarListarServiceCat()
        {
            CategoriaService srv = new CategoriaService();
            List <CategoriaPoco>listaPoco = srv.Listar();
            foreach(CategoriaPoco poco in listaPoco)
            {
                Console.WriteLine("Codigo: {0}- Descrição: {1} Situação: {2}", poco.Codigo,poco.Descricao,poco.Situacao);
            }
        }
        private static void TestarListarServiceSub()
        {
            SubcategoriaService srv = new SubcategoriaService();
            List<SubcategoriaPoco> listaPoco = srv.Listar();
            foreach (SubcategoriaPoco poco in listaPoco)
            {
                Console.WriteLine("Codigo: {0} Código Categoria: {1} Descrição Subcategoria: {2}", poco.IdSubcategoria, poco.IdCategoria, poco.DescricaoSubcategoria);
            }
        }

        private static void TestarListarServicePro()
        {
            ProdutoService srv = new ProdutoService();
            List<ProdutoPoco> listaPoco = srv.Listar();
            foreach (ProdutoPoco poco in listaPoco)
            {
                Console.WriteLine("Codigo: {0} Descrição Produto: {1} Código Categoria: {2} Código Subcategoria: {3} Situação Produto: {4}", poco.IdProduto, poco.DescricaoProduto, poco.IdCategoria, poco.IdSubcategoria, poco.Situacao);
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
            }
        }


    }
}