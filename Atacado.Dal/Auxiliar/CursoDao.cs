using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Auxiliar
{
    public class CursoDao : BaseAncestralDao<Curso>
    {
        public override Curso Create(Curso obj)
        {
            this.contexto.Cursos.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override Curso Delete(int id)
        {
            Curso del = this.Read(id);
            this.contexto.Cursos.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Curso Delete(Curso obj)
        {
            return this.Delete(obj.IdCurso);      
        }

        public override Curso Read(int id)
        {
            Curso obj = this.contexto.Cursos.SingleOrDefault(area => area.IdCurso == id);
            return obj;
        }

        public override List<Curso> ReadAll()
        {
            return this.contexto.Cursos.ToList();
        }

        public override Curso Update(Curso obj)
        {
            Curso alt = this.Read(obj.IdCurso);
            alt.DescricaoCurso = obj.DescricaoCurso;
            alt.Situacao = obj.Situacao;
            this.contexto.SaveChanges();
            return alt;
        }
    }
}
