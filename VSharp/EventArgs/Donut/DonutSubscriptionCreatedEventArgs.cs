using Newtonsoft.Json.Linq;

namespace VSharpPlus.EventArgs.Donut
{
    public sealed class DonutSubscriptionCreatedEventArgs : VkEventArgs
    {
        public int Amount { get; }
        public float AmountWithoutFee { get; }
        public int UserId { get; }

        internal DonutSubscriptionCreatedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            Amount = obj["amount"].Value<int>();;
            AmountWithoutFee = obj["amount_without_fee"].Value<float>();;
            UserId = obj["user_id"].Value<int>();;
        }
        
    }
}