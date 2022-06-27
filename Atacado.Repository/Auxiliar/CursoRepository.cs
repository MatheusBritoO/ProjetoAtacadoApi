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
    public class CursoRepository : BaseRepository<Curso>
    {
        public CursoRepository(AtacadoContext contexto) : base(contexto)
        {
        }

        public override Curso DeleteById(int id)
        {
            Curso curso = this.Read(id);
            this.context.Set<Curso>().Remove(curso);
            this.context.SaveChanges();
            return curso;
        }
    }
}
