using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.Group
{
    public sealed class GroupUserUnblacklistedEventArgs : VkEventArgs
    {
        public int AdminId { get; }
        public int UserId { get; }
        public bool ByEndDate { get; }

        internal GroupUserUnblacklistedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            AdminId = obj["admin_id"].Value<int>();;
            UserId = obj["user_id"].Value<int>();;
            ByEndDate = ToObject<bool>(obj["by_end_date"]);
        }
    }
}