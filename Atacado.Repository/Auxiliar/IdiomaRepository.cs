using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository.Auxiliar
{
    public class IdiomaRepository : BaseRepository<Idioma>
    {
        public IdiomaRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Idioma DeleteById(int id)
        {
            Idioma idioma = this.Read(id);
            this.context.Set<Idioma>().Remove(idioma);
            this.context.SaveChanges();
            return idioma;
        }
    }
}
