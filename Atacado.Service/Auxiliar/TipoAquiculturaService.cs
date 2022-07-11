using Atacado.EF.Database;
using Atacado.Envelope.Auxiliar;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;

namespace Atacado.Service.Auxiliar
{
    public class TipoAquiculturaService :
        BaseEnvelopadaService<TipoAquiculturaPoco, TipoAquicultura, TipoAquiculturaEnvelopeJSON>
    {
        private TipoAquiculturaRepository repositorio;

        public TipoAquiculturaService() : base()
        {
            this.mapeador = new MapeadorGenericoEnvelopado<TipoAquiculturaPoco, TipoAquicultura, TipoAquiculturaEnvelopeJSON>();
            this.repositorio = new TipoAquiculturaRepository(new AtacadoContext());
        }

        public override TipoAquiculturaEnvelopeJSON Atualizar(TipoAquiculturaPoco obj)
        {
            TipoAquicultura temp = this.mapeador.Mecanismo.Map<TipoAquicultura>(obj);
            TipoAquicultura editado = this.repositorio.Edit(temp);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(editado);
            json.SetLinks();
            return json;
        }

        public override TipoAquiculturaEnvelopeJSON Criar(TipoAquiculturaPoco obj)
        {
            TipoAquicultura temp = this.mapeador.Mecanismo.Map<TipoAquicultura>(obj);
            TipoAquicultura criado = this.repositorio.Add(temp);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(criado);
            json.SetLinks();
            return json;
        }

        public override TipoAquiculturaEnvelopeJSON Excluir(TipoAquiculturaPoco obj)
        {
            return this.Excluir(obj.IdTipoAquicultura);
        }

        public override TipoAquiculturaEnvelopeJSON Excluir(int id)
        {
            TipoAquicultura excluido = this.repositorio.DeleteById(id);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(excluido);
            json.SetLinks();
            return json;
        }

        public  List<TipoAquiculturaEnvelopeJSON> Listar()
        {
            List<TipoAquicultura> listaDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listaDOM);
        }

        public List<TipoAquiculturaEnvelopeJSON> Listar(int pular, int exibir)
        {
            List<TipoAquicultura> listaDOM = this.repositorio.Read(pular, exibir).ToList();
            return this.ProcessarListaDOM(listaDOM);
        }

        protected override List<TipoAquiculturaEnvelopeJSON> ProcessarListaDOM(List<TipoAquicultura> listDOM)
        {
            List<TipoAquiculturaEnvelopeJSON> lista =
                listDOM.Select(dom => this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(dom)).ToList();
            lista.ForEach(json => json.SetLinks());
            return lista;
        }

        public override TipoAquiculturaEnvelopeJSON Selecionar(int id)
        {
            TipoAquicultura busca = this.repositorio.Read(id);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(busca);
            json.SetLinks();
            return json;
        }
    }
}