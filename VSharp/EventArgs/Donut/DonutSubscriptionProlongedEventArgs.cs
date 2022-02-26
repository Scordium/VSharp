using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Donut
{
    public sealed class DonutSubscriptionProlongedEventArgs : VkEventArgs
    {
        public int Amount { get; }
        public float AmountWithoutFee { get; }
        public int UserId { get; }

        internal DonutSubscriptionProlongedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            Amount = obj["amount"].Value<int>();;
            AmountWithoutFee = obj["amount_without_fee"].Value<float>();;
            UserId = obj["user_id"].Value<int>();;
        }
    }
}