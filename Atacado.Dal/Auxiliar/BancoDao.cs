using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Auxiliar
{
    public class BancoDao : BaseAncestralDao<Banco>
    {

        public BancoDao() : base()
        { }


        public override Banco Create(Banco obj)
        {
            this.contexto.Bancos.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override Banco Delete(int id)
        {
            Banco del = this.Read(id);
            this.contexto.Bancos.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Banco Delete(Banco obj)
        {
            return this.Delete(obj.IdBanco);
        }

        public override Banco Read(int id)
        {
            Banco obj = this.contexto.Bancos.SingleOrDefault(area => area.IdBanco == id);
            return obj;
        }

        public override List<Banco> ReadAll()
        {
            return this.contexto.Bancos.ToList();
        }

        public override Banco Update(Banco obj)
        {
            Banco alt = this.Read(obj.IdBanco);
            alt.DescricaoBanco = obj.DescricaoBanco;
            alt.Situacao = obj.Situacao;
            this.contexto.SaveChanges();
            return alt;
        }
    }
}
