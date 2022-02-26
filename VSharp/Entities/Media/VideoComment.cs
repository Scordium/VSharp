using Newtonsoft.Json;

namespace VSharpPlus.Entities.Media
{
    public sealed class VideoComment : Comment
    {
        [JsonProperty("video_id")]
        public int VideoId { get; internal set; }
        
        [JsonProperty("video_owner_id")]
        public int VideoOwnerId { get; internal set; }
        
    }
}