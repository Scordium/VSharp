using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharp.Entities.Media;
using VSharp.Enums;
using VSharp.Utils;

namespace VSharp.Entities.Market
{
    public class MarketItem
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("owner_id")]
        public int OwnerId { get; internal set; }
        
        [JsonProperty("title")]
        public string Title { get; internal set; }
        
        [JsonProperty("description")]
        public string Description { get; internal set; }
        
        [JsonProperty("price")]
        public MarketPrice Price { get; internal set; }
        
        [JsonProperty("dimensions")]
        public MarketItemDimensions Dimensions { get; internal set; }
        
        [JsonProperty("weight")]
        public int Weight { get; internal set; }
        
        [JsonProperty("category")]
        public MarketCategory Category { get; internal set; }
        
        [JsonProperty("thumb_photo")]
        public string Thumbnail { get; internal set; }
        
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        
        [JsonProperty("availability")]
        public MarketItemAvailability Availability { get; internal set; }
        
        [JsonProperty("is_favorite")]
        public bool Favorited { get; internal set; }
        
        [JsonProperty("sku")]
        public string SKU { get; internal set; }
        
        [JsonProperty("photos")]
        public List<Photo>? Photos { get; internal set; }
        
        [JsonProperty("can_comment")]
        public bool? CanComment { get; internal set; }
        
        [JsonProperty("can_repost")]
        public bool? CanRepost { get; internal set; }
        
        [JsonProperty("likes")]
        public Likes? Likes { get; internal set; }
        
        [JsonProperty("url")]
        public string? Url { get; internal set; }
        
        [JsonProperty("button_title")]
        public string? ButtonTitle { get; internal set; }
    }
}