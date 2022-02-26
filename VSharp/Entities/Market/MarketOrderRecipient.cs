using Newtonsoft.Json;

namespace VSharpPlus.Entities.Market
{
    public class MarketOrderRecipient
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }
        
        [JsonProperty("phone")]
        public string Phone { get; internal set; }
        
        [JsonProperty("display_text")]
        public string DisplayText { get; internal set; }
    }
}