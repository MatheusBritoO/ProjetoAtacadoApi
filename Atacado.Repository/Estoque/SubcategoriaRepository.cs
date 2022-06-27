using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Repository.Estoque
{
    public class SubcategoriaRepository : BaseRepository<Subcategoria>
    {
        public SubcategoriaRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Subcategoria DeleteById(int id)
        {
            Subcategoria scat = this.Read(id);
            this.context.Set<Subcategoria>().Remove(scat);
            this.context.SaveChanges();
            return scat;
        }
    }
}
