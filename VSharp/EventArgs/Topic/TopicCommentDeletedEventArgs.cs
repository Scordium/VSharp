using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.Topic
{
    public sealed class TopicCommentDeletedEventArgs : VkEventArgs
    {
        public int TopicId { get; }
        public int TopicOwnerId { get; }
        public int CommentId { get; }

        internal TopicCommentDeletedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            TopicId = (int) obj["topic_id"];
            TopicOwnerId = (int) obj["topic_owner_id"];
            CommentId = (int) obj["id"];
        }
    }
}