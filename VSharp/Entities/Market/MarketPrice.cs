using Newtonsoft.Json;

namespace VSharp.Entities.Market
{
    public class MarketPrice
    {
        [JsonProperty("amount")]
        public float Amount
        {
            get => _amount; 
            internal set => _amount = value/100; 
        }

        private float _amount;
        
        [JsonProperty("currency")]
        public MarketCurrency Currency { get; internal set; }
        
        [JsonProperty("text")]
        public string Description { get; internal set; }

        [JsonProperty("old_amount")]
        public float? OldAmount { get; internal set; }
    }
}