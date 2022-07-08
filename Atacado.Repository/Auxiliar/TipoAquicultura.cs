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
    public class TipoAquiculturaRepository : BaseRepository<TipoAquicultura>
    {
        public TipoAquiculturaRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override TipoAquicultura DeleteById(int id)
        {
            TipoAquicultura tac = this.Read(id);
            this.context.Set<TipoAquicultura>().Remove(tac);
            this.context.SaveChanges();
            return tac;
        }
    }
}
