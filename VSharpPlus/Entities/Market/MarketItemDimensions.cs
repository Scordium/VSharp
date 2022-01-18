using Newtonsoft.Json;

namespace VSharpPlus.Entities.Market
{
    public class MarketItemDimensions
    {
        [JsonProperty("width")]
        public int Width  { get; internal set; }
        
        [JsonProperty("height")]
        public int Height { get; internal set; }
        
        [JsonProperty("length")]
        public int Length { get; internal set; }
    }
}