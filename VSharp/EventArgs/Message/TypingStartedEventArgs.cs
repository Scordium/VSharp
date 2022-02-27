using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Message
{
    public sealed class TypingStartedEventArgs : VkEventArgs
    {
        public int AuthorId { get; }
        public int ReceiverId { get; }

        internal TypingStartedEventArgs(dynamic payloadData)
        {
            var data = (JObject)JObject.Parse(payloadData.ToString());
            AuthorId = data["from_id"].Value<int>();
            ReceiverId = data["to_id"].Value<int>();
        }
    }
}