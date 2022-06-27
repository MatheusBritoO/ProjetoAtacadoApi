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
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public ProdutoRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Produto DeleteById(int id)
        {
            Produto pro = this.Read(id);
            this.context.Set<Produto>().Remove(pro);
            this.context.SaveChanges();
            return pro;
        }
    }
}
