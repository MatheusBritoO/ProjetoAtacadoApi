using Newtonsoft.Json;

namespace Atacado.Envelope.Ancestral
{
    public class DataLinks
    {
        [JsonProperty(PropertyName = "list")]
        public string List { get; set; }

        [JsonProperty(PropertyName = "self")]
        public string Self { get; set; }

        [JsonProperty(PropertyName = "exclude")]
        public string Exclude { get; set; }

        [JsonProperty(PropertyName = "update")]
        public string Update { get; set; }

        [JsonProperty(PropertyName = "create")]
        public string Create { get; set; }


        public bool ShouldSerializeList()
        {
            return !string.IsNullOrEmpty(List);
        }

        public bool ShouldSerializeSelf()
        {
            return !string.IsNullOrEmpty(Self);
        }

        public bool ShouldSerializeExclude()
        {
            return !string.IsNullOrEmpty(Exclude);
        }

        public bool ShouldSerializeUpdate()
        {
            return !string.IsNullOrEmpty(Update);
        }

        public bool ShouldSerializeCreate()
        {
            return !string.IsNullOrEmpty(Create);
        }

    }
}