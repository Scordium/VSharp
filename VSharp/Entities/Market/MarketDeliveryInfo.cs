using Newtonsoft.Json;

namespace VSharpPlus.Entities.Market
{
    public class MarketDeliveryInfo
    {
        [JsonProperty("address")]
        public string Address { get; internal set; }
        
        [JsonProperty("type")]
        public string Type { get; internal set; }
        
        [JsonProperty("track_number")]
        public string TrackNumber { get; internal set; }
        
        [JsonProperty("track_link")]
        public string TrackLink { get; internal set; }
        
        //Why is there no fucking info about this entity?
        //https://vk.com/dev/objects/market_order
        //PR this if the issue resolves.
        
        [JsonProperty("delivery_point")]
        public dynamic DeliveryPoint { get; internal set; }
    }
}