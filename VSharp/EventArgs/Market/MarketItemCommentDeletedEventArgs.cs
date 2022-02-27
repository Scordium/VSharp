using Newtonsoft.Json.Linq;

namespace VSharp.EventArgs.Market
{
    public sealed class MarketItemCommentDeletedEventArgs : VkEventArgs
    {
        public int MarketItemOwnerId { get; }
        public int Id { get; }
        
        //API does not send this field even though its documented.
        //public int AuthorId { get; }
        public int DeleterId { get; }
        public int MarketItemId { get; }

        internal MarketItemCommentDeletedEventArgs(dynamic payloadObject)
        {
            var obj = (JObject) JObject.Parse(payloadObject.ToString());

            MarketItemOwnerId = obj["owner_id"].Value<int>();
            Id = obj["id"].Value<int>();
            //AuthorId = obj["user_id"].Value<int>();
            DeleterId = obj["deleter_id"].Value<int>();
            MarketItemId = obj["item_id"].Value<int>();
        }
    }
}