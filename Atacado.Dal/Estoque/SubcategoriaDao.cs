using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Estoque
{
    public class SubcategoriaDao : BaseAncestralDao<Subcategoria>
    {
        private AtacadoContext contexto;

        public SubcategoriaDao() : base()
        {
            this.contexto = new AtacadoContext();
        }

        public override Subcategoria Create(Subcategoria obj)
        {
            this.contexto.Subcategorias.Add(obj);
            return obj;
        }

        public override Subcategoria Read(int id)
        {
            Subcategoria obj = this.contexto.Subcategorias.SingleOrDefault(cat => cat.IdSubcategoria == id);
            return obj;
        }

        public override List<Subcategoria> ReadAll()
        {
            return this.contexto.Subcategorias.ToList();
        }

        public override Subcategoria Update(Subcategoria obj)
        {
            Subcategoria alt = this.Read(obj.IdSubcategoria);
            alt.IdCategoria = obj.IdCategoria;
            alt.DescricaoSubcategoria = obj.DescricaoSubcategoria;
            alt.Situacao = obj.Situacao;
            return alt;
        }

        public override Subcategoria Delete(int id)
        {
            Subcategoria del = this.Read(id);
            this.contexto.Subcategorias.Remove(del);
            return del;
        }

        public override Subcategoria Delete(Subcategoria obj)
        {
            return this.Delete(obj.IdSubcategoria);
        }
    }
}
