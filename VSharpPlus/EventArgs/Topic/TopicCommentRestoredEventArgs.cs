using Newtonsoft.Json.Linq;
using VSharpPlus.Entities.Topic;

namespace VSharpPlus.EventArgs.Topic
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