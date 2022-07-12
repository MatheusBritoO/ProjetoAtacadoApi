using Atacado.EF.Database;
using Atacado.Envelope.Auxiliar;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;

namespace Atacado.Service.Auxiliar
{
    public class AquiculturaService : BaseEnvelopadaService<AquiculturaPoco, Aquicultura, AquiculturaEnvelopeJSON>
    {
        private AquiculturaRepository repositorio;

        public AquiculturaService() : base()
        {
            this.mapeador = new MapeadorGenericoEnvelopado<AquiculturaPoco, Aquicultura, AquiculturaEnvelopeJSON>();
            this.repositorio = new AquiculturaRepository(new AtacadoContext());
        }

        public AquiculturaService(AtacadoContext contexto) : base()
        {
            this.mapeador = new MapeadorGenericoEnvelopado<AquiculturaPoco, Aquicultura, AquiculturaEnvelopeJSON>();
            this.repositorio = new AquiculturaRepository(contexto);
        }


        public override AquiculturaEnvelopeJSON Atualizar(AquiculturaPoco obj)
        {
            Aquicultura temp = this.mapeador.Mecanismo.Map<Aquicultura>(obj);
            Aquicultura editado = this.repositorio.Edit(temp);
            AquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<AquiculturaEnvelopeJSON>(editado);
            json.SetLinks();
            return json;
        }

        public override AquiculturaEnvelopeJSON Criar(AquiculturaPoco obj)
        {
            Aquicultura temp = this.mapeador.Mecanismo.Map<Aquicultura>(obj);
            Aquicultura criado = this.repositorio.Add(temp);
            AquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<AquiculturaEnvelopeJSON>(criado);
            json.SetLinks();
            return json;
        }

        public override AquiculturaEnvelopeJSON Excluir(AquiculturaPoco obj)
        {
            return this.Excluir(obj.IdAquicultura);
        }

        public override AquiculturaEnvelopeJSON Excluir(int id)
        {
            Aquicultura excluido = this.repositorio.DeleteById(id);
            AquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<AquiculturaEnvelopeJSON>(excluido);
            json.SetLinks();
            return json;
        }

        public List<AquiculturaEnvelopeJSON> Listar(int pular, int exibir)
        {
            List<Aquicultura> listaDOM = this.repositorio.Read(pular, exibir).ToList();
            return this.ProcessarListaDOM(listaDOM);
        }

        protected override List<AquiculturaEnvelopeJSON> ProcessarListaDOM(List<Aquicultura> listDOM)
        {
            List<AquiculturaEnvelopeJSON> lista =
                listDOM.Select(dom => this.mapeador.Mecanismo.Map<AquiculturaEnvelopeJSON>(dom)).ToList();
            lista.ForEach(json => json.SetLinks());
            return lista;
        }

        public override AquiculturaEnvelopeJSON Selecionar(int id)
        {
            Aquicultura busca = this.repositorio.Read(id);
            AquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<AquiculturaEnvelopeJSON>(busca);
            json.SetLinks();
            return json;
        }
    }
}