using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository.Estoque
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public CategoriaRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Categoria DeleteById(int id)
        {
            Categoria cat = this.Read(id);
            this.context.Set<Categoria>().Remove(cat);
            this.context.SaveChanges();
            return cat;
        }
    }
}
