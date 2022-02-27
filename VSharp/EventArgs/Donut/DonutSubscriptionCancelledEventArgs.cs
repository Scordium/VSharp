using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Donut
{
    public sealed class DonutSubscriptionCancelledEventArgs : VkEventArgs
    {
        public int UserId { get; }

        internal DonutSubscriptionCancelledEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            UserId = obj["user_id"].Value<int>();
        }
    }
}