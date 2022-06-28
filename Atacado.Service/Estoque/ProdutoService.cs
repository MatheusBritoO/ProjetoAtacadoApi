using Atacado.EF.Database;
using Atacado.Mapper.Estoque;
using Atacado.Poco.Estoque;
using Atacado.Repository.Estoque;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public class ProdutoService : BaseAncestralService<ProdutoPoco, Produto>
    {
        private ProdutoRepository repositorio;
        private ProdutoMapper mapConfig;

        public ProdutoService()
        {
            this.repositorio = new ProdutoRepository(new AtacadoContext());
            this.mapConfig = new ProdutoMapper();
        }

       

        public List<ProdutoPoco> Listar(int pular, int exibir)
        {
            List<Produto> listDOM = this.repositorio.Read(pular, exibir).ToList();
            return ProcessarListaDOM(listDOM);
        }

        protected override List<ProdutoPoco> ProcessarListaDOM(List<Produto> listDOM)
        {
            return listDOM.Select(dom => this.mapConfig.Mapper.Map<ProdutoPoco>(dom)).ToList();
        }

        public override ProdutoPoco Selecionar(int id)
        {
            Produto dom = this.repositorio.Read(id);
            ProdutoPoco poco = this.mapConfig.Mapper.Map<ProdutoPoco>(dom);
            return poco;
        }

        public override ProdutoPoco Criar(ProdutoPoco obj)
        {
            Produto dom = this.mapConfig.Mapper.Map<Produto>(obj);
            Produto criado = this.repositorio.Add(dom);
            ProdutoPoco poco = this.mapConfig.Mapper.Map<ProdutoPoco>(criado);
            return poco;
        }

        public override ProdutoPoco Atualizar(ProdutoPoco obj)
        {
            Produto dom = this.mapConfig.Mapper.Map<Produto>(obj);
            Produto atualizado = this.repositorio.Edit(dom);
            ProdutoPoco poco = this.mapConfig.Mapper.Map<ProdutoPoco>(atualizado);
            return poco;
        }

        public override ProdutoPoco Excluir(ProdutoPoco obj)
        {
            return this.Excluir(obj.IdProduto);
        }
        public override ProdutoPoco Excluir(int id)
        {
            Produto excluido = this.repositorio.DeleteById(id);
            ProdutoPoco poco = this.mapConfig.Mapper.Map<ProdutoPoco>(excluido);
            return poco;
        }


    }
}

