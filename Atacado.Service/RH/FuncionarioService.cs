using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.RH;
using Atacado.Repository.RH;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.RH
{
    public  class FuncionarioService : BaseAncestralService<FuncionarioPoco, Funcionario>
    {
        private FuncionarioRepository repositorio;

        public FuncionarioService() : base()
        {
            this.mapeador = new MapeadorGenerico<FuncionarioPoco, Funcionario>();
            this.repositorio = new FuncionarioRepository(new AtacadoContext());
        }

        public List<FuncionarioPoco> Listar(int pular , int exibir)
        {
            List<Funcionario> listaDom = this.repositorio.Read(pular, exibir).ToList();
            return this.ProcessarListaDOM(listaDom);
        }

        protected override List<FuncionarioPoco> ProcessarListaDOM(List<Funcionario> listDOM)
        {
            return listDOM.Select(dom => this.mapeador.Mecanismo.Map<FuncionarioPoco>(dom)).ToList();
        }

    }
}

