using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharpPlus.Enums;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities.Market
{
    public class MarketOrder
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("group_id")]
        public int GroupId { get; internal set; }
        
        [JsonProperty("user_id")]
        public int CustomerId { get; internal set; }
        
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime OrderDate { get; internal set; }
        
        [JsonProperty("variants_grouping_id")]
        public int VariantsGroupingId { get; internal set; }
        
        [JsonProperty("is_main_variant")]
        public bool IsMainVariant { get; internal set; }
        
        [JsonProperty("property_values")]
        public List<MarketItemVariant> Variants { get; internal set; }
        
        [JsonProperty("cart_quantity")]
        public int CartQuantity { get; internal set; }
        
        [JsonProperty("status")]
        public MarketOrderStatus Status { get; internal set; }
        
        [JsonProperty("items_count")]
        public int OrderQuantity { get; internal set; }
        
        [JsonProperty("total_price")]
        public MarketPrice TotalPrice { get; internal set; }
        
        [JsonProperty("display_order_id")]
        public string DisplayOrderId { get; internal set; }
        
        [JsonProperty("comment")]
        public string OrderComment { get; internal set; }
        
        [JsonProperty("preview_order_items")]
        public List<MarketItem> OrderItemsPreview { get; internal set; }
        
        [JsonProperty("delivery")]
        public MarketDeliveryInfo DeliveryInfo { get; internal set; }
        
        [JsonProperty("recipient")]
        public MarketOrderRecipient Recipient { get; internal set; }
    }
}