using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
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
    public class BancoService : BaseAncestralService<BancoPoco, Banco>
    {
        private BancoRepository repositorio;
        

        public BancoService(AtacadoContext contexto)
        {
            this.repositorio = new BancoRepository(contexto);
            this.mapeador = new MapeadorGenerico<BancoPoco, Banco>();
           
        }

        public override List<BancoPoco> Listar()
        {
            List<Banco> listDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listDOM);
        }

        public override BancoPoco Selecionar(int id)
        {
            Banco dom = this.repositorio.Read(id);
            BancoPoco poco = this.mapeador.Mecanismo.Map<BancoPoco>(dom);
            return poco;
        }

        public override BancoPoco Criar(BancoPoco obj)
        {
            Banco dom = this.mapeador.Mecanismo.Map<Banco>(obj);
            Banco criado = this.repositorio.Add(dom);
            BancoPoco poco = this.mapeador.Mecanismo.Map<BancoPoco>(criado);
            return poco;
        }

        public override BancoPoco Atualizar(BancoPoco obj)
        {
            Banco dom = this.mapeador.Mecanismo.Map<Banco>(obj);
            Banco atualizado = this.repositorio.Edit(dom);
            BancoPoco poco = this.mapeador.Mecanismo.Map<BancoPoco>(atualizado);
            return poco;
        }

        public override BancoPoco Excluir(BancoPoco obj)
        {
            return this.Excluir(obj.IdBanco);
        }
        public override BancoPoco Excluir(int id)
        {
            Banco excluido = this.repositorio.DeleteById(id);
            BancoPoco poco = this.mapeador.Mecanismo.Map<BancoPoco>(excluido);
            return poco;
        }

        protected override List<BancoPoco> ProcessarListaDOM(List<Banco> listDOM)
        {
            return listDOM.Select(dom => this.mapeador.Mecanismo.Map<BancoPoco>(dom)).ToList();
        }
    }
}
