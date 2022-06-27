using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository.Auxiliar
{
    public class ProfissaoRepository : BaseRepository<Profissao>
    {
        public ProfissaoRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Profissao DeleteById(int id)
        {
            Profissao prof = this.Read(id);
            this.context.Set<Profissao>().Remove(prof);
            this.context.SaveChanges();
            return prof;
        }

    }
}
