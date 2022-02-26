using Newtonsoft.Json;

namespace VSharpPlus.Entities.Market
{
    public class MarketCurrency
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}