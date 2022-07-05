using Atacado.Mapper.Ancestral;

namespace Atacado.Service.Ancestral
{
    public abstract class BaseEnvelopadaService<TPoco, TDom, TEnvelope>
        where TPoco : class
        where TDom : class
        where TEnvelope : class
    {
        protected MapeadorGenericoEnvelopado<TPoco,TDom ,TEnvelope> mapeador;
        protected List<string> mensagensProcessamentos;
        public List<string> MensagensProcessamentos => this.mensagensProcessamentos;

        public BaseEnvelopadaService()
        {
            this.mensagensProcessamentos = new List<string>();
        }
        public virtual TEnvelope Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public virtual TEnvelope Criar(TPoco obj)
        {
            throw new NotImplementedException();
        }

        public virtual TEnvelope Atualizar(TPoco obj)
        {
            throw new NotImplementedException();
        }

        public virtual TEnvelope Excluir(TPoco obj)
        {
            throw new NotImplementedException();
        }
        public virtual TEnvelope Excluir(int id)
        {
            throw new NotImplementedException();
        }
        protected virtual List<TEnvelope> ProcessarListaDOM(List<TDom> listDOM)
        {
            throw new NotImplementedException();
        }
    }
}
