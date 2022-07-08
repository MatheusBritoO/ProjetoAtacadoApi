using Atacado.EF.Database;
using Atacado.Envelope.Auxiliar;
using Atacado.Mapper.Ancestral;
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
    public class TipoAquiculturaService : BaseEnvelopadaService<TipoAquiculturaPoco, TipoAquicultura, TipoAquiculturaEnvelopeJSON>
    {
        private TipoAquiculturaRepository repositorio;

        public TipoAquiculturaService() : base()
        {
            this.mapeador = new MapeadorGenericoEnvelopado<TipoAquiculturaPoco, TipoAquicultura, TipoAquiculturaEnvelopeJSON>();
            this.repositorio = new TipoAquiculturaRepository(new AtacadoContext());
        }

        public List<TipoAquiculturaEnvelopeJSON> Listar()
        {
            List<TipoAquicultura> listDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listDOM);
        }

        public List<TipoAquiculturaEnvelopeJSON> Listar(int pular, int exibir)
        {
            List<TipoAquicultura> listaDom = this.repositorio.Read(pular, exibir).ToList();
            return this.ProcessarListaDOM(listaDom);
        }

        protected override List<TipoAquiculturaEnvelopeJSON> ProcessarListaDOM(List<TipoAquicultura> listDOM)
        {
            List<TipoAquiculturaEnvelopeJSON> lista = listDOM.Select(dom => this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(dom)).ToList();
            lista.ForEach(json => json.SetLinks());
            return lista;
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
            TipoAquicultura temp = this.mapeador.Mecanismo.Map<TipoAquicultura>(obj);
            TipoAquicultura excluido = this.repositorio.Delete(temp);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(excluido);
            json.SetLinks();
            return json;
        }

        public override TipoAquiculturaEnvelopeJSON Excluir(int id)
        {
            TipoAquicultura excluido = this.repositorio.DeleteById(id);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(excluido);
            json.SetLinks();
            return json;

        }

        public override TipoAquiculturaEnvelopeJSON Selecionar(int id)
        {
            TipoAquicultura selecionado = this.repositorio.Read(id);
            TipoAquiculturaEnvelopeJSON json = this.mapeador.Mecanismo.Map<TipoAquiculturaEnvelopeJSON>(selecionado);
            json.SetLinks();
            return json; ;
        }
    }
}
