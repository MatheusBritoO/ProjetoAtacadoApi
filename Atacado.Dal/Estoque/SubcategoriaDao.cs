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
      

        public SubcategoriaDao() : base()
        { }

        public override Subcategoria Create(Subcategoria obj)
        {
            this.contexto.Subcategorias.Add(obj);
            this.contexto.SaveChanges();
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

        public List<Subcategoria> ReadAll(int skip, int take)
        {
            return this.contexto.Subcategorias.Skip(skip).Take(take).ToList();
        }      
        
        public override Subcategoria Update(Subcategoria obj)
        {
            Subcategoria alt = this.Read(obj.IdSubcategoria);
            alt.IdCategoria = obj.IdCategoria;
            alt.DescricaoSubcategoria = obj.DescricaoSubcategoria;
            alt.Situacao = obj.Situacao;
            this.contexto.SaveChanges();
            return alt;
        }

        public override Subcategoria Delete(int id)
        {
            Subcategoria del = this.Read(id);
            this.contexto.Subcategorias.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Subcategoria Delete(Subcategoria obj)
        {
            return this.Delete(obj.IdSubcategoria);
        }
    }
}
