using Newtonsoft.Json;

namespace VSharp.Entities.Market
{
    public class MarketItemVariant
    {
        [JsonProperty("variant_id")]
        public int Id { get; internal set; }
        
        [JsonProperty("variant_name")]
        public string Name { get; internal set; }
        
        [JsonProperty("property_name")]
        public string PropertyName { get; internal set; }
    }
}