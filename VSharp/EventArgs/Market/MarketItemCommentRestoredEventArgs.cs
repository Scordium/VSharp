using VSharp.Entities.Market;

namespace VSharp.EventArgs.Market
{
    public sealed class MarketItemCommentRestoredEventArgs : VkEventArgs
    {
        public MarketItemComment Comment { get; }

        internal MarketItemCommentRestoredEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<MarketItemComment>(payloadObject);
        }
    }
}