using Newtonsoft.Json;
using VSharpPlus.Entities.WallPost;

namespace VSharpPlus.Entities.Market
{
    public sealed class MarketItemComment : Comment
    {
        [JsonProperty("market_owner_id")]
        public int MarketItemOwnerId { get; internal set; }
        
        [JsonProperty("item_id")]
        public int MarketItemId { get; internal set; }
    }
}