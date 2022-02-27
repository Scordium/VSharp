using VSharp.Entities.Topic;

namespace VSharp.EventArgs.Topic
{
    public sealed class TopicCommentCreatedEventArgs : VkEventArgs
    {
        public TopicComment Comment { get; }

        internal TopicCommentCreatedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<TopicComment>(payloadObject);
        }
    }
}