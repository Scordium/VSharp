using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Donut
{
    public sealed class DonutMoneyWithdrawErroredEventArgs : VkEventArgs
    {
        public string Reason { get; }

        internal DonutMoneyWithdrawErroredEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());
            
            Reason = obj["reason"].Value<string>();;
        }
    }
}