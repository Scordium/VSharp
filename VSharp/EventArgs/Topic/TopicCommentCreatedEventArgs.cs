using Newtonsoft.Json.Linq;
using VSharpPlus.Entities.Topic;

namespace VSharpPlus.EventArgs.Topic
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