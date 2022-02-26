using Newtonsoft.Json.Linq;
using VSharpPlus.Enums;

namespace VSharpPlus.EventArgs.Group
{
    public sealed class GroupMemberJoinedEventArgs : VkEventArgs
    {
        public int UserId { get; }
        public GroupMemberStatus JoinType { get; }

        internal GroupMemberJoinedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            UserId = obj["user_id"].Value<int>();;
            JoinType = ToObject<GroupMemberStatus>(obj["join_type"]);
        }
        
    }
}