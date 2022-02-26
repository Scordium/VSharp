using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharpPlus.Enums;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities.WallPost
{
    public class WallPost
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("owner_id")]
        public int WallOwnerId { get; internal set; }
        
        [JsonProperty("author_id")]
        public int AuthorId { get; internal set; }
        
        [JsonProperty("created_by")]
        public int? CreatorId { get; internal set; }
        
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        
        [JsonProperty("text")]
        public string Content { get; internal set; }
        
        [JsonProperty("reply_owner_id")]
        public int ReplyOwnerId { get; internal set; }
        
        [JsonProperty("reply_post_id")]
        public int ReplyPostId { get; internal set; }
        
        [JsonProperty("friends_only")]
        public bool? FriendsOnly { get; internal set; }
        
        [JsonProperty("comments")]
        public Comments Comments { get; internal set; }
        
        [JsonProperty("copyright")]
        public Copyright Copyright { get; internal set; }
        
        [JsonProperty("likes")]
        public Likes Likes { get; internal set; }
        
        [JsonProperty("reposts")]
        public Reposts Reposts { get; internal set; }
        
        [JsonProperty("post_type")]
        public PostType PostType { get; internal set; }
        
        [JsonProperty("post_source")]
        public PostSource PostSource { get; internal set; }
        
        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; internal set; }
        
        [JsonProperty("geo")]
        public Geolocation Geo { get; internal set; }
        
        [JsonProperty("signer_id")]
        public int? SignerId { get; internal set; }
        
        [JsonProperty("copy_history")]
        public List<WallPost>? RepostHistory { get; internal set; }
        
        [JsonProperty("can_pin")]
        public bool CanPin { get; internal set; }
        
        [JsonProperty("can_delete")]
        public bool CanDelete { get; internal set; }
        
        [JsonProperty("can_edit")]
        public bool CanEdit { get; internal set; }
        
        [JsonProperty("is_pinned")]
        public bool? IsPinned { get; internal set; }
        
        [JsonProperty("marked_as_ads")]
        public bool IsAdvertisement { get; internal set; }
        
        [JsonProperty("is_favorite")]
        public bool Favorited { get; internal set; }
        
        [JsonProperty("donut")]
        public VkDonut Donut { get; internal set; }
        
        [JsonProperty("postponed_id")]
        public int? PostponedId { get; internal set; }
    }
}