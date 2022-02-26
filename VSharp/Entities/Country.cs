using Newtonsoft.Json;

namespace VSharp.Entities
{
    public class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}