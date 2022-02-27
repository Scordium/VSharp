using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Donut
{
    public sealed class DonutMoneyWithdrawnEventArgs : VkEventArgs
    {
        public float Amount { get; }
        public float AmountWithoutFee { get; }

        internal DonutMoneyWithdrawnEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            Amount = obj["amount"].Value<float>();;
            AmountWithoutFee = obj["amount_without_fee"].Value<float>();;
        }
    }
}