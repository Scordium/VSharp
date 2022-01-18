using Newtonsoft.Json;

namespace VSharpPlus.Entities.Media
{
    public sealed class PhotoComment : Comment
    {
        [JsonProperty("photo_id")]
        public int PhotoId { get; internal set; }
        
        [JsonProperty("photo_owner_id")]
        public int PhotoOwnerId { get; internal set; }
    }
}