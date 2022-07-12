using Atacado.EF.Database;
using Atacado.Envelope.RH;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.RH;
using Atacado.Repository.RH;
using Atacado.Service.Ancestral;
namespace Atacado.Service.RH
{
    public class EmpresaService : BaseEnvelopadaService<EmpresaPoco, Empresa, EmpresaEnvelopeJSON>
    {

        private EmpresaRepository repositorio;
       
        public EmpresaService(AtacadoContext contexto) : base()
        {
            this.mapeador = new MapeadorGenericoEnvelopado<EmpresaPoco, Empresa, EmpresaEnvelopeJSON>();
            this.repositorio = new EmpresaRepository(contexto);
        }

        public  List<EmpresaEnvelopeJSON> Listar()
        {
            List<Empresa> listDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listDOM);
        }

        public List<EmpresaEnvelopeJSON> Listar(int pular, int exibir)
        {
            List<Empresa> listaDom = this.repositorio.Read(pular, exibir).ToList();
            return this.ProcessarListaDOM(listaDom);
        }

        protected override List<EmpresaEnvelopeJSON> ProcessarListaDOM(List<Empresa> listDOM)
        {
            List <EmpresaEnvelopeJSON> lista = listDOM.Select(dom => this.mapeador.Mecanismo.Map<EmpresaEnvelopeJSON>(dom)).ToList();
            lista.ForEach(json => json.SetLinks());
            return lista;
        }

        public override EmpresaEnvelopeJSON Atualizar(EmpresaPoco obj)
        {
            Empresa temp = this.mapeador.Mecanismo.Map<Empresa>(obj);
            Empresa editado = this.repositorio.Edit(temp);
            EmpresaEnvelopeJSON json = this.mapeador.Mecanismo.Map<EmpresaEnvelopeJSON>(editado);
            json.SetLinks();
            return json;

           // EmpresaPoco poco = this.mapeador.Mecanismo.Map<EmpresaPoco>(editado);
           // return poco;
        }

        public override EmpresaEnvelopeJSON Criar(EmpresaPoco obj)
        {
            Empresa temp = this.mapeador.Mecanismo.Map<Empresa>(obj);
            Empresa criado = this.repositorio.Add(temp);
            EmpresaEnvelopeJSON json = this.mapeador.Mecanismo.Map<EmpresaEnvelopeJSON>(criado);
            json.SetLinks();
            return json;
        }

        public override EmpresaEnvelopeJSON Excluir(EmpresaPoco obj)
        {
            Empresa temp = this.mapeador.Mecanismo.Map<Empresa>(obj);
            Empresa excluido = this.repositorio.Delete(temp);
            EmpresaEnvelopeJSON json = this.mapeador.Mecanismo.Map<EmpresaEnvelopeJSON>(excluido);
            json.SetLinks();
            return json;
        }

        public override EmpresaEnvelopeJSON Excluir(int id)
        {
            Empresa excluido = this.repositorio.DeleteById(id);
            EmpresaEnvelopeJSON json = this.mapeador.Mecanismo.Map<EmpresaEnvelopeJSON>(excluido);
            json.SetLinks();
            return json;

        }

        public override EmpresaEnvelopeJSON Selecionar(int id)
        {
            Empresa selecionado = this.repositorio.Read(id);
            EmpresaEnvelopeJSON json = this.mapeador.Mecanismo.Map<EmpresaEnvelopeJSON>(selecionado);
            json.SetLinks();
            return json; ;
        }
    }
}
