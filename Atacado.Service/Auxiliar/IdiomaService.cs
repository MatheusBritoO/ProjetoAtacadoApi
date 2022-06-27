using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Auxiliar
{
    public class IdiomaService : BaseAncestralService<IdiomaPoco, Idioma>
    {
        private IdiomaRepository repositorio;
        private IdiomaMapper mapConfig;

        public IdiomaService()
        {
            this.repositorio = new IdiomaRepository(new AtacadoContext());
            this.mapConfig = new IdiomaMapper();
        }

        public override List<IdiomaPoco> Listar()
        {
            List<Idioma> listDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listDOM);
        }

        public override IdiomaPoco Selecionar(int id)
        {
            Idioma dom = this.repositorio.Read(id);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(dom);
            return poco;
        }

        public override IdiomaPoco Criar(IdiomaPoco obj)
        {
            Idioma dom = this.mapConfig.Mapper.Map<Idioma>(obj);
            Idioma criado = this.repositorio.Add(dom);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(criado);
            return poco;
        }

        public override IdiomaPoco Atualizar(IdiomaPoco obj)
        {
            Idioma dom = this.mapConfig.Mapper.Map<Idioma>(obj);
            Idioma atualizado = this.repositorio.Edit(dom);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(atualizado);
            return poco;
        }

        public override IdiomaPoco Excluir(IdiomaPoco obj)
        {
            return this.Excluir(obj.IdIdioma);
        }
        public override IdiomaPoco Excluir(int id)
        {
            Idioma excluido = this.repositorio.DeleteById(id);
            IdiomaPoco poco = this.mapConfig.Mapper.Map<IdiomaPoco>(excluido);
            return poco;
        }
    }
}
