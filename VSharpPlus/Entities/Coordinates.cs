using Newtonsoft.Json;

namespace VSharpPlus.Entities
{
    public class Coordinates
    {
        [JsonProperty("latitude")]
        public float Latitude { get; internal set; }
        
        [JsonProperty("longitude")]
        public float Longitude { get; internal set; }
    }
}