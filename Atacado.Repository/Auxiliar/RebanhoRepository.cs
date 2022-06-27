using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Repository.Auxiliar
{
    public class RebanhoRepository : BaseRepository<Rebanho>
    {
        public RebanhoRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Rebanho DeleteById(int id)
        {
            Rebanho reb = this.Read(id);
            this.context.Set<Rebanho>().Remove(reb);
            this.context.SaveChanges();
            return reb;
        }
    }
}
