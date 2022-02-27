using Newtonsoft.Json;

namespace VSharp.Entities.Market
{
    public class MarketCurrency
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}