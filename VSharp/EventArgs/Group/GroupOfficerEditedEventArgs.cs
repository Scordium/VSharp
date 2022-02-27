using Newtonsoft.Json.Linq;
using VSharp.Enums;

namespace VSharp.EventArgs.Group
{
    public sealed class GroupOfficerEditedEventArgs : VkEventArgs
    {
        public int AdminId { get; }
        public int UserId { get; }
        public GroupAdminLevel LevelOld { get; }
        public GroupAdminLevel LevelNew { get; }

        internal GroupOfficerEditedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            AdminId = obj["admin_id"].Value<int>();;
            UserId = obj["user_id"].Value<int>();;
            LevelOld = ToObject<GroupAdminLevel>(obj["level_old"]);
            LevelNew = ToObject<GroupAdminLevel>(obj["level_new"]);
        }
    }
}