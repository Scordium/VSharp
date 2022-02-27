using VSharp.Entities.Topic;

namespace VSharp.EventArgs.Topic
{
    public sealed class TopicCommentRestoredEventArgs : VkEventArgs
    {
        public TopicComment Comment { get; }

        internal TopicCommentRestoredEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<TopicComment>(payloadObject);
        }
    }
}