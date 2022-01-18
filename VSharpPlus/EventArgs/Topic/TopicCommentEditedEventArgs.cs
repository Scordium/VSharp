using Newtonsoft.Json.Linq;
using VSharpPlus.Entities.Topic;

namespace VSharpPlus.EventArgs.Topic
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