using VSharp.Entities.Topic;

namespace VSharp.EventArgs.Topic
{
    public sealed class TopicCommentEditedEventArgs : VkEventArgs
    {
        public TopicComment Comment { get; }

        internal TopicCommentEditedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<TopicComment>(payloadObject);
        }
    }
}