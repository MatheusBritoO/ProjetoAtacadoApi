using Atacado.Envelope.Ancestral;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Envelope.Auxiliar
{
    public class TipoAquiculturaEnvelopeJSON : BaseEnvelopeJSON
    {
        
        [JsonProperty(PropertyName = "idtipoaquicultura")]
        public int IdTipoAquicultura { get; set; }
        [JsonProperty(PropertyName = "descricaotipoaquicultura")]
        public string DescricaoTipoAquicultura { get; set; }
        
        public bool? Situacao { get; set; }

        public override void SetLinks()
        {
            this.Links.List = "GET / TipoAquicultura";
            this.Links.Self = "GET / TipoAquicultura /" + this.IdTipoAquicultura.ToString();
            this.Links.Exclude = "DELETE / TipoAquicultura /" + this.IdTipoAquicultura.ToString();
            this.Links.Update = "PUT / TipoAquicultura  ";
            this.Links.Create = "POST / TipoAquicultura ";
        }
    }
}
