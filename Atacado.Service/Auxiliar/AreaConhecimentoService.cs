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
    public class AreaConhecimentoService
    {
        public class CategoriaService : BaseAncestralService<AreaConhecimentoPoco>
        {
            private AreaConhecimentoDao dao;
            private AreaConhecimentoMapper mapConfig;

            public CategoriaService()
            {
                this.dao = new AreaConhecimentoDao();
                this.mapConfig = new AreaConhecimentoMapper();
            }

            public override List<AreaConhecimentoPoco> Listar()
            {
                List<AreaConhecimento> listDOM = this.dao.ReadAll();
                List<AreaConhecimentoPoco> listPOCO = new List<AreaConhecimentoPoco>();
                foreach (AreaConhecimento item in listDOM)
                {
                    AreaConhecimentoPoco poco = this.mapConfig.Mapper.Map<AreaConhecimentoPoco>(item);
                    listPOCO.Add(poco);
                }
                return listPOCO;
            }

            public override AreaConhecimentoPoco Selecionar(int id)
            {
                AreaConhecimento dom = this.dao.Read(id);
                AreaConhecimentoPoco poco = this.mapConfig.Mapper.Map<AreaConhecimentoPoco>(dom);
                return poco;
            }

            public override AreaConhecimentoPoco Criar(AreaConhecimentoPoco obj)
            {
                AreaConhecimento dom = this.mapConfig.Mapper.Map<AreaConhecimento>(obj);
                AreaConhecimento criado = this.dao.Create(dom);
                AreaConhecimentoPoco poco = this.mapConfig.Mapper.Map<AreaConhecimentoPoco>(criado);
                return poco;
            }

            public override AreaConhecimentoPoco Atualizar(AreaConhecimentoPoco obj)
            {
                AreaConhecimento dom = this.mapConfig.Mapper.Map<AreaConhecimento>(obj);
                AreaConhecimento atualizado = this.dao.Update(dom);
                AreaConhecimentoPoco poco = this.mapConfig.Mapper.Map<AreaConhecimentoPoco>(atualizado);
                return poco;
            }

            public override AreaConhecimentoPoco Excluir(AreaConhecimentoPoco obj)
            {
                return this.Excluir(obj.IdArea);
            }
            public override AreaConhecimentoPoco Excluir(int id)
            {
                AreaConhecimento excluido = this.dao.Delete(id);
                AreaConhecimentoPoco poco = this.mapConfig.Mapper.Map<AreaConhecimentoPoco>(excluido);
                return poco;
            }
        }
    } 
}
