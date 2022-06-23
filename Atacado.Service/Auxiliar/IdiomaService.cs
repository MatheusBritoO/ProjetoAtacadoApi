using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Auxiliar;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Auxiliar
{
    public class IdiomaService : BaseAncestralService<IdiomaPoco>
    {
        private IdiomaDao dao;
        private IdiomaMapper mapConfig;

        public IdiomaService()
        {
            this.dao = new IdiomaDao();
            this.mapConfig = new IdiomaMapper();
        }

        public override List<IdiomaPoco> Listar()
        {
            List<Idioma> listDOM = this.dao.ReadAll();
            List<IdiomaPoco> listPOCO = new List<IdiomaPoco>();
            foreach (Idioma item in listDOM)
            {
                IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(item);
                listPOCO.Add(poco);
            }
            return listPOCO;
        }

        public override IdiomaPoco Selecionar(int id)
        {
            Idioma dom = this.dao.Read(id);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(dom);
            return poco;
        }

        public override IdiomaPoco Criar(IdiomaPoco obj)
        {
            Idioma dom = this.mapConfig.Mapper.Map<Idioma>(obj);
            Idioma criado = this.dao.Create(dom);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(criado);
            return poco;
        }

        public override IdiomaPoco Atualizar(IdiomaPoco obj)
        {
            Idioma dom = this.mapConfig.Mapper.Map<Idioma>(obj);
            Idioma atualizado = this.dao.Update(dom);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(atualizado);
            return poco;
        }

        public override IdiomaPoco Excluir(IdiomaPoco obj)
        {
            return this.Excluir(obj.IdIdioma);
        }
        public override IdiomaPoco Excluir(int id)
        {
            Idioma excluido = this.dao.Delete(id);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(excluido);
            return poco;
        }
    }
}
