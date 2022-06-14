using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Estoque
{
    public class ProdutoDao : BaseAncestralDao<Produto>
    {
        private AtacadoContext contexto;

        public ProdutoDao() : base()
        {
            this.contexto = new AtacadoContext();
        }

        public override Produto Create(Produto obj)
        {
            this.contexto.Produtos.Add(obj);
            return obj;
        }

        public override Produto Read(int id)
        {
            Produto obj = this.contexto.Produtos.SingleOrDefault(pro => pro.IdProduto == id);
            return obj;
        }

        public override List<Produto> ReadAll()
        {
            return this.contexto.Produtos.ToList();
        }

        public override Produto Update(Produto obj)
        {
            Produto alt = this.Read(obj.IdProduto);
            alt.DescricaoProduto = obj.DescricaoProduto;
            alt.IdSubcategoria = obj.IdSubcategoria;
            alt.IdCategoria = obj.IdCategoria;
            alt.Situacao = obj.Situacao;
            return alt;
        }

        public override Produto Delete(int id)
        {
            Produto del = this.Read(id);
            this.contexto.Produtos.Remove(del);
            return del;
        }

        public override Produto Delete(Produto obj)
        {
            return this.Delete(obj.IdProduto);
        }
    }
}
