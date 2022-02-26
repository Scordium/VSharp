using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using VSharpPlus.Enums;
#pragma warning disable 8602
#pragma warning disable 8604

namespace VSharpPlus.EventArgs
{
    public sealed class LikeAddedEventArgs : VkEventArgs
    {
        public int LikerId { get; }
        
        public LikedObjectType ObjectType { get; }
        public int ObjectOwnerId { get; }
        public int ObjectId { get; }
        public int ThreadReplyId { get; }
        public int PostId { get; }

        
        internal LikeAddedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            LikerId = (int)obj["liker_id"];
            ObjectType = obj["object_type"].ToObject<LikedObjectType>();
            ObjectOwnerId = (int)obj["object_owner_id"];
            ObjectId = (int)obj["object_id"];
            ThreadReplyId = (int)obj["thread_reply_id"];
            PostId = (int)obj["post_id"];

        }

    }
}