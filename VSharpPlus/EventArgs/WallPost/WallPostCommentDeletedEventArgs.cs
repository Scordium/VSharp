using System;
using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.WallPost
{
    public sealed class WallPostCommentDeletedEventArgs : VkEventArgs
    {
        public int WallOwnerId { get; }
        public int Id { get; }
        public int DeleterId { get; }
        public int PostId { get; }


        internal WallPostCommentDeletedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            WallOwnerId = obj["owner_id"].Value<int>();;
            Id = obj["id"].Value<int>();;
            DeleterId = obj["user_id"].Value<int>();;
            PostId = obj["post_id"].Value<int>();;
        }
    }
}