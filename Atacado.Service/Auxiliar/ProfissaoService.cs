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
    public class ProfissaoService : BaseAncestralService<ProfissaoPoco>
    {
        private ProfissaoDao dao;
        private ProfissaoMapper mapConfig;

        public ProfissaoService()
        {
            this.dao = new ProfissaoDao();
            this.mapConfig = new ProfissaoMapper();
        }

        public override List<ProfissaoPoco> Listar()
        {
            List<Profissao> listDOM = this.dao.ReadAll();
            List<ProfissaoPoco> listPOCO = new List<ProfissaoPoco>();
            foreach (Profissao item in listDOM)
            {
                ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(item);
                listPOCO.Add(poco);
            }
            return listPOCO;
        }

        public override ProfissaoPoco Selecionar(int id)
        {
            Profissao dom = this.dao.Read(id);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(dom);
            return poco;
        }

        public override ProfissaoPoco Criar(ProfissaoPoco obj)
        {
            Profissao dom = this.mapConfig.Mapper.Map<Profissao>(obj);
            Profissao criado = this.dao.Create(dom);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(criado);
            return poco;
        }

        public override ProfissaoPoco Atualizar(ProfissaoPoco obj)
        {
            Profissao dom = this.mapConfig.Mapper.Map<Profissao>(obj);
            Profissao atualizado = this.dao.Update(dom);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(atualizado);
            return poco;
        }

        public override ProfissaoPoco Excluir(ProfissaoPoco obj)
        {
            return this.Excluir(obj.IdProfissao);
        }
        public override ProfissaoPoco Excluir(int id)
        {
            Profissao excluido = this.dao.Delete(id);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(excluido);
            return poco;
        }
    }
}
