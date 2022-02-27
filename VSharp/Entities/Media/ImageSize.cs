using Newtonsoft.Json;

namespace VSharp.Entities.Media
{
    public class ImageSize
    {
        [JsonProperty("type")]
        public string? Type { get; internal set; }
        [JsonProperty("url")]
        public string Url { get; internal set; }
        [JsonProperty("width")]
        public int Width { get; internal set; }
        [JsonProperty("height")]
        public int Height { get; internal set; }
    }
}