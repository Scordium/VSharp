using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.Message
{
    public sealed class GroupMessagesAllowedEventArgs : VkEventArgs
    {
        public int UserId { get; }
        public string Key { get; }

        internal GroupMessagesAllowedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            UserId = obj["user_id"].Value<int>();
            Key = obj["key"].Value<string>();
        }
        
        
    }
}