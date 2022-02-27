using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Donut
{
    public sealed class DonutSubscriptionPriceChangedEventArgs : VkEventArgs
    {
        public int OldAmount { get; }
        public int NewAmount { get; }
        public float AmountDifference { get; }
        public float AmountDifferenceWithoutFee { get; }
        public int UserId { get; }

        internal DonutSubscriptionPriceChangedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            OldAmount = obj["amount_old"].Value<int>();;
            NewAmount = obj["amount_new"].Value<int>();;
            AmountDifference = obj["amount_diff"].Value<float>();;
            AmountDifferenceWithoutFee = obj["amount_without_fee"].Value<float>();;
            UserId = obj["user_id"].Value<int>();;
        }
        
    }
}