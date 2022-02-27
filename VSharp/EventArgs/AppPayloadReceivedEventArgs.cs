using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs
{
    public sealed class AppPayloadReceivedEventArgs : VkEventArgs
    {
        public int UserId { get; }
        public int AppId { get; }
        public dynamic Payload { get; }
        public int GroupId { get; }

        internal AppPayloadReceivedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            UserId = obj["user_id"].Value<int>();;
            AppId = obj["app_id"].Value<int>();;
            Payload = ToObject<dynamic>(obj["payload"]);
            GroupId = obj["group_id"].Value<int>();;
        }
    }
}