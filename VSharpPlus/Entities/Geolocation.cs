using Newtonsoft.Json;

namespace VSharpPlus.Entities
{
    public sealed class Geolocation
    {
        [JsonProperty("type")]
        public string Type { get; internal set; }
        
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; internal set; }
        
        [JsonProperty("place")]
        public Place? Place { get; internal set; }
        
    }
}