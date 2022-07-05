using Newtonsoft.Json;


namespace Atacado.Envelope.Ancestral
{
    public abstract class BaseEnvelopeJSON
    {
        [JsonProperty(PropertyName = "_links")]
        public DataLinks Links{ get; set; }

        public abstract void SetLinks();

        public BaseEnvelopeJSON()
        {
            this.Links = new DataLinks();
        }
    }
}
