using Newtonsoft.Json;

namespace VSharpPlus.Entities
{
    public class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("title")]
        public string Name { get; set; }
    }
}