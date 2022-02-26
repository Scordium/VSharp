using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities.WallPost
{
    public sealed class WallPostComment : Comment
    {
        [JsonProperty("post_id")]
        public int? PostId { get; internal set; }
        
        [JsonProperty("post_owner_id")]
        public int? PostOwnerId { get; internal set; }
    }
}