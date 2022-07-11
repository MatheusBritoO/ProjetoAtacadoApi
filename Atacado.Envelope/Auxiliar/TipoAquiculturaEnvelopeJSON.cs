using Atacado.Envelope.Ancestral;
using Newtonsoft.Json;

namespace Atacado.Envelope.Auxiliar
{
    public class TipoAquiculturaEnvelopeJSON : BaseEnvelopeJSON
    {
        [JsonProperty(PropertyName = "IdTipoAquicultura")]
        public int IdTipoAquicultura { get; set; }

        [JsonProperty(PropertyName = "DescricaoTipoAquicultura")]
        public string DescricaoTipoAquicultura { get; set; }

        [JsonProperty(PropertyName = "Situacao")]
        public bool? Situacao { get; set; }

        public override void SetLinks()
        {
            this.Links.List = "GET /TipoAquicultura";
            this.Links.Self = "GET /TipoAquicultura/" + this.IdTipoAquicultura.ToString();
            this.Links.Exclude = "DELETE /TipoAquicultura/" + this.IdTipoAquicultura.ToString();
            this.Links.Update = "PUT /TipoAquicultura";
            this.Links.Create = "POST /TipoAquicultura";
        }
    }
}