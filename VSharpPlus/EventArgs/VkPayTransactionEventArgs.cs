using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VSharpPlus.Utils;

namespace VSharpPlus.EventArgs
{
    public sealed class VkPayTransactionEventArgs : VkEventArgs
    {
        public int FromId { get; }
        public float Amount { get; }
        public string Description { get; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime TransactionDate { get; }

        internal VkPayTransactionEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            FromId = obj["from_id"].Value<int>();;
            Amount = obj["amount"].Value<float>();;
            Description = obj["description"].Value<string>();;
            TransactionDate = ToObject<DateTime>(obj["transactionDate"]);
        }
        
    }
}