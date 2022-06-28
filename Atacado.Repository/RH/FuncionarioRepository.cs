using Atacado.EF.Database;
using Atacado.Repository.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Repository.RH
{
    public class FuncionarioRepository : BaseRepository<Funcionario>
    {
        public FuncionarioRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Funcionario DeleteById(int id)
        {
            Funcionario fun = this.context.Set<Funcionario>().Find(id);
            this.context.Set<Funcionario>().Remove(fun);
            this.context.SaveChanges();
            return fun;
        }
    }
}
