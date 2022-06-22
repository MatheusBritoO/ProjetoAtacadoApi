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
    public class BancoService : BaseAncestralService<BancoPoco>
    {
        private BancoDao dao;
        private BancoMapper mapConfig;

        public BancoService()
        {
            this.dao = new BancoDao();
            this.mapConfig = new BancoMapper();
        }

        public override List<BancoPoco> Listar()
        {
            List<Banco> listDOM = this.dao.ReadAll();
            List<BancoPoco> listPOCO = new List<BancoPoco>();
            foreach (Banco item in listDOM)
            {
                BancoPoco poco = this.mapConfig.Mapper.Map<BancoPoco>(item);
                listPOCO.Add(poco);
            }
            return listPOCO;
        }

        public override BancoPoco Selecionar(int id)
        {
            Banco dom = this.dao.Read(id);
            BancoPoco poco = this.mapConfig.Mapper.Map<BancoPoco>(dom);
            return poco;
        }

        public override BancoPoco Criar(BancoPoco obj)
        {
            Banco dom = this.mapConfig.Mapper.Map<Banco>(obj);
            Banco criado = this.dao.Create(dom);
            BancoPoco poco = this.mapConfig.Mapper.Map<BancoPoco>(criado);
            return poco;
        }

        public override BancoPoco Atualizar(BancoPoco obj)
        {
            Banco dom = this.mapConfig.Mapper.Map<Banco>(obj);
            Banco atualizado = this.dao.Update(dom);
            BancoPoco poco = this.mapConfig.Mapper.Map<BancoPoco>(atualizado);
            return poco;
        }

        public override BancoPoco Excluir(BancoPoco obj)
        {
            return this.Excluir(obj.IdBanco);
        }
        public override BancoPoco Excluir(int id)
        {
            Banco excluido = this.dao.Delete(id);
            BancoPoco poco = this.mapConfig.Mapper.Map<BancoPoco>(excluido);
            return poco;
        }

    }
}
