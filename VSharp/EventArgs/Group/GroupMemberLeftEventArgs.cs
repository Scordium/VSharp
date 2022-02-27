using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Group
{
    public sealed class GroupMemberLeftEventArgs : VkEventArgs
    {
        public int UserId { get; }
        public bool LeftSelf { get; }

        internal GroupMemberLeftEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            UserId = obj["user_id"].Value<int>();;
            LeftSelf = ToObject<bool>(obj["self"]);
        }
    }
}