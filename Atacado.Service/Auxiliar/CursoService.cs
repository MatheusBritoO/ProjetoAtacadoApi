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
    public class CursoService : BaseAncestralService<CursoPoco>
    {
        private CursoDao dao;
        private CursoMapper mapConfig;

        public CursoService()
        {
            this.dao = new CursoDao();
            this.mapConfig = new CursoMapper();
        }

        public override List<CursoPoco> Listar()
        {
            List<Curso> listDOM = this.dao.ReadAll();
            List<CursoPoco> listPOCO = new List<CursoPoco>();
            foreach (Curso item in listDOM)
            {
                CursoPoco poco = this.mapConfig.Mapper.Map<CursoPoco>(item);
                listPOCO.Add(poco);
            }
            return listPOCO;
        }

        public override CursoPoco Selecionar(int id)
        {
            Curso dom = this.dao.Read(id);
            CursoPoco poco = this.mapConfig.Mapper.Map<CursoPoco>(dom);
            return poco;
        }

        public override CursoPoco Criar(CursoPoco obj)
        {
            Curso dom = this.mapConfig.Mapper.Map<Curso>(obj);
            Curso criado = this.dao.Create(dom);
            CursoPoco poco = this.mapConfig.Mapper.Map<CursoPoco>(criado);
            return poco;
        }

        public override CursoPoco Atualizar(CursoPoco obj)
        {
            Curso dom = this.mapConfig.Mapper.Map<Curso>(obj);
            Curso atualizado = this.dao.Update(dom);
            CursoPoco poco = this.mapConfig.Mapper.Map<CursoPoco>(atualizado);
            return poco;
        }

        public override CursoPoco Excluir(CursoPoco obj)
        {
            return this.Excluir(obj.IdCurso);
        }
        public override CursoPoco Excluir(int id)
        {
            Curso excluido = this.dao.Delete(id);
            CursoPoco poco = this.mapConfig.Mapper.Map<CursoPoco>(excluido);
            return poco;
        }
    }
}
