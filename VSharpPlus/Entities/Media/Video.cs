using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharpPlus.Enums;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities.Media
{
    public class Video
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("owner_id")]
        public int OwnerId { get; internal set; }
        
        [JsonProperty("title")]
        public string Title { get; internal set; }
        
        [JsonProperty("description")]
        public string Description { get; internal set; }
        
        [JsonProperty("duration")]
        public int Duration { get; internal set; }
        
        [JsonProperty("image")]
        public List<ImageSize> ThumbnailSizes { get; internal set; }
        
        [JsonProperty("first_frame")]
        public List<ImageSize> FirstFrameSizes { get; internal set; }
        
        [JsonProperty("adding_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime UploadDate { get; internal set; }
        
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        
        [JsonProperty("views")]
        public int ViewsCount { get; internal set; }
        
        [JsonProperty("local_views")]
        public int LocalViewsCount { get; internal set; }
        
        
        [JsonProperty("comments")]
        public int CommentsCount { get; internal set; }
        
        [JsonProperty("player")]
        public string Url { get; internal set; }
        
        [JsonProperty("platform")]
        public string? Platform { get; internal set; }
        
        [JsonProperty("can_add")]
        public bool? CanAdd { get; internal set; }
        
        [JsonProperty("is_private")]
        public bool? IsPrivate { get; internal set; }

        [JsonProperty("access_key")]
        public string? AccessToken { get; internal set; }
        
        [JsonProperty("processing")]
        public bool? Processing { get; internal set; }
        
        [JsonProperty("is_favorite")]
        public bool Favorited { get; internal set; }
        
        [JsonProperty("can_comment")]
        public bool CanComment { get; internal set; }
        
        [JsonProperty("can_edit")]
        public bool CanEdit { get; internal set; }
        
        [JsonProperty("can_like")]
        public bool CanLike { get; internal set; }
        
        [JsonProperty("can_repost")]
        public bool CanRepost { get; internal set; }
        
        [JsonProperty("can_subscribe")]
        public bool CanSubscribe { get; internal set; }
        
        [JsonProperty("can_add_to_faves")]
        public bool CanFavorite { get; internal set; }
        
        [JsonProperty("can_attach_link")]
        public bool CanAttachLink { get; internal set; }
        
        [JsonProperty("witdh")]
        public int Width { get; internal set; }
        
        [JsonProperty("height")]
        public int Height { get; internal set; }
        
        [JsonProperty("user_id")]
        public int? UploaderId { get; internal set; }
        
        [JsonProperty("converting")]
        public bool Converting { get; internal set; }
        
        [JsonProperty("added")]
        public bool AddedToAlbum { get; internal set; }
        
        [JsonProperty("is_subscribed")]
        public bool Subscribed { get; internal set; }
        
        [JsonProperty("repeat")]
        public bool? Looped { get; internal set; }
        
        [JsonProperty("type")]
        public string Type { get; internal set; }
        
        [JsonProperty("balance")]
        public int? Balance { get; internal set; }
        
        [JsonProperty("live_status")]
        public LivestreamStatus? LivestreamStatus { get; internal set; }
        
        [JsonProperty("live")]
        public bool? IsLivestream  { get; internal set; }
        
        [JsonProperty("upcoming")]
        public bool? IsUpcoming { get; internal set; }
        
        [JsonProperty("spectators")]
        public int? Spectators { get; internal set; }
        
        [JsonProperty("likes")]
        public Likes Likes { get; internal set; }
        
        [JsonProperty("reposts")]
        public Reposts Reposts { get; internal set; }
        
        
    }
}