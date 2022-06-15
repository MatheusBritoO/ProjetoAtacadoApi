using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Auxiliar
{
    public class AreaConhecimentoDao : BaseAncestralDao<AreaConhecimento>
    {
        public AreaConhecimentoDao() : base()
        { }
        
        public override AreaConhecimento Create(AreaConhecimento obj)
        {
            this.contexto.AreaConhecimentos.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override AreaConhecimento Delete(int id)
        {
            AreaConhecimento del = this.Read(id);
            this.contexto.AreaConhecimentos.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override AreaConhecimento Delete(AreaConhecimento obj)
        {
            return this.Delete(obj.IdArea);
        }

        public override AreaConhecimento Read(int id)
        {
            AreaConhecimento obj = this.contexto.AreaConhecimentos.SingleOrDefault(area => area.IdArea == id);
            return obj;
        }

        public override List<AreaConhecimento> ReadAll()
        {
            return this.contexto.AreaConhecimentos.ToList();
        }

        public override AreaConhecimento Update(AreaConhecimento obj)
        {
            AreaConhecimento alt = this.Read(obj.IdArea);
            alt.DescricaoArea = obj.DescricaoArea;            
            alt.Situacao = obj.Situacao;
            this.contexto.SaveChanges();
            return alt;
        }
    }
}
