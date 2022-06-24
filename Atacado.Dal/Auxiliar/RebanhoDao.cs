using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Auxiliar
{
    public class RebanhoDao : BaseAncestralDao<Rebanho>
    {
        public RebanhoDao() : base()
        { }

        public override Rebanho Create(Rebanho obj)
        {
            this.contexto.Rebanhos.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override Rebanho Read(int id)
        {
            Rebanho obj = this.contexto.Rebanhos.SingleOrDefault(pro => pro.IdRebanho == id);
            return obj;
        }

        public override List<Rebanho> ReadAll()
        {
            return this.contexto.Rebanhos.ToList();
        }
        public List<Rebanho> ReadAll(int skip, int take)
        {
            return this.contexto.Rebanhos.Skip(skip).Take(take).ToList();
        }

        public IQueryable<Rebanho> QueryBy(Func<Rebanho, bool>predicado)
        {
            return this.contexto.Rebanhos.Where(predicado).AsQueryable();
        }

        public override Rebanho Update(Rebanho obj)
        {
            Rebanho alt = this.Read(obj.IdRebanho);
            alt.IdTipoRebanho = obj.IdTipoRebanho;
            alt.AnoRef = obj.AnoRef;
            alt.IdMunicipio = obj.IdMunicipio;
            alt.IdTipoRebanho = obj.IdTipoRebanho;
            alt.TipoRebanho = obj.TipoRebanho;
            alt.Quantidade = obj.Quantidade;
            alt.Situacao = obj.Situacao;
            return alt;
        }

        public override Rebanho Delete(int id)
        {
            Rebanho del = this.Read(id);
            this.contexto.Rebanhos.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Rebanho Delete(Rebanho obj)
        {
            return this.Delete(obj.IdRebanho);
        }
    }
}
