using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VSharp.Enums;
using VSharp.Utils;

namespace VSharp.EventArgs.Group
{
    public sealed class GroupUserBlacklistedEventArgs : VkEventArgs
    {
        public int AdminId { get; }
        public int UserId { get; }
        
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime UnblacklistedDate { get; }
        public BanReason BanReason { get;}
        public string Comment { get; }


        public GroupUserBlacklistedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            AdminId = obj["admin_id"].Value<int>();;
            UserId = obj["user_id"].Value<int>();;
            UnblacklistedDate = ToObject<DateTime>(obj["unblock_date"]);
            BanReason = ToObject<BanReason>(obj["ban_reason"]);
            Comment = obj["comment"].Value<string>();;
        }
    }
}