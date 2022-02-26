using Newtonsoft.Json;

namespace VSharpPlus.Entities
{
    public class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}