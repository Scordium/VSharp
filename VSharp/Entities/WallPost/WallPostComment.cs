using Newtonsoft.Json;

namespace VSharp.Entities.WallPost
{
    public sealed class WallPostComment : Comment
    {
        [JsonProperty("post_id")]
        public int? PostId { get; internal set; }
        
        [JsonProperty("post_owner_id")]
        public int? PostOwnerId { get; internal set; }
    }
}