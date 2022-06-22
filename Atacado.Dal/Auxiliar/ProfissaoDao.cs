using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Auxiliar
{
    public class ProfissaoDao : BaseAncestralDao<Profissao>
    {
        public override Profissao Create(Profissao obj)
        {
            this.contexto.Profissaos.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override Profissao Delete(int id)
        {
            Profissao del = this.Read(id);
            this.contexto.Profissaos.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Profissao Delete(Profissao obj)
        {
            return this.Delete(obj.IdProfissao);
        }

        public override Profissao Read(int id)
        {
            Profissao obj = this.contexto.Profissaos.SingleOrDefault(area => area.IdProfissao == id);
            return obj;
        }

        public override List<Profissao> ReadAll()
        {
            return this.contexto.Profissaos.ToList();
        }

        public override Profissao Update(Profissao obj)
        {
            Profissao alt = this.Read(obj.IdProfissao);
            alt.DescricaoProfissao = obj.DescricaoProfissao;
            alt.Situacao = obj.Situacao;
            this.contexto.SaveChanges();
            return alt;
        }
    }
}
