using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Message
{
    public class GroupMessagesBlockedEventArgs : VkEventArgs
    {
        public int UserId { get; }

        internal GroupMessagesBlockedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            UserId = obj["user_id"].Value<int>();;
        }
    }
}