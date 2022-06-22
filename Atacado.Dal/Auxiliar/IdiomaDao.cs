using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Auxiliar
{
    public class IdiomaDao : BaseAncestralDao<Idioma>
    {
        public override Idioma Create(Idioma obj)
        {
            this.contexto.Idiomas.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override Idioma Delete(int id)
        {
            Idioma del = this.Read(id);
            this.contexto.Idiomas.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Idioma Delete(Idioma obj)
        {
            return this.Delete(obj.IdIdioma);
        }

        public override Idioma Read(int id)
        {
            Idioma obj = this.contexto.Idiomas.SingleOrDefault(area => area.IdIdioma == id);
            return obj;
        }

        public override List<Idioma> ReadAll()
        {
            return this.contexto.Idiomas.ToList();
        }

        public override Idioma Update(Idioma obj)
        {
            Idioma alt = this.Read(obj.IdIdioma);
            alt.DescricaoIdioma = obj.DescricaoIdioma;
            alt.Situacao = obj.Situacao;
            this.contexto.SaveChanges();
            return alt;
        }
    }
}
