using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs
{
    public sealed class VideoCommentDeletedEventArgs : VkEventArgs
    {
        public int VideoOwnerId { get; }
        public int Id { get; }
        public int DeleterId { get; }
        public int VideoId { get; }


        internal VideoCommentDeletedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            VideoOwnerId = obj["video_owner_id"].Value<int>();;
            Id = obj["id"].Value<int>();;
            DeleterId = obj["user_id"].Value<int>();;
            VideoId = obj["video_id"].Value<int>();;
        }
    }
}