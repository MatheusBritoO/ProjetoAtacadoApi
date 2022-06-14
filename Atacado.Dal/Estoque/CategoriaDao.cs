using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Estoque
{
    public class CategoriaDao : BaseAncestralDao<Categoria>
    {
        private AtacadoContext contexto;

        public CategoriaDao() : base()
        {
            this.contexto = new AtacadoContext();
        }

        public override Categoria Create(Categoria obj)
        {
            this.contexto.Categorias.Add(obj);
            return obj;
        }

        public override Categoria Read(int id)
        {
            Categoria obj = this.contexto.Categorias.SingleOrDefault(cat => cat.IdCategoria == id);
            return obj;
        }

        public override List<Categoria> ReadAll()
        {
            return this.contexto.Categorias.ToList();
        }

        public override Categoria Update(Categoria obj)
        {
            Categoria alt = this.Read(obj.IdCategoria);
            alt.DescricaoCategoria = obj.DescricaoCategoria;
            alt.Situacao = obj.Situacao;
            return alt;
        }

        public override Categoria Delete(int id)
        {
            Categoria del = this.Read(id);
            this.contexto.Categorias.Remove(del);
            return del;
        }

        public override Categoria Delete(Categoria obj)
        {
            return this.Delete(obj.IdCategoria);
        }
    }
}
