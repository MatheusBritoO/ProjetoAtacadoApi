using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository.Auxiliar
{
    public class AreaConhecimentoRepository : BaseRepository<AreaConhecimento>
    {
        public AreaConhecimentoRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override AreaConhecimento DeleteById(int id)
        {
            AreaConhecimento AreaC = this.Read(id);
            this.context.Set<AreaConhecimento>().Remove(AreaC);
            this.context.SaveChanges();
            return AreaC;
        }
    }
}
