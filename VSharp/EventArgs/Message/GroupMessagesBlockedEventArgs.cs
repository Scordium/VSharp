using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.Message
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