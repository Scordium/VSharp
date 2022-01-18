using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.Donut
{
    public sealed class DonutSubscriptionExpiredEventArgs : VkEventArgs
    {
        public int UserId { get; }

        internal DonutSubscriptionExpiredEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            UserId = obj["user_id"].Value<int>();
        }
    }
}