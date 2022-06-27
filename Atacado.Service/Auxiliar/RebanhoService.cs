using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Auxiliar;
using Atacado.Poco.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Auxiliar
{
    public class RebanhoService : BaseAncestralService<RebanhoPoco, Rebanho>
    {
        private RebanhoRepository repositorio;
        private RebanhoMapper mapConfig;

        public RebanhoService()
        {
            this.repositorio = new RebanhoRepository(new AtacadoContext());
            this.mapConfig = new RebanhoMapper();
        }

        public List<RebanhoPoco> Listar(int pular, int exibir)
        {
            List<Rebanho> listDOM = this.repositorio.Read(pular, exibir).ToList();
            return ProcessarListaDOM(listDOM);
        }

        protected override List<RebanhoPoco> ProcessarListaDOM(List<Rebanho> listDOM)
        {
            return listDOM.Select(dom => this.mapConfig.Mapper.Map<RebanhoPoco>(dom)).ToList();
        }


        public List<RebanhoPoco> FiltrarPorAnoRefIdMun(int anoRef, int idMun)
        {
            List<Rebanho> listDOM = this.repositorio.Browse(reb => (reb.AnoRef == anoRef) && (reb.IdMunicipio == idMun)).ToList();
            return ProcessarListaDOM(listDOM);
        }

     
        public override RebanhoPoco Selecionar(int id)
        {
            Rebanho dom = this.repositorio.Read(id);
            RebanhoPoco poco = this.mapConfig.Mapper.Map<RebanhoPoco>(dom);
            return poco;
        }

        public override RebanhoPoco Criar(RebanhoPoco obj)
        {
            Rebanho dom = this.mapConfig.Mapper.Map<Rebanho>(obj);
            Rebanho criado = this.repositorio.Add(dom);
            RebanhoPoco poco = this.mapConfig.Mapper.Map<RebanhoPoco>(criado);
            return poco;
        }

        public override RebanhoPoco Atualizar(RebanhoPoco obj)
        {
            Rebanho dom = this.mapConfig.Mapper.Map<Rebanho>(obj);
            Rebanho atualizado = this.repositorio.Edit(dom);
            RebanhoPoco poco = this.mapConfig.Mapper.Map<RebanhoPoco>(atualizado);
            return poco;
        }

        public override RebanhoPoco Excluir(RebanhoPoco obj)
        {
            return this.Excluir(obj.IdRebanho);
        }
        public override RebanhoPoco Excluir(int id)
        {
            Rebanho excluido = this.repositorio.DeleteById(id);
            RebanhoPoco poco = this.mapConfig.Mapper.Map<RebanhoPoco>(excluido);
            return poco;
        }

    }
}
