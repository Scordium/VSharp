using Newtonsoft.Json;

namespace VSharp.Entities
{
    public class Likes
    {
        [JsonProperty("count")]
        public int Count { get; internal set; }
        
        [JsonProperty("user_likes")]
        public bool Liked { get; internal set; }
        
        [JsonProperty("can_like")]
        public bool? CanLike { get; internal set; }
        
        [JsonProperty("can_repost")]
        public bool? CanRepost { get; internal set; }
    }
}